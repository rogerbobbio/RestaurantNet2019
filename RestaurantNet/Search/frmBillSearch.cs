using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace RestaurantNet
{
  public partial class frmBillSearch : frmMain
  {
    public frmBillSearch()
    {
      InitializeComponent();
      IniTurnoCombo();
    }

    private void frmBillSearch_Load(object sender, EventArgs e)
    {
      FillTurnoCombo();
      if (AppConstant.Turno.Codigo != string.Empty)
          radmccbTurno.SelectedIndex = 0;
      btnClean_Click(null, null);
      btnSearch_Click(null, null);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
    private void btnClean_Click(object sender, EventArgs e)
    {
      txtCliente.Text = string.Empty;
      cbAll.Checked = true;
      lblFechaInicio.Visible = false;
      lblFechaFin.Visible = false;
      dtpFechaInicio.Visible = false;
      dtpFechaFin.Visible = false;
      lblCodigoCliente.Text = string.Empty;
      dtpFechaInicio.Value = DateTime.Now;
      dtpFechaFin.Value = DateTime.Now;
      txtDocumento.Text = string.Empty;
      cbTipoDoc.SelectedItem = "TODOS";
      cbTipoPago.SelectedItem = "TODOS";
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
      Facturados();
    }

    #region Eventos
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
    private void txtCliente_Leave(object sender, EventArgs e)
    {
      lblCodigoCliente.Text = string.Empty;

      if (txtCliente.Text != string.Empty)
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

        string stringWhere = string.Empty;

        DataSet dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE c.cliente_apellidos like '%" + txtCliente.Text.Trim().Replace("'", "''") + "%'" + stringWhere + " ORDER BY c.cliente_apellidos", "cliente");
        if (dsSearch.Tables[0].Rows.Count == 1)
        {
          txtCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Cliente");
          lblCodigoCliente.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
        }
        else if (dsSearch.Tables[0].Rows.Count > 1)
        {
          var frmCustomerSearchForm = new frmCustomerSearch();
          frmCustomerSearchForm.ApellidoSearch = txtCliente.Text;
          frmCustomerSearchForm.DsSearchCliente = dsSearch;
          frmCustomerSearchForm.ShowDialog();
          SetCustomerValues();
        }
        else
        {
          MessageBox.Show(@"No existe el cliente.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtCliente.Text = string.Empty;
          lblCodigoCliente.Text = string.Empty;
          txtCliente.Focus();
        }
      }
    }
    private void dgwResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      if ((dgwResult.Rows.Count > 0) && (dgwResult.CurrentRow.Cells[1].Value != null))
      {
        var frmCustomerOrderViewForm = new frmCustomerOrderView();
        frmCustomerOrderViewForm.pedidoID = DataUtil.GetInt(dgwResult.CurrentRow.Cells[1].Value);
        frmCustomerOrderViewForm.ventaIdParam = DataUtil.GetInt(dgwResult.CurrentRow.Cells[0].Value);
        frmCustomerOrderViewForm.ShowDialog();
      }
    }
    #endregion

    #region Metodos privados
    private void SetCustomerValues()
    {
      if (AppConstant.Customer.ClienteNombre != string.Empty)
      {
        txtCliente.Text = AppConstant.Customer.ClienteNombre;
        lblCodigoCliente.Text = AppConstant.Customer.ClienteCodigo;

        AppConstant.Customer.ClienteNombre = string.Empty;
        AppConstant.Customer.ClienteCodigo = string.Empty;
      }
    }
    private void Facturados()
    {
      var searchWhere = BuildWhere();

      var stringSql = "IIf(v.Enviado_sunat=1,'ENVIADO','NO ENVIADO') AS [Enviado SUANT]," +
                      "V.Venta_id AS [Venta No], "+
                         "V.Pedido_id AS [Pedido No], " +
                         "V.Tipo_venta AS [Tipo Venta],"+
                         "V.Turno_id AS [Turno]," +
                         "V.Orden_turno AS [Order Turno], " +
                         "E.Estacion_descripcion AS [Estacion],"+
                         "V.Fecha_pago AS [Fecha Venta],"+
                         "V.Venta_documento_tipo AS [Tipo Documento], "+
                         "V.Venta_documento AS [No Documento Venta], "+
                         "V.Tipo_pago AS [Tipo Pago], "+
                         "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente,"+
                         "m.Mesa_descripcion AS [Mesa], "+
                         "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Atendido por],"+
                         "V.Fecha_Pedido AS [Fecha Pedido], "+
                         "V.Monto_descuento AS [Descuento], "+
                         "V.Sub_total AS [Sub Total], "+
                         "V.IGV_total AS [IGV], "+
                         "V.Monto_total AS [Total]"+
                         "FROM ((((Venta AS v LEFT JOIN empleado AS up ON v.Atendido_por = up.codigo_empleado) "+
                         " LEFT JOIN cliente AS c ON v.Cliente_id = c.Cliente_id)"+
                         " LEFT JOIN estacion AS e ON v.Estacion_id = e.Estacion_id)"+
                         " LEFT JOIN mesa AS m ON v.Mesa_id = m.Mesa_id)";

      var dsSearch = DataUtil.FillDataSet("SELECT " + stringSql + " WHERE V.Venta_id <> -1 " + searchWhere + "  ORDER BY V.Fecha_pago DESC", "venta");

      dgwResult.DataSource = dsSearch;
      dgwResult.DataMember = "venta";
      lblNo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows.Count);

      stringSql = "SUM(V.Monto_total) AS [Total]" +
                         "FROM (((Venta AS v LEFT JOIN empleado AS up ON v.Atendido_por = up.codigo_empleado) " +
                         " LEFT JOIN cliente AS c ON v.Cliente_id = c.Cliente_id)" +
                         " LEFT JOIN estacion AS e ON v.Estacion_id = e.Estacion_id)";

      dsSearch = DataUtil.FillDataSet("SELECT " + stringSql + " WHERE V.Venta_id <> -1 " + searchWhere + " ", "venta");
      txtTotal.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0]["Total"]);
    }

      private string BuildWhere()
      {
          var searchWhere = string.Empty;

          if (lblCodigoCliente.Text.Trim() != string.Empty)
              searchWhere = searchWhere + " AND v.Cliente_id = " + lblCodigoCliente.Text.Trim() + "";

          if (txtDocumento.Text.Trim() != string.Empty)
              searchWhere = searchWhere + " AND v.[Venta_documento] like '%" + txtDocumento.Text.Trim() + "%'";

          if (DataUtil.GetString(cbTipoDoc.SelectedItem) != "TODOS")
              searchWhere = searchWhere + " AND v.Venta_documento_tipo = '" + cbTipoDoc.SelectedItem + "'";

          if (DataUtil.GetString(cbTipoPago.SelectedItem) != "TODOS")
              searchWhere = searchWhere + " AND v.Tipo_pago = '" + cbTipoPago.SelectedItem + "'";

          if (!cbAll.Checked)
          {
              searchWhere = searchWhere + " AND v.Fecha_Pago >#" +
                            dtpFechaInicio.Value.AddDays(-1).ToShortDateString() + " 23:59#";
              searchWhere = searchWhere + " AND v.Fecha_Pago <#" + dtpFechaFin.Value.AddDays(1).ToShortDateString() +
                            " 00:00#";
          }

          if (radmccbTurno.Text.Trim() != string.Empty)
              searchWhere = searchWhere + " AND v.Turno_id = " +
                            radmccbTurno.EditorControl.Rows[radmccbTurno.SelectedIndex].Cells["Turno_id"].Value + "";
          
          if (cbSunat.Checked)
              searchWhere = searchWhere + " AND v.Enviado_sunat = 1";
          else
              searchWhere = searchWhere + " AND v.Enviado_sunat = 0";

            return searchWhere;
      }

      #endregion

    #region Turno
    private void IniTurnoCombo()
    {
      radmccbTurno.AutoSizeDropDownToBestFit = true;
      RadMultiColumnComboBoxElement multiColumnComboElement = radmccbTurno.MultiColumnComboBoxElement;
      multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
      //multiColumnComboElement.DropDownMinSize = new Size(420, 300);
      multiColumnComboElement.EditorControl.MasterGridViewTemplate.AutoGenerateColumns = false;
      GridViewTextBoxColumn column = new GridViewTextBoxColumn("Turno_id");
      column.HeaderText = @"Turno Code";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_apertura");
      column.HeaderText = @"Fecha Apertura";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_cierre");
      column.HeaderText = @"Fecha Cierre";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Estado");
      column.HeaderText = @"Estado";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Turno_Desc");
      column.HeaderText = @"Turno Descripcion";
      column.IsVisible = false;
      multiColumnComboElement.Columns.Add(column);
    }
    private void FillTurnoCombo()
    {
      var dsResult = DataUtil.FillDataSet("SELECT Turno_id, Fecha_apertura, Fecha_cierre, Estado, LTrim((Str(Turno_id))+ ' - ' +Format(Fecha_apertura , 'Short Date')) AS Turno_Desc FROM turno ORDER BY fecha_apertura DESC", "turno");
      radmccbTurno.DataSource = dsResult.Tables[0];
      radmccbTurno.DisplayMember = "Turno_Desc";
      // Filtering START
      var filter = new FilterExpression(this.radmccbTurno.DisplayMember,
                                                     FilterExpression.BinaryOperation.AND,
                                                     GridKnownFunction.StartsWith,
                                                     GridFilterCellElement.ParameterName);
      filter.Parameters.Add(GridFilterCellElement.ParameterName, string.Empty);
      radmccbTurno.EditorControl.MasterGridViewTemplate.FilterExpressions.Add(filter);
      radmccbTurno.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.None;
      radmccbTurno.DropDownStyle = RadDropDownStyle.DropDown;
      // Filtering END
      radmccbTurno.SelectedItem = null;
    }
        #endregion        

        private void dgwResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dgwResult.Rows[e.RowIndex].Cells[1].Value.ToString() != "ENVIADO")
                {
                    
                }
                else
                    MessageBox.Show(@"Docuemnto ya enviado a SUNAT.", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
