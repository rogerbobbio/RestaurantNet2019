using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmKitchenMonitor : frmMain
  {
    private int lastPedidoId = 0;
    private int currentLastPedidoId = 0;
    public frmKitchenMonitor()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
    {
      switch (e.KeyCode)
      {
        case Keys.F7:
          this.btnActualizar_Click(null,null);
          break;
        case Keys.F8:
          this.btnInicio_Click(null, null);
          break;
        case Keys.F9:
          this.btnSiguiente_Click(null, null);
          break;
        case Keys.Escape:
          this.btnClose_Click(null,null);
          break;
        default:          
          break;
      }
    }
    private void frmKitchenMonitor_Load(object sender, EventArgs e)
    {
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
      GetOrders();
      setClock();
      lastPedidoId = 0;
      currentLastPedidoId = 0;
    }

    private void GetOrders()
    {
      ClearObjects();
      btnSiguiente.Enabled = false;

      string stringSQL = "p.Pedido_id, " +
                         "p.Mesa_id,"+
                         "p.Fecha_Pedido, " +
                         "p.Turno_id, " +
                         "p.Orden_turno, " +
                         "up.Apellidos_empleado+', '+up.Nombres_empleado AS Mozo, " +
                         "p.Tipo_venta" +                         
                         " FROM ((pedido AS p LEFT JOIN empleado AS up ON p.Atendido_por = up.codigo_empleado) " +
                         " LEFT JOIN cliente AS c ON p.Cliente_id = c.Cliente_id) ";

      DataSet dsSearch = new DataSet();
      if (currentLastPedidoId == 0)
        dsSearch = DataUtil.FillDataSet("SELECT TOP 6 " + stringSQL + " WHERE p.Estado = 'A' ORDER BY p.Fecha_Pedido", "pedido");
      else
        dsSearch = DataUtil.FillDataSet("SELECT TOP 6 " + stringSQL + " WHERE p.Estado = 'A' AND p.Pedido_id > " + currentLastPedidoId + " ORDER BY p.Fecha_Pedido", "pedido");

      lastPedidoId = 0;
      if (dsSearch.Tables[0].Rows.Count > 0)
      {
        int count = 0;
        foreach (DataRow row in dsSearch.Tables[0].Rows)
        {
          count++;
          DateTime fechaPedido = DataUtil.GetDateTime(row["Fecha_Pedido"]);
          DateTime fechaActual = DateTime.Now;

          string pedidoId = DataUtil.GetString(row["Pedido_id"]);
          string order = "Order #: " + DataUtil.GetString(row["Pedido_id"]) + " - Mesa #: " + DataUtil.GetString(row["Mesa_id"]) + " - " + DataUtil.GetString(row["Tipo_venta"]);
          string mozo = "Mozo :" + DataUtil.GetString(row["Mozo"]);
          string tiempo = "Tiempo Transcurrido: " + Math.Truncate(fechaActual.Subtract(fechaPedido).TotalMinutes);

          switch (count)
          {
            case 1:              
              txtOrder1.Text = order;
              txtMesero1.Text = mozo;
              txtTiempo1.Text = tiempo;
              lblOrder1.Text = pedidoId;
              GetOrderById(pedidoId, lb1);
              break;
            case 2:              
              txtOrder2.Text = order;
              txtMesero2.Text = mozo;
              txtTiempo2.Text = tiempo;
              lblOrder2.Text = pedidoId;
              GetOrderById(pedidoId, lb2);
              break;
            case 3:              
              txtOrder3.Text = order;
              txtMesero3.Text = mozo;
              txtTiempo3.Text = tiempo;
              lblOrder3.Text = pedidoId;
              GetOrderById(pedidoId, lb3);
              break;
            case 4:              
              txtOrder4.Text = order;
              txtMesero4.Text = mozo;
              txtTiempo4.Text = tiempo;
              lblOrder4.Text = pedidoId;
              GetOrderById(pedidoId, lb4);
              break;
            case 5:              
              txtOrder5.Text = order;
              txtMesero5.Text = mozo;
              txtTiempo5.Text = tiempo;
              lblOrder5.Text = pedidoId;
              GetOrderById(pedidoId, lb5);
              break;
            case 6:              
              txtOrder6.Text = order;
              txtMesero6.Text = mozo;
              txtTiempo6.Text = tiempo;
              lblOrder6.Text = pedidoId;
              GetOrderById(pedidoId, lb6);
              lastPedidoId = DataUtil.GetInt(pedidoId);
              btnSiguiente.Enabled = true;
              break;
          }          
        }
      }
      else
        currentLastPedidoId = 0;
    }
    private void GetOrderById(string pedidoId, ListBox lbObject)
    {
      DataSet dsPedidoDetalleInfo = DataUtil.FillDataSet(DataBaseQuerys.PedidoCocina(DataUtil.GetInt(pedidoId)), "pedido_detalle");
      foreach (DataRow pedidoDetalleRow in dsPedidoDetalleInfo.Tables["pedido_detalle"].Rows)
      {
        lbObject.Items.Add(DataUtil.GetString(pedidoDetalleRow["Pedido_cantidad"]) + " " +
                           DataUtil.GetString(pedidoDetalleRow["Descripcion_Producto"]));
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      setClock();
      GetOrders();
    }
    private void setClock()
    {
      txtDigiClock.Text = "" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
    }
    private void ClearObjects()
    {
      lb1.Items.Clear();
      lb2.Items.Clear();
      lb3.Items.Clear();
      lb4.Items.Clear();
      lb5.Items.Clear();
      lb6.Items.Clear();
      txtOrder6.Text = txtOrder5.Text = txtOrder4.Text = txtOrder3.Text = txtOrder2.Text = txtOrder1.Text = string.Empty;
      txtMesero6.Text = txtMesero5.Text = txtMesero4.Text = txtMesero3.Text = txtMesero2.Text = txtMesero1.Text = string.Empty;
      txtTiempo6.Text = txtTiempo5.Text = txtTiempo4.Text = txtTiempo3.Text = txtTiempo2.Text = txtTiempo1.Text = string.Empty;
      lblOrder6.Text = lblOrder5.Text = lblOrder4.Text = lblOrder3.Text = lblOrder2.Text = lblOrder1.Text = string.Empty;      
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      GetOrders();
    }
    private void btnSiguiente_Click(object sender, EventArgs e)
    {
      currentLastPedidoId = lastPedidoId;
      GetOrders();
    }
    private void btnInicio_Click(object sender, EventArgs e)
    {
      currentLastPedidoId = 0;
      GetOrders();
    }
  }
}
