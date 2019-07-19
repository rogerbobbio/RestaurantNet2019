using System;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmProductCategory : frmMainTable
  {
    public frmProductCategory()
    {
      InitializeComponent();
    }

    private void frmProductCategory_Load(object sender, EventArgs e)
    {
      tableName = "producto_categoria";
      formWhereField = "Producto_categoria_id";
      OnLoad();
      BindDataFields();

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo) ||
                        DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);
    }

    private bool IsReadyToSave()
    {
      bool valueResult = true;
      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar Descripcion.");
        valueResult = false;
      }
      else
        epDescripcion.SetError(txtDescripcion, string.Empty);

     
      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (txtDescripcion.Text != string.Empty)
      {
        string sWhere = "Producto_categoria_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + "'";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show("La categoria '" + txtDescripcion.Text.Trim() + "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
      return true;
    }
    private void BindDataFields()
    {
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Producto_categoria_descripcion");
        txtDescripcion.Enabled = false;
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");
        lblCategoria.Text = "NO";
        if (DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Producto_sistema").Equals("1"))
        {
          lblCategoria.Text = "SI";
          cbEstado.Enabled = false;
        }
      }
      else
      {
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
        lblCategoria.Text = "NO";
      }
    }
    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("producto", "Count(*)", "Producto_categoria_id = " + txtCodigo.Text + ""));
      recordCount = recordCount + DataUtil.GetInt(DataUtil.FindSingleRow("producto_sub_categoria", "Count(*)", "Producto_categoria_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show("No se puede borrar la categoria, tiene productos y sub productos asociados.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      else
        return true;
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
                               "Producto_categoria_descripcion," +
                               "Producto_sistema," +
                               "Estado," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               DataUtil.GetNewId(tableName) + "," +
                               "'" + txtDescripcion.Text.Trim() + "'," +
                               "0," +
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
                        "Producto_categoria_descripcion = '" + txtDescripcion.Text.Trim() + "'" +
                        ", Estado = '" + cbEstado.SelectedItem + "'" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE " + formWhereField + " = " + txtCodigo.Text;
          }

          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (adding)
              this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Grabar: " + ex.Message);
        }
      }
    }
    protected override void DeleteData()
    {
      if (lblCategoria.Text.Equals("SI"))
        MessageBox.Show("No se pueden borrar categorias del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        DialogResult result = MessageBox.Show("Está seguro de eliminar el registro actual?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
          if (ExistRecord())
          {
            if (DataUtil.Update("DELETE FROM " + tableName + " WHERE " + formWhereField + " = " + txtCodigo.Text))
            {
              MessageBox.Show(string.Format("Se eliminó {0} elemento(s).", 1), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              this.Close();
            }
          }
        }
      }
    }    
  }
}
