using System;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmSupplier : frmMainTable
  {
    public frmSupplier()
    {
      InitializeComponent();
    }
    private void frmSupplier_Load(object sender, EventArgs e)
    {
      tableName = "proveedor";
      formWhereField = "Proveedor_id";
      OnLoad();
      BindDataFields();

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Proveedores, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Proveedores, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo) ||
                        DataBaseQuerys.GetAccess(AppConstant.MenuItems.Proveedores, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);
    }

    protected override void DeleteData()
    {
      idToDelete = txtCodigo.Text;
      base.DeleteData();
    }
    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        string sqlForExecute = string.Empty;
        try
        {
          if (adding)
          {
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Proveedor_nombre," +
                               "Proveedor_ruc," +
                               "Proveedor_Telefono," +
                               "Proveedor_Fax," +
                               "Proveedor_web," +
                               "Proveedor_email," +
                               "Proveedor_comentarios," +
                               "Proveedor_contacto," +
                               "Estado," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               DataUtil.GetNewId(tableName) + "," +
                               "'" + txtNombre.Text.Trim() + "'," +
                               "'" + txtDocumento.Text.Trim() + "'," +
                               "'" + txtTelefono.Text.Trim() + "'," +
                               "'" + txtFax.Text.Trim() + "'," +
                               "'" + txtWeb.Text.Trim() + "'," +
                               "'" + txtEmail.Text.Trim() + "'," +
                               "'" + txtComentarios.Text.Trim() + "'," +
                               "'" + txtContacto.Text.Trim() + "'," +
                               "'" + cbEstado.SelectedItem + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                         ")";
          }
          else
          {
            sqlForExecute = "UPDATE " + tableName + " SET " +
                        "Proveedor_nombre = '" + txtNombre.Text.Trim() + "'" +
                        ", Proveedor_ruc = '" + txtDocumento.Text.Trim() + "'" +
                        ", Proveedor_Telefono = '" + txtTelefono.Text.Trim() + "'" +
                        ", Proveedor_Fax = '" + txtFax.Text.Trim() + "'" +
                        ", Proveedor_web = '" + txtWeb.Text.Trim() + "'" +
                        ", Proveedor_email = '" + txtEmail.Text.Trim() + "'" +
                        ", Proveedor_comentarios = '" + txtComentarios.Text.Trim() + "'" +
                        ", Proveedor_contacto = '" + txtContacto.Text.Trim() + "'" +
                        ", Estado = '" + cbEstado.SelectedItem + "'" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE " + formWhereField + " = " + txtCodigo.Text;
          }

          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show(@"Registro grabado correctamente", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (adding)
              this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(@"Error en Grabar: " + ex.Message);
        }
      }
    }
    private void BindDataFields()
    {
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtWeb.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_web");
        txtNombre.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_nombre");
        txtEmail.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_email");
        txtTelefono.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_Telefono");
        txtFax.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_Fax");
        txtContacto.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_contacto");
        txtDocumento.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_ruc");
        txtComentarios.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_comentarios");
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");

        txtDocumento.Enabled = false;
      }
      else
      {
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
      }
    }
    private bool IsReadyToSave()
    {
      bool valueResult = true;
      if (txtDocumento.Text == string.Empty)
      {
        epRUC.SetError(txtDocumento, "Por favor ingresar su RUC.");
        valueResult = false;
      }
      else
        epRUC.SetError(txtDocumento, string.Empty);

      if (txtNombre.Text == string.Empty)
      {
        epRazonSocial.SetError(txtNombre, "Por favor ingresar la Razon Social.");
        valueResult = false;
      }
      else
        epRazonSocial.SetError(txtNombre, string.Empty);

      if (txtTelefono.Text == string.Empty)
      {
        epTelefono.SetError(txtTelefono, "Por favor ingresar la Telefono.");
        valueResult = false;
      }
      else
        epTelefono.SetError(txtTelefono, string.Empty);

      if (txtContacto.Text == string.Empty)
      {
        epVendedor.SetError(txtContacto, "Por favor ingresar Vendedor.");
        valueResult = false;
      }
      else
        epVendedor.SetError(txtContacto, string.Empty);

      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (txtDocumento.Text != string.Empty)
      {
        string sWhere = "Proveedor_ruc = '" + txtDocumento.Text + "'";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show(@"El documento ya existe.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }

      if (txtNombre.Text != string.Empty)
      {
        string sWhere = "Proveedor_nombre = '" + txtNombre.Text + "'";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show(@"La Razon Social ya existe.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
      return true;
    }
    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("producto", "Count(*)", "Proveedor_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show(@"No se puede borrar el proveedor, tiene " + recordCount + @" productos asociados.", @"Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      else
        return true;
    }
  }
}
