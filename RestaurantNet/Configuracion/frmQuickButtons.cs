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
  public partial class frmQuickButtons : frmMain
  {
    public bool adding = true;
    private string tableName = "producto_boton";
    private string formWhereField = "Boton_id";
    public string categoriaId = string.Empty;
    public string subCategoriaId = string.Empty;
    public string botonId = string.Empty;
    public string tipo = string.Empty;

    public frmQuickButtons()
    {
      InitializeComponent();
    }
    private void frmQuickButtons_Load(object sender, EventArgs e)
    {
      lblBoton.Text = botonId;
      lblTipo.Text = tipo;
      string sWhere = "producto_categoria_id = " + categoriaId + "";
      lblCategoria.Text = DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_descripcion", sWhere);
      sWhere = "producto_sub_categoria_id = " + subCategoriaId + "";
      lblSubCategoria.Text = DataUtil.FindSingleRow("producto_sub_categoria", "Producto_sub_categoria_descripcion", sWhere);

      if (adding)
      {
        btnSaveEdit.Enabled = false;
        btnDisassociate.Visible = false;
      }
      else
      {
        DataSet mainDataSet = DataUtil.FillDataSet("SELECT * FROM " + tableName + " WHERE " + formWhereField + " = " + botonId + " AND producto_sub_categoria_id = " + subCategoriaId + "", tableName);
        txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Boton_descripcion");
        txtRuta.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Boton_ruta_imagen");
        sWhere = "Producto_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Producto_id") + "";
        txtProducto.Text = DataUtil.FindSingleRow("Producto", "Producto_descripcion", sWhere);

        txtProducto.ReadOnly = true;
        btnSaveEdit.Enabled = true;
        btnDisassociate.Visible = true;
        btnAssociate.Visible = false;
      }
    }
    private void txtProducto_Leave(object sender, EventArgs e)
    {
        if (txtCodigo.Text == string.Empty)
        {
            DataSet dsSearch = null;
            if (!txtProducto.ReadOnly)
            {
                txtCodigo.Text = string.Empty;

                if (txtProducto.Text != string.Empty)
                {
                    string stringSQL = DataBaseQuerys.ProductoSearch();

                    if (txtProducto.Text.Trim() != "*")
                        dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Producto_tipo = '" + tipo + "' AND p.Producto_categoria_id = " + categoriaId + " AND p.Producto_sub_categoria_id = " + subCategoriaId + " AND p.Estado = '" + AppConstant.RegistroEstado.Activo + "' AND  p.Producto_descripcion like '%" + txtProducto.Text.Trim().Replace("'", "''") + "%' ORDER BY p.Producto_descripcion", "producto");
                    else
                        dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Producto_tipo = '" + tipo + "' AND p.Producto_categoria_id = " + categoriaId + " AND p.Producto_sub_categoria_id = " + subCategoriaId + " AND p.Estado = '" + AppConstant.RegistroEstado.Activo + "' ORDER BY p.Producto_descripcion", "producto");

                    if (dsSearch.Tables[0].Rows.Count == 1)
                    {
                        txtProducto.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Producto");
                        txtDescripcion.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Descripcion Corta");
                        txtCodigo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
                    }
                    else if (dsSearch.Tables[0].Rows.Count > 1)
                    {
                        frmProductSearch frmProductSearchForm = new frmProductSearch();
                        frmProductSearchForm.descriptionSearch = txtProducto.Text;
                        frmProductSearchForm.dsSearchProd = dsSearch;
                        frmProductSearchForm.tipoSearch = tipo;
                        frmProductSearchForm.categoriaIdSearch = categoriaId;
                        frmProductSearchForm.subCategoriaIdSearch = subCategoriaId;
                        frmProductSearchForm.ShowDialog();
                        SetProductValues();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("No existe el producto. Desea crear uno nuevo?", "Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            frmProduct frmProductAdd = new frmProduct();
                            frmProductAdd.adding = true;
                            frmProductAdd.createSpecial = true;
                            frmProductAdd.productoNombre = txtProducto.Text.Trim();
                            frmProductAdd.formTitle = "Producto - Agregar";
                            frmProductAdd.tipo_quickButton = tipo;
                            frmProductAdd.categoria_quickButton = categoriaId;
                            frmProductAdd.subcategoria_quickButton = subCategoriaId;
                            frmProductAdd.ShowDialog();
                            SetProductValues();
                        }
                        else
                            txtProducto.Focus();
                    }
                }
            }
        }
        else
        {
        }
    }

    private void SetProductValues()
    {
      if (AppConstant.Product.ProductoDescription != string.Empty)
      {
        txtProducto.Text = AppConstant.Product.ProductoDescription;
        txtDescripcion.Text = AppConstant.Product.ProductoDescriptionCorta;
        txtCodigo.Text = AppConstant.Product.ProductoCodigo;

        AppConstant.Product.ProductoDescription = string.Empty;
        AppConstant.Product.ProductoDescriptionCorta = string.Empty;
        AppConstant.Product.ProductoCodigo = string.Empty;
        //txtProducto.Focus();
        txtProducto.Enabled = false;
        txtDescripcion.Enabled = false;
      }
    }
    private bool IsReadyToAssociate()
    {
      epProducto.SetError(txtProducto, string.Empty);
      epDescripcion.SetError(txtDescripcion, string.Empty);
      epProducto.SetError(txtProducto, string.Empty);
      bool valueResult = true;

      if (txtProducto.Text == string.Empty)
      {
        epProducto.SetError(txtProducto, "Por favor ingresar el producto.");
        valueResult = false;
      }
      
      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar la descripcion.");
        valueResult = false;
      }
      
      if (txtProducto.Text != string.Empty)
      {
        if (txtCodigo.Text == string.Empty)
        {
          epProducto.SetError(txtProducto, "Por favor ingresar un producto correcto.");
          valueResult = false;
        }          
      }
      
      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      return valueResult;
    }
    private bool IsReadyToEdit()
    {
      bool valueResult = true;

      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar la descripcion.");
        valueResult = false;
      }
      else
        epDescripcion.SetError(txtDescripcion, string.Empty);

      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (txtDescripcion.Text != string.Empty)
      {
        string sWhere = "Boton_descripcion = '" + txtDescripcion.Text.Replace("'", "''") + "' AND Producto_sub_categoria_id = " + subCategoriaId + "";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show("El boton ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtProducto.Focus();
          return false;
        }
      }
      if (txtCodigo.Text != string.Empty)
      {
        string sWhere = "producto_id = " + txtCodigo.Text + "";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show("El producto ya fue asignado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtProducto.Focus();
          return false;
        }
      }
      return true;
    }

    #region Buttons
    private void btnDisassociate_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Está seguro de desasociar el boton actual?", "Desasociar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (result == DialogResult.Yes)
      {
        if (DataUtil.Update("DELETE FROM " + tableName + " WHERE " + formWhereField + " = " + botonId))
        {
          MessageBox.Show(string.Format("Se desasocio el boton correctamente.", 1), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.Close();
        }
      }
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
      DialogResult result = this.openFileDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        txtRuta.Text = openFileDialog1.FileName;
      }
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnAssociate_Click(object sender, EventArgs e)
    {
      if (IsReadyToAssociate())
      {
        string sqlForExecute = string.Empty;
        try
        {
          if (adding)
          {
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Producto_sub_categoria_id,"+
                               "Producto_id," +
                               "Boton_descripcion," +
                               "Boton_ruta_imagen," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               botonId + "," +
                               subCategoriaId + "," +
                               txtCodigo.Text + "," +
                               "'" + txtDescripcion.Text.Trim().Replace("'", "''") + "'," +
                               "'" + txtRuta.Text + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                         ")";
          }

          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Grabar: " + ex.Message);
        }
      }
    }
    private void btnSaveEdit_Click(object sender, EventArgs e)
    {
      if (IsReadyToEdit())
      {
        string sqlForExecute = string.Empty;
        try
        {
          sqlForExecute = "UPDATE " + tableName + " SET " +
                        "Boton_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + "'" +
                        ", Boton_ruta_imagen = '" + txtRuta.Text + "'" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE " + formWhereField + " = " + botonId;

          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Grabar: " + ex.Message);
        }
      }
    }
    private void btnClean_Click(object sender, EventArgs e)
    {
      txtRuta.Text = string.Empty;
    }
    #endregion
  }
}
