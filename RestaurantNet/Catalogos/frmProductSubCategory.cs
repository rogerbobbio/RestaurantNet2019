using System;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmProductSubCategory : frmMainTable
  {    
    public frmProductSubCategory()
    {
      InitializeComponent();
    }

    private void frmProductSubCategory_Load(object sender, EventArgs e)
    {
      tableName = "producto_sub_categoria";
      formWhereField = "Producto_sub_categoria_id";
      OnLoad();
      BindDataFields();

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosSubCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosSubCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo) ||
                        DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosSubCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);
    }

    private bool IsReadyToSave()
    {
      bool valueResult = IsReadyToSaveFirst();
      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      return valueResult;
    }
    private bool IsReadyToSaveFirst()
    {
      bool valueResult = true;
      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar Descripcion.");
        valueResult = false;
      }
      else
        epDescripcion.SetError(txtDescripcion, string.Empty);

      if (cbCategoria.SelectedItem == null)
      {
        epCategoria.SetError(cbCategoria, "Por favor ingresar la categoria.");
        valueResult = false;
      }
      else
        epCategoria.SetError(cbCategoria, string.Empty);
      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (IsReadyToSaveFirst())
      {
        string categoriaWhere = "Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";
        string sWhere = "Producto_sub_categoria_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + "' AND Producto_categoria_id = " + DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere) + "";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show("La sub categoria '" + txtDescripcion.Text.Trim() + "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
      return true;
    }
    private void BindDataFields()
    {
      DataUtil.FillComboBox(cbCategoria.Items, DataBaseQuerys.ProductoCategoriaActivos(false), null);
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Producto_sub_categoria_descripcion");
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");

        string sWhere = "producto_categoria_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "producto_categoria_id") + "";
        cbCategoria.SelectedItem = DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_descripcion", sWhere);
      }
      else
      {
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
      }
    }
    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("producto", "Count(*)", "Producto_sub_categoria_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show("No se puede borrar la sub categoria, tiene " + recordCount + " productos asociados.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      else
        return true;
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
          string categoriaWhere = "Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";

          if (adding)
          {
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Producto_sub_categoria_descripcion," +
                               "Producto_categoria_id," +
                               "Estado," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               DataUtil.GetNewId(tableName) + "," +
                               "'" + txtDescripcion.Text.Trim() + "'," +
                               "'" + DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere) + "'," +
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
                        "  Producto_sub_categoria_descripcion = '" + txtDescripcion.Text.Trim() + "'" +
                        ", Producto_categoria_id = '" + DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere) + "'" +
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
    private void btnAddCategoria_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Desea agregar una nueva categoria?", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        frmProductCategory frmProductCategoryAdd = new frmProductCategory();
        frmProductCategoryAdd.adding = true;
        frmProductCategoryAdd.formTitle = "Producto Categoria - Agregar";
        frmProductCategoryAdd.ShowDialog();
        DataUtil.FillComboBox(cbCategoria.Items, DataBaseQuerys.ProductoCategoriaActivos(false), null);
      }
    }
  }
}
