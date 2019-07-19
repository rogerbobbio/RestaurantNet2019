using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmDelivery : frmMain
  {
    public frmDelivery()
    {
      InitializeComponent();
    }
    private void frmDelivery_Load(object sender, EventArgs e)
    {
      txtNumeroCliente.Text = string.Empty;
      lblCodigoCliente.Text = string.Empty;
      lblNombreCliente.Text = string.Empty;
      txtDireccion.Text = string.Empty;
      GetOrders();
    }

    #region Botones
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnAddOrder_Click(object sender, EventArgs e)
    {
      if (lblCodigoCliente.Text.Trim() != string.Empty && lblNombreCliente.Text.Trim() != string.Empty)
      {
        var frmCustomerOrderForm = new frmCustomerOrder();
        if (rbDelivery.Checked)
          frmCustomerOrderForm.tipoVenta = AppConstant.TipoVenta.Delivery;
        else
          frmCustomerOrderForm.tipoVenta = "RECOGER";
        frmCustomerOrderForm.clienteID = lblCodigoCliente.Text.Trim();
        frmCustomerOrderForm.ShowDialog();
        GetOrders();
        IsReadyPaid();
        txtNumeroCliente.Text = string.Empty;
        lblCodigoCliente.Text = string.Empty;
        lblNombreCliente.Text = string.Empty;
        txtDireccion.Text = string.Empty;
      }
      else
      {
        txtNumeroCliente.Focus();
        MessageBox.Show(@"Debe ingresar el Cliente y el cliente debe tener telfono fijo.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (lblCodigoCliente.Text.Trim() != string.Empty)
      {
        var frmCustomerEdit = new frmCustomer();
        frmCustomerEdit.adding = false;
        frmCustomerEdit.formTitle = "Cliente - Modificar";
        frmCustomerEdit.formId = lblCodigoCliente.Text;
        frmCustomerEdit.ShowDialog();
        GetCustomerValues();
      }
      else
      {
        txtNumeroCliente.Focus();
        MessageBox.Show(@"Debe ingresar un cliente valido.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    #endregion

    #region Metodos privados
    private void SetCustomerValues()
    {
      if (AppConstant.Customer.ClienteNombre != string.Empty)
      {
        txtNumeroCliente.Text = AppConstant.Customer.ClienteTelefono;
        lblCodigoCliente.Text = AppConstant.Customer.ClienteCodigo;
        lblNombreCliente.Text = AppConstant.Customer.ClienteNombre;
        txtDireccion.Text = AppConstant.Customer.ClienteDireccion;

        AppConstant.Customer.ClienteNombre = string.Empty;
        AppConstant.Customer.ClienteCodigo = string.Empty;
        AppConstant.Customer.ClienteTelefono = string.Empty;
        AppConstant.Customer.ClienteDireccion = string.Empty;
      }
    }
    private bool IsReadyPaid()
    {
      if (AppConstant.Order.PedidoID != string.Empty)
      {
        this.Close();
        return true;
      }
      return false;
    }
    private void GetOrders()
    {
      this.dgwCuenta.Rows.Clear();

      string stringSQL = "SELECT " +
                         "p.Pedido_id AS Codigo, " +
                         "p.Turno_id AS Turno, " +
                         "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                         "c.Telefono_casa, " +
                         "c.Cliente_direccion, " +
                         "p.Tipo_venta," +
                         "DatePart('h',p.fecha_pedido) AS Hora," +
                         "DatePart('n',p.fecha_pedido) AS Minutos"+
                         "  FROM (pedido AS p LEFT JOIN cliente AS c ON p.cliente_id=c.cliente_id)" +
                         " WHERE (p.tipo_venta = 'DELIVERY' OR p.tipo_venta = 'RECOGER')"+
                         "   AND p.Estado = 'A'" +
                         " ORDER BY p.fecha_pedido";

      DataSet dsPedidoInfo = DataUtil.FillDataSet(stringSQL, "pedido");
      foreach (DataRow pedidoRow in dsPedidoInfo.Tables["pedido"].Rows)
      {
        string horaPedido = DataUtil.GetString(pedidoRow["Hora"]) + " : " + DataUtil.GetString(pedidoRow["Minutos"]);

        string[] row = {DataUtil.GetString(pedidoRow["Codigo"]),
                        DataUtil.GetString(pedidoRow["Turno"]),
                        horaPedido,
                        DataUtil.GetString(pedidoRow["Cliente"]),
                        DataUtil.GetString(pedidoRow["Telefono_casa"]),
                        DataUtil.GetString(pedidoRow["Tipo_venta"]),
                        DataUtil.GetString(pedidoRow["Cliente_direccion"]),
                       };
        dgwCuenta.Rows.Add(row);
      }
    }
    private void GetCustomerValues()
    {
      string stringSQL = "c.cliente_id AS Codigo, " +
                           "c.Tipo_documento AS [Tipo documento], " +
                           "c.Documento, " +
                           "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                           "c.Cliente_direccion AS Direccion, " +
                           "c.Telefono_casa AS [Telefono fijo], " +
                           "c.Telefono_celular AS Celular, " +
                           "c.Telefono_trabajo AS [Telefono trabajo], " +
                           "c.Email_principal AS [Email Principal]," +
                           "c.Comentario, " +
                           "c.Fecha_creacion AS [Fecha creacion], " +
                           "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                           "c.Fecha_actualizacion AS [Fecha actualizacion]," +
                           "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]" +
                           "  FROM (cliente AS c LEFT JOIN empleado AS cr ON c.creado_por=cr.codigo_empleado)" +
                           "  LEFT JOIN empleado AS up ON c.actualizado_por=up.codigo_empleado";

      DataSet dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE c.cliente_id = " + lblCodigoCliente.Text.Trim() + " ORDER BY c.cliente_apellidos", "cliente");
      if (dsSearch.Tables[0].Rows.Count == 1)
      {
        txtNumeroCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Cliente");
        lblCodigoCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
        lblNombreCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Telefono fijo");
        txtDireccion.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Direccion");
      }
    }
    #endregion

    #region Eventos
    private void dgwCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      if (dgwCuenta.CurrentRow != null && ((dgwCuenta.Rows.Count > 0) && (dgwCuenta.CurrentRow.Cells[1].Value != null)))
      {
        var frmCustomerOrderForm = new frmCustomerOrder();
        frmCustomerOrderForm.pedidoID = DataUtil.GetInt(dgwCuenta.CurrentRow.Cells[0].Value);
        frmCustomerOrderForm.ShowDialog();
        if (!IsReadyPaid())
          GetOrders();
      }
    }
    private void txtCliente_Leave(object sender, EventArgs e)
    {
      lblCodigoCliente.Text = string.Empty;
      lblNombreCliente.Text = string.Empty;
      txtDireccion.Text = string.Empty;

      if (txtNumeroCliente.Text != string.Empty)
      {
        string stringSQL = "c.cliente_id AS Codigo, " +
                           "c.Tipo_documento AS [Tipo documento], " +
                           "c.Documento, " +
                           "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                           "c.Cliente_direccion AS Direccion, " +
                           "c.Telefono_casa AS [Telefono fijo], " +
                           "c.Telefono_celular AS Celular, " +
                           "c.Telefono_trabajo AS [Telefono trabajo], " +
                           "c.Email_principal AS [Email Principal]," +
                           "c.Comentario, " +
                           "c.Fecha_creacion AS [Fecha creacion], " +
                           "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                           "c.Fecha_actualizacion AS [Fecha actualizacion]," +
                           "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]" +
                           "  FROM (cliente AS c LEFT JOIN empleado AS cr ON c.creado_por=cr.codigo_empleado)" +
                           "  LEFT JOIN empleado AS up ON c.actualizado_por=up.codigo_empleado";

        DataSet dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE c.Telefono_casa like '%" + txtNumeroCliente.Text.Trim() + "%' ORDER BY c.cliente_apellidos", "cliente");
        if (dsSearch.Tables[0].Rows.Count == 1)
        {
          txtNumeroCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Telefono fijo");
          lblCodigoCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
          lblNombreCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Cliente");
          txtDireccion.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Direccion");
        }
        else if (dsSearch.Tables[0].Rows.Count > 1)
        {
          var frmCustomerSearchForm = new frmCustomerSearch();
          frmCustomerSearchForm.NumberoTelefonoSearch = txtNumeroCliente.Text;
          frmCustomerSearchForm.DsSearchCliente = dsSearch;
          frmCustomerSearchForm.ShowDialog();
          SetCustomerValues();
        }
        else
        {
          DialogResult result = MessageBox.Show(@"No existe el cliente. Desea crear el cliente?", @"Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            var frmCustomerAdd = new frmCustomer();
            frmCustomerAdd.adding = true;
            frmCustomerAdd.CreateSpecial = true;
            frmCustomerAdd.ClienteNumeroTelefono = txtNumeroCliente.Text.Trim();
            frmCustomerAdd.formTitle = "Cliente - Agregar";
            frmCustomerAdd.ShowDialog();
            SetCustomerValues();
          }
          else
          {
            txtNumeroCliente.Text = string.Empty;
            txtNumeroCliente.Focus();
          }            
        }
      }
    }    
    private void txtCliente_DoubleClick(object sender, EventArgs e)
    {
      AppConstant.Calculator.textIN = string.Empty;
      var frmKeyboardForm = new frmKeyboard();
      frmKeyboardForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        txtNumeroCliente.Text = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
    }
    #endregion

    private void btnSearchProduct_Click(object sender, EventArgs e)
    {
      var frmCustomerSearchForm = new frmCustomerSearch();
      frmCustomerSearchForm.ShowDialog();
      SetCustomerValues();
    }
  }
}
