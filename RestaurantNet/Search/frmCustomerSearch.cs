using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmCustomerSearch : frmMain
  {
    public string NumberoTelefonoSearch = string.Empty;
    public string ApellidoSearch = string.Empty;   
    public DataSet DsSearchCliente = null;
    public string ExtraWhere = string.Empty;

    public frmCustomerSearch()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var frmCustomerAdd = new frmCustomer();
      frmCustomerAdd.adding = true;
      frmCustomerAdd.formTitle = "Cliente - Agregar";
      if (ExtraWhere != string.Empty)
        frmCustomerAdd.CustomerRUC = true;
      frmCustomerAdd.ShowDialog();
    }

    private void btnModify_Click(object sender, EventArgs e)
    {
      if (dgwResult.CurrentRow != null && ((dgwResult.Rows.Count > 0) && (dgwResult.CurrentRow.Cells[0].Value != null)))
      {
        // Obtener el ID seleccionado
        string valueId = DataUtil.GetString(dgwResult.CurrentRow.Cells[0].Value);
        var frmCustomerEdit = new frmCustomer();
        frmCustomerEdit.adding = false;
        frmCustomerEdit.formTitle = "Cliente - Modificar";
        frmCustomerEdit.formId = valueId;
        frmCustomerEdit.ShowDialog();
        SearchRecords();
      }
      else
        MessageBox.Show(@"No se seleccionó ningún elemento, o no existen elementos a seleccionar!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    private void SearchRecords()
    {
      string searchWhere = string.Empty;
      if (txtApellido.Text.Trim() != string.Empty)
        searchWhere = searchWhere + " AND c.cliente_apellidos like '%" + txtApellido.Text.Trim().Replace("'", "''") + "%'";
      if (txtNombre.Text.Trim() != string.Empty)
        searchWhere = searchWhere + " AND c.cliente_nombres like '%" + txtNombre.Text.Trim().Replace("'", "''") + "%'";
      if (txtTelefono.Text.Trim() != string.Empty)
        searchWhere = searchWhere + " AND c.Telefono_celular like '%" + txtTelefono.Text.Trim() + "%'";
      if (txtDocumento.Text.Trim() != string.Empty)
        searchWhere = searchWhere + " AND c.Documento like '%" + txtDocumento.Text.Trim() + "%'";
      searchWhere = searchWhere + ExtraWhere;

      const string stringSql = "c.cliente_id AS Codigo, " +
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

      DataSet dsSearch = DataUtil.FillDataSet("SELECT " + stringSql + " WHERE c.cliente_id <> -1 " + searchWhere + "  ORDER BY c.cliente_apellidos", "cliente");

      dgwResult.DataSource = dsSearch;
      dgwResult.DataMember = "cliente";
      lblNo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows.Count);

      if (dsSearch.Tables[0].Rows.Count.Equals(0))
        MessageBox.Show(@"No se encontro ningún registro.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnClean_Click(object sender, EventArgs e)
    {
      txtApellido.Text = string.Empty;
      txtNombre.Text = string.Empty;
      txtTelefono.Text = string.Empty;
      txtDocumento.Text = string.Empty;
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      SearchRecords();
    }

    private void dgwResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      if (dgwResult.CurrentRow != null && ((dgwResult.Rows.Count > 0) && (dgwResult.CurrentRow.Cells[1].Value != null)))
      {
          AppConstant.Customer.ClienteCodigo = DataUtil.GetString(dgwResult.CurrentRow.Cells[0].Value);
          AppConstant.Customer.ClienteTipoDocumento = DataUtil.GetString(dgwResult.CurrentRow.Cells[1].Value);
          AppConstant.Customer.ClienteDocumento = DataUtil.GetString(dgwResult.CurrentRow.Cells[2].Value);
          AppConstant.Customer.ClienteNombre = DataUtil.GetString(dgwResult.CurrentRow.Cells[3].Value);
          AppConstant.Customer.ClienteDireccion = DataUtil.GetString(dgwResult.CurrentRow.Cells[4].Value);
          AppConstant.Customer.ClienteTelefono = DataUtil.GetString(dgwResult.CurrentRow.Cells[5].Value);               
          Close();
      }
    }

    private void frmCustomerSearch_Load(object sender, EventArgs e)
    {
      lblNo.Text = @"0";
      if (DsSearchCliente != null)
      {
        txtTelefono.Text = NumberoTelefonoSearch;
        txtApellido.Text = ApellidoSearch;
        dgwResult.DataSource = DsSearchCliente;
        dgwResult.DataMember = "cliente";
        lblNo.Text = DataUtil.GetString(DsSearchCliente.Tables[0].Rows.Count);
      }
    }
  }
}
