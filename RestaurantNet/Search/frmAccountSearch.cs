using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace RestaurantNet
{
  public partial class frmAccountSearch : frmMain
  {
    public string titleForm = string.Empty;
    public string pedidoEstado = string.Empty;
    public string pedidoOrigen = string.Empty;

    private DataSet dsSearch = null;

    public frmAccountSearch()
    {
      InitializeComponent();
      IniTurnoCombo();
    }
    private void frmAccountSearch_Load(object sender, EventArgs e)
    {
      this.Text = titleForm;
      cbAll.Checked = true;
      lblFechaInicio.Visible = false;
      lblFechaFin.Visible = false;
      dtpFechaInicio.Visible = false;
      dtpFechaFin.Visible = false;
      
      if (pedidoOrigen != string.Empty)
      {
        txtCuentaPadre.Text = pedidoOrigen;
        txtCuentaPadre.ReadOnly = true;
      }

      GetOrders();
      FillTurnoCombo();
      if (pedidoEstado.Equals(AppConstant.PedidoEstado.Anulado))
      {
        lblFechaInicio.Text = @"Fecha de Anulacion (Inicio):";
        lblFechaFin.Text = @"Fecha de Anulacion (Fin):";
      }
      if (pedidoEstado.Equals(AppConstant.PedidoEstado.NotaVenta))
      {
        lblFechaInicio.Text = @"Fecha de Nota de Venta (Inicio):";
        lblFechaFin.Text = @"Fecha de Nota de Venta (Fin):";
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
    private void btnClean_Click(object sender, EventArgs e)
    {
      radmccbTurno.Text = string.Empty;
      txtCuenta.Text = string.Empty;
      cbAll.Checked = true;
      lblFechaInicio.Visible = false;
      lblFechaFin.Visible = false;
      dtpFechaInicio.Visible = false;
      dtpFechaFin.Visible = false;
      dtpFechaInicio.Value = DateTime.Now;
      dtpFechaFin.Value = DateTime.Now;
      btnSearch_Click(null, null);
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
      GetOrders();
    }

    private void Anulados()
    {
      var searchWhere = BuildWhere();

      const string stringSql = "p.Pedido_id AS [Numero de Orden], " +
                               "p.Fecha_Pedido AS [Fecha de Orden], " +
                               "m.Mesa_descripcion AS [Mesa], " +
                               "p.Turno_id AS [Codigo de Turno], " +
                               "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Orden Atendida por], " +
                               "p.Fecha_anulacion AS [Fecha de Anulacion], " +
                               "u.Apellidos_empleado+', '+u.Nombres_empleado AS [Anulado por], " +
                               "Round((SUM (pr.Precio_final * pd.Cantidad)),2) AS [Monto No Facturado Anulado], " +
                               "p.Tipo_venta AS [Tipo Venta]," +
                               "p.Comentarios AS [Motivos de Anulacion]"+
                               " FROM ((((((pedido AS p " +
                               " LEFT JOIN Pedido_Detalle pd ON p.Pedido_id = pd.Pedido_id) " +
                               " LEFT JOIN Producto pr ON pd.Codigo_Producto = pr.Producto_id) " +
                               " LEFT JOIN empleado AS up ON p.Atendido_por = up.codigo_empleado) " +
                               " LEFT JOIN empleado AS u ON p.Actualizado_por = u.codigo_empleado) "+
                               " LEFT JOIN cliente AS c ON p.Cliente_id = c.Cliente_id) " +
                               " LEFT JOIN mesa AS m ON m.Mesa_id = p.Mesa_id)";

      var sqlGroup = " GROUP BY p.Pedido_id, Fecha_Pedido, m.Mesa_descripcion, p.Turno_id, up.Apellidos_empleado, up.Nombres_empleado, p.Fecha_anulacion, u.Apellidos_empleado, u.Nombres_empleado, p.Tipo_venta, p.Comentarios";

      var sqlText = "SELECT " + stringSql + " WHERE p.Estado = 'C' " + searchWhere + sqlGroup +  "  ORDER BY p.Fecha_Pedido DESC";
      dsSearch = DataUtil.FillDataSet(sqlText, "pedido");
    }
    private void NotaVenta()
    {
      string searchWhere = BuildWhere();

      string stringSQL = "p.Pedido_id AS [Numero de Orden], " +
                         "p.Fecha_Pedido AS [Fecha de Orden], " +
                         "p.Turno_id AS [Codigo de Turno], " +
                         "p.Orden_turno AS [Order Turno], " +                         
                         "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Atendido por], " +
                         "p.Fecha_anulacion AS [Fecha de Nota de Venta], " +
                         "p.Tipo_venta AS [Tipo Venta]," +
                         "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                         "p.Comentarios AS [Motivos de Nota de Venta]," +
                         "p.Fecha_actualizacion AS [Fecha actualizacion]" +
                         " FROM ((pedido AS p LEFT JOIN empleado AS up ON p.Atendido_por = up.codigo_empleado) " +
                         " LEFT JOIN cliente AS c ON p.Cliente_id = c.Cliente_id) ";

      dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Estado = 'N' " + searchWhere + "  ORDER BY p.Fecha_Pedido", "pedido");
    }
    private void OrdenCobrar()
    {
      string searchWhere = BuildWhere();

      string stringSQL = "p.Pedido_id AS [Numero de Orden], " +
                         "p.Fecha_Pedido AS [Fecha de Orden], " +
                         "p.Pedido_origen_id AS [Orden Origen], " +
                         "p.Turno_id AS [Codigo de Turno], " +
                         "p.Orden_turno AS [Order Turno], " +                         
                         "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Atendido por], " +
                         "p.Tipo_venta AS [Tipo Venta]," +
                         "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                         "p.Fecha_actualizacion AS [Fecha actualizacion]" +
                         " FROM ((pedido AS p LEFT JOIN empleado AS up ON p.Atendido_por = up.codigo_empleado) " +
                         " LEFT JOIN cliente AS c ON p.Cliente_id = c.Cliente_id) ";

      dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Estado = 'A' " + searchWhere + "  ORDER BY p.Fecha_Pedido", "pedido");
    }

    private void GetOrders()
    {
      if (pedidoEstado.Equals(AppConstant.PedidoEstado.Anulado))
        Anulados();
      if (pedidoEstado.Equals(AppConstant.PedidoEstado.NotaVenta))
        NotaVenta();
      if (pedidoEstado.Equals(AppConstant.PedidoEstado.Atendiendo))
        OrdenCobrar();

      if (dsSearch != null)
      {
        dgwResult.DataSource = dsSearch;
        dgwResult.DataMember = "pedido";
        lblNo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows.Count);
      }
      else
        lblNo.Text = "0";
    }
    private string BuildWhere()
    {
      string campoFecha = string.Empty;
      string searchWhere = string.Empty;
      if (txtCuenta.Text.Trim() != string.Empty)
        searchWhere = " AND p.pedido_id = " + DataUtil.GetInt(txtCuenta.Text.Trim()) + "";
      if (txtCuentaPadre.Text.Trim() != string.Empty)
        searchWhere = " AND p.Pedido_origen_id = " + DataUtil.GetInt(txtCuentaPadre.Text.Trim()) + "";
      if (!cbAll.Checked)
      {
        if (pedidoEstado.Equals(AppConstant.PedidoEstado.Atendiendo))
          campoFecha = "p.Fecha_Pedido";
        else
          campoFecha = "p.Fecha_anulacion";

        searchWhere = searchWhere + " AND " + campoFecha + " >#" + dtpFechaInicio.Value.AddDays(-1).ToShortDateString() + " 23:59#";
        searchWhere = searchWhere + " AND " + campoFecha + " <#" + dtpFechaFin.Value.AddDays(1).ToShortDateString() + " 00:00#";
      }
      if (radmccbTurno.Text != string.Empty)
        searchWhere = searchWhere + " AND p.Turno_id = " + radmccbTurno.EditorControl.Rows[radmccbTurno.SelectedIndex].Cells["Turno_id"].Value + "";
      return searchWhere;
    }
    private bool IsReadyPaid()
    {
      if (AppConstant.Order.PedidoID != string.Empty)
      {
        Close();
        return true;
      }
      return false;
    }
    
    private void cbAll_Click(object sender, EventArgs e)
    {
      if (cbAll.Checked)
      {
        lblFechaInicio.Visible = false;
        lblFechaFin.Visible = false;
        dtpFechaInicio.Visible = false;
        dtpFechaFin.Visible = false;
      }
      else
      {
        lblFechaInicio.Visible = true;
        lblFechaFin.Visible = true;
        dtpFechaInicio.Visible = true;
        dtpFechaFin.Visible = true;
      }
    }
    private void dgwResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      if ((dgwResult.Rows.Count > 0) && (dgwResult.CurrentRow.Cells[1].Value != null))
      {
        if (pedidoOrigen != string.Empty)
        {
          var frmCustomerOrderViewForm = new frmCustomerOrderView();
          frmCustomerOrderViewForm.pedidoID = DataUtil.GetInt(dgwResult.CurrentRow.Cells[0].Value);
          frmCustomerOrderViewForm.pedidoOrigenView = pedidoOrigen;
          frmCustomerOrderViewForm.ShowDialog();
        }
        else
        {
          if (pedidoEstado.Equals(AppConstant.PedidoEstado.Atendiendo))
          {
            var frmCustomerOrderForm = new frmCustomerOrder();
            frmCustomerOrderForm.pedidoID = DataUtil.GetInt(dgwResult.CurrentRow.Cells[0].Value);
            frmCustomerOrderForm.ShowDialog();
            if (!IsReadyPaid())
              GetOrders();
          }
          else
          {
            var frmCustomerOrderViewForm = new frmCustomerOrderView();
            frmCustomerOrderViewForm.pedidoID = DataUtil.GetInt(dgwResult.CurrentRow.Cells[0].Value);
            frmCustomerOrderViewForm.ShowDialog();
          }
        }
      }
    }

    #region Turno
    private void IniTurnoCombo()
    {
      this.radmccbTurno.AutoSizeDropDownToBestFit = true;
      RadMultiColumnComboBoxElement multiColumnComboElement = this.radmccbTurno.MultiColumnComboBoxElement;
      multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
      multiColumnComboElement.EditorControl.MasterGridViewTemplate.AutoGenerateColumns = false;
      GridViewTextBoxColumn column = new GridViewTextBoxColumn("Turno_id");
      column.HeaderText = "Turno Code";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_apertura");
      column.HeaderText = "Fecha Apertura";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_cierre");
      column.HeaderText = "Fecha Cierre";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Estado");
      column.HeaderText = "Estado";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Turno_Desc");
      column.HeaderText = "Turno Descripcion";
      column.IsVisible = false;
      multiColumnComboElement.Columns.Add(column);
    }
    private void FillTurnoCombo()
    {
      DataSet dsResult = DataUtil.FillDataSet("SELECT Turno_id, Fecha_apertura, Fecha_cierre, Estado, LTrim((Str(Turno_id))+ ' - ' +Format(Fecha_apertura , 'Short Date')) AS Turno_Desc FROM turno ORDER BY fecha_apertura DESC", "turno");
      this.radmccbTurno.DataSource = dsResult.Tables[0];
      this.radmccbTurno.DisplayMember = "Turno_Desc";
      // Filtering START
      FilterExpression filter = new FilterExpression(this.radmccbTurno.DisplayMember,
                                                     FilterExpression.BinaryOperation.AND,
                                                     GridKnownFunction.StartsWith,
                                                     GridFilterCellElement.ParameterName);
      filter.Parameters.Add(GridFilterCellElement.ParameterName, string.Empty);
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.FilterExpressions.Add(filter);
      this.radmccbTurno.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.None;
      this.radmccbTurno.DropDownStyle = RadDropDownStyle.DropDown;
      // Filtering END
      this.radmccbTurno.SelectedItem = null;
    }
    #endregion
  }
}
