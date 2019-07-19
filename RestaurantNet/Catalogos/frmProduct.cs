using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmProduct : frmMainTable
  {    
    public bool createSpecial = false;
    public string productoNombre = string.Empty;
    public string tipo_quickButton = string.Empty;
    public string categoria_quickButton = string.Empty;
    public string subcategoria_quickButton = string.Empty;
    private string oldEstado = string.Empty;

    public frmProduct()
    {
      InitializeComponent();
    }
    private void frmProduct_Load(object sender, EventArgs e)
    {
      tableName = "producto";
      formWhereField = "producto_id";
      OnLoad();
      BindDataFields();
      lblIGV.Text = @"(Precio con IGV " + AppConstant.GeneralInfo.IGV + @" %)";

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Productos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Productos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo) ||
                        DataBaseQuerys.GetAccess(AppConstant.MenuItems.Productos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);
    }

    #region Metodos Privados
    private void BindDataFields()
    {
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      DataUtil.FillComboBox(cbCategoria.Items, DataBaseQuerys.ProductoCategoriaActivos(false), null);
      DataUtil.FillComboBox(cbProveedor.Items, "SELECT Proveedor_nombre FROM Proveedor WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ORDER BY Proveedor_nombre", null);

      if (mainDataSet.Tables[0].Rows.Count > 0)
        EditProduct();             
      else
        NewProduct();
    }
    private bool IsReadyToSave()
    {
      bool valueResult = true;

      valueResult = IsReadyToSaveFirst();

      if (txtPrecioProveedor.Text == string.Empty)
      {
        epPrecioProveedor.SetError(txtPrecioProveedor, "Por favor ingresar el precio del proveedor.");
        valueResult = false;
      }
      else
        epPrecioProveedor.SetError(txtPrecioProveedor, string.Empty);

      if (txtMargen.Text == string.Empty)
      {
        epMargen.SetError(txtMargen, "Por favor ingresar el Margen (%).");
        valueResult = false;
      }
      else
        epMargen.SetError(txtMargen, string.Empty);


      if (txtPrecioFinal.Text == string.Empty)
      {
        epPrecioFinal.SetError(txtPrecioFinal, "Por favor ingresar el precio final.");
        valueResult = false;
      }
      else
        epPrecioFinal.SetError(txtPrecioFinal, string.Empty);

      if (txtPrecioPublico.Text == string.Empty)
      {
        epPrecioPublico.SetError(txtPrecioPublico, "Por favor ingresar el precio publico.");
        valueResult = false;
      }
      else
        epPrecioPublico.SetError(txtPrecioPublico, string.Empty);


      if (cbStock.Checked)
      {
        if (DataUtil.GetInt(txtStockAlert.Text) > DataUtil.GetInt(txtStock.Text))
        {
          valueResult = false;
          tcProducto.SelectedIndex = 1;
          MessageBox.Show("El stock actual no puede ser menor que el stock de alerta.", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);          
        }
      }

      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      else
      {
        if (CanInactivate())
        {
          MessageBox.Show("No se puede inactivar este registro esta asociado a un boton del menu.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          valueResult = false;
        }
      }
      return valueResult;
    }
    private bool IsReadyToSaveFirst()
    {
      bool valueResult = true;

      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar la descripcion.");
        valueResult = false;
      }
      else
        epDescripcion.SetError(txtDescripcion, string.Empty);

      if (cbTipoProducto.SelectedItem == null)
      {
        epTipo.SetError(cbTipoProducto, "Por favor ingresar el tipo del producto.");
        valueResult = false;
      }
      else
        epTipo.SetError(cbTipoProducto, string.Empty);

      if (cbCategoria.SelectedItem == null)
      {
        epCategoria.SetError(cbCategoria, "Por favor ingresar la categoria del producto.");
        valueResult = false;
      }
      else
        epCategoria.SetError(cbCategoria, string.Empty);

      if (cbSubCategoria.SelectedItem == null)
      {
        epSubCategoria.SetError(cbSubCategoria, "Por favor ingresar la sub categoria del producto.");
        valueResult = false;
      }
      else
        epSubCategoria.SetError(cbSubCategoria, string.Empty);

      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (IsReadyToSaveFirst())
      {
        string categoriaWhere = "Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";
        DataSet dsSearch = DataUtil.FillDataSet(DataBaseQuerys.Producto(string.Empty,
                                                                        cbTipoProducto.SelectedItem.ToString(),
                                                                        DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere),
                                                                        txtDescripcion.Text.Trim().Replace("'", "''")), "producto");
        if (dsSearch.Tables[0].Rows.Count > 0)
        {
          MessageBox.Show("El producto '" + txtDescripcion.Text.Trim() + "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
        return true;
      }
      else
        return false;
    }

    private void CalculoMargen()
    {
      try
      {
        double precioFinal = DataUtil.GetDouble(txtPrecioFinal.Text);
        double precioProoveedor = DataUtil.GetDouble(txtPrecioProveedor.Text);
        if (precioFinal > 0 && precioProoveedor > 0)
        {
          try
          {
            double calculo = ((precioFinal - precioProoveedor) / precioProoveedor) * 100;
            txtMargen.Text = DataUtil.GetDouble(calculo).ToString(DataUtil.Format.Decimals);
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error en Calculo del Margen :" + ex.Message);
          }
        }
        else
          MessageBox.Show("Debe ingresar el precio final y el precio proveedor.");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error en Calculo del Margen :" + ex.Message);
      }
    }
    private void CalculoPrecioFinalEspecial()
    {
      try
      {
        double margen = DataUtil.GetDouble(txtMargen.Text);
        double precioPublico = DataUtil.GetDouble(txtPrecioPublico.Text);
        if (margen > 0 && precioPublico > 0)
        {
          try
          {
            double calculo = (precioPublico / (1 + (DataUtil.GetDouble(AppConstant.GeneralInfo.IGV) / 100)));
            txtPrecioFinal.Text = DataUtil.GetDouble(calculo).ToString(DataUtil.Format.Decimals);
            CalculoPrecioProveedor();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error en Calculo del Precio :" + ex.Message);
          }
        }
        else
          MessageBox.Show("Debe ingresar el margen y el precio proveedor.");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error en Calculo del Precio :" + ex.Message);
      }
    }
    private void CalculoPrecioFinal()
    {
      try
      {
        double margen = DataUtil.GetDouble(txtMargen.Text);
        double precioProoveedor = DataUtil.GetDouble(txtPrecioProveedor.Text);
        if (margen > 0 && precioProoveedor > 0)
        {
          try
          {
            double calculo = (precioProoveedor * (100 + margen)) / 100;
            txtPrecioFinal.Text = DataUtil.GetDouble(calculo).ToString(DataUtil.Format.Decimals);
            CalculoPrecioPublico();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error en Calculo del Precio :" + ex.Message);
          }
        }
        else
          MessageBox.Show("Debe ingresar el margen y el precio proveedor.");
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error en Calculo del Precio :" + ex.Message);
      }
    }
    private void CalculoPrecioPublico()
    {
      try
      {
        double subTotal = DataUtil.GetDouble(txtPrecioFinal.Text);
        double igvValue = (subTotal * (DataUtil.GetDouble(AppConstant.GeneralInfo.IGV) / 100));
        double totalGeneral = (subTotal + igvValue);
        txtPrecioPublico.Text = Math.Round(totalGeneral, 2).ToString(DataUtil.Format.Decimals);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al calcular el Precio Publico: " + ex.Message);
      }
    }
    private void CalculoPrecioProveedor()
    {
      try
      {
        double precioFinal = DataUtil.GetDouble(txtPrecioFinal.Text);
        double margen = DataUtil.GetDouble(txtMargen.Text);

        double calculo = (precioFinal / (1 + (margen / 100)));
        txtPrecioProveedor.Text = calculo.ToString(DataUtil.Format.Decimals);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al calcular el Precio Proveedor: " + ex.Message);
      }
    }

    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("Venta_detalle", "Count(*)", "codigo_producto = " + txtCodigo.Text + ""));
      recordCount = recordCount + DataUtil.GetInt(DataUtil.FindSingleRow("pedido_detalle", "Count(*)", "codigo_producto = " + txtCodigo.Text + ""));
      recordCount = recordCount + DataUtil.GetInt(DataUtil.FindSingleRow("producto_boton", "Count(*)", "producto_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show("No se puede borrar el producto esta asociado a un boton del menu o tiene ordenes asociadas.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      else
        return true;
    }
    private bool CanInactivate()
    {
      bool result = false;
      if (DataUtil.GetString(cbEstado.SelectedItem) == AppConstant.RegistroEstado.Inactivo)
      {
        if (DataUtil.GetString(cbEstado.SelectedItem) != oldEstado)
        {
          int recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("producto_boton", "Count(*)", "producto_id = " + txtCodigo.Text + ""));
          if (recordCount > 0)
            result = true;
        }
      }
      return result;
    }
    private void SetProductValues()
    {
      if (AppConstant.Product.ProductoDescription != string.Empty)
      {
        txtProducto.Text = AppConstant.Product.ProductoDescription;
        txtCodigoProducto.Text = AppConstant.Product.ProductoCodigo;
        txtPrecioUnitario.Text = AppConstant.Product.ProductoPrecio;
        txtProductoPrecioProveedor.Text = AppConstant.Product.ProductoPrecioProveedor;

        AppConstant.Product.ProductoDescription = string.Empty;
        AppConstant.Product.ProductoCodigo = string.Empty;
        AppConstant.Product.ProductoPrecio = string.Empty;
        AppConstant.Product.ProductoPrecioProveedor = string.Empty;
      }
    }

    private void EditProduct()
    {
      string sWhere = string.Empty;

      txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
      txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Producto_descripcion");
      txtDescripcionCorta.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Producto_descripcion_corta");
      cbTipoProducto.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Producto_tipo");      
      cbEstado.SelectedItem = oldEstado = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");

      sWhere = "producto_categoria_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "producto_categoria_id") + "";
      cbCategoria.SelectedItem = DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_descripcion", sWhere);

      if (DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "producto_sub_categoria_id") != string.Empty)
      {
        sWhere = "producto_sub_categoria_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "producto_sub_categoria_id") + "";
        cbSubCategoria.SelectedItem = DataUtil.FindSingleRow("producto_sub_categoria", "Producto_sub_categoria_descripcion", sWhere);
      }

      txtPrecioProveedor.Text = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "Precio_proveedor").ToString(DataUtil.Format.Decimals);
      txtMargen.Text = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "Margen_ganancia").ToString(DataUtil.Format.Decimals);
      txtPrecioFinal.Text = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "Precio_final").ToString(DataUtil.Format.Decimals);
      CalculoPrecioPublico();
      txtStock.Text = DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Cantidad_actual").ToString();
      txtStockAlert.Text = DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Cantidad_fuera_stock").ToString();

      if (DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Alerta_fuera_stock").Equals("1"))
        cbStock.Checked = true;

      if (DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_id") != string.Empty)
      {
        sWhere = "Proveedor_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_id") + "";
        cbProveedor.SelectedItem = DataUtil.FindSingleRow("proveedor", "Proveedor_nombre", sWhere);
      }
      else
      {
        lblRUC.Text = string.Empty;
        lblTelefono.Text = string.Empty;
        lblVendor.Text = string.Empty;
      }      

      if (DataUtil.GetString(cbTipoProducto.SelectedItem) != AppConstant.TipoProducto.Personalizado)
      {
        tcProducto.TabPages.Remove(tpReceta);
        tcProducto.TabPages.Remove(tpPaquete);        
      }
      if (DataUtil.GetString(cbTipoProducto.SelectedItem).Equals(AppConstant.TipoProducto.Adicional))              
        lblNota.Visible = true;      
    }    
    private void NewProduct()
    {
      if (createSpecial)
      {
        txtDescripcion.Text = productoNombre;
        if (tipo_quickButton != string.Empty)
        {
          cbTipoProducto.SelectedItem = tipo_quickButton;
          cbTipoProducto.Enabled = false;
        }
        if (categoria_quickButton != string.Empty)
        {
          string sWhere = "producto_categoria_id = " + categoria_quickButton + "";
          cbCategoria.SelectedItem = DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_descripcion", sWhere);
          cbCategoria.Enabled = false;          
        }
        if (subcategoria_quickButton != string.Empty)
        {
          string sWhere = "producto_sub_categoria_id = " + subcategoria_quickButton + "";
          cbSubCategoria.SelectedItem = DataUtil.FindSingleRow("producto_sub_categoria", "Producto_sub_categoria_descripcion", sWhere);
          cbSubCategoria.Enabled = false;
          btnAddCategoria.Visible = false;
        }
      }
      else
        cbTipoProducto.SelectedIndex = 0;
      lblRUC.Text = string.Empty;
      lblTelefono.Text = string.Empty;
      lblVendor.Text = string.Empty;
      cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
      tcProducto.TabPages.Remove(tpReceta);
      tcProducto.TabPages.Remove(tpPaquete);
    }
    #endregion

    #region Botones
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
          string subCategoriaWhere = "Producto_sub_categoria_descripcion = '" + DataUtil.GetString(cbSubCategoria.SelectedItem) + "'";
          string proveedorWhere = "Proveedor_nombre = '" + DataUtil.GetString(cbProveedor.SelectedItem) + "'";
          string proveedorValue = "null";

          if (DataUtil.GetString(cbProveedor.SelectedItem) != string.Empty)
            proveedorValue = DataUtil.FindSingleRow("proveedor", "Proveedor_id", proveedorWhere);

          string alertaFueraStock = cbStock.Checked ? "1" : "0";

          if (adding)
          {
            txtCodigo.Text = DataUtil.GetString(DataUtil.GetNewId(tableName));

            if (DataUtil.GetString(cbProveedor.SelectedItem) != string.Empty)
              proveedorValue = "'" + proveedorValue + "',";
            else
              proveedorValue = "" + proveedorValue + ",";

            string descripcion = txtDescripcion.Text.Trim();
            if (DataUtil.GetString(cbTipoProducto.SelectedItem).Equals("ADICIONAL"))
              descripcion = "- " + txtDescripcion.Text.Trim();

            

            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Producto_descripcion," +
                               "Producto_descripcion_corta," +
                               "Producto_categoria_id," +
                               "Producto_sub_categoria_id," +
                               "Proveedor_id," +
                               "Precio_proveedor," +
                               "Margen_ganancia," +
                               "Precio_final," +
                               "Producto_tipo," +
                               "Cantidad_actual," +
                               "Alerta_fuera_stock," +
                               "Cantidad_fuera_stock," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por,"+
                               "Estado)" +
                         " VALUES (" +
                               txtCodigo.Text + "," +
                               "'" + descripcion.Replace("'", "''") + "'," +
                               "'" + txtDescripcionCorta.Text.Replace("'", "''") + "'," +
                               "'" + DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere) + "'," +
                               "'" + DataUtil.FindSingleRow("producto_sub_categoria", "Producto_sub_categoria_id", subCategoriaWhere) + "'," +
                               proveedorValue +
                               "'" + txtPrecioProveedor.Text.Trim() + "'," +
                               "'" + txtMargen.Text.Trim() + "'," +
                               "'" + txtPrecioFinal.Text.Trim() + "'," +
                               "'" + cbTipoProducto.SelectedItem + "'," +
                               "'" + txtStock.Text.Trim() + "'," +
                               "'" + alertaFueraStock + "'," +
                               "'" + txtStockAlert.Text.Trim() + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + cbEstado.SelectedItem + "'" +
                         ")";
          }
          else
          {
            if (DataUtil.GetString(cbProveedor.SelectedItem) != string.Empty)
              proveedorValue = ", Proveedor_id = '" + proveedorValue + "'";
            else
              proveedorValue = ", Proveedor_id = " + proveedorValue + "";

            sqlForExecute = "UPDATE " + tableName + " SET " +
                        "Producto_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + "'" +
                        ",Producto_descripcion_corta = '" + txtDescripcionCorta.Text.Trim().Replace("'", "''") + "'" +
                        ", Producto_categoria_id = '" + DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere) + "'" +
                        ", Producto_sub_categoria_id = '" + DataUtil.FindSingleRow("producto_sub_categoria", "Producto_sub_categoria_id", subCategoriaWhere) + "'" +
                        proveedorValue +
                        ", Precio_proveedor = '" + txtPrecioProveedor.Text.Trim() + "'" +
                        ", Margen_ganancia = '" + txtMargen.Text.Trim() + "'" +
                        ", Precio_final = '" + txtPrecioFinal.Text.Trim() + "'" +
                        ", Producto_tipo = '" + cbTipoProducto.SelectedItem + "'" +
                        ", Cantidad_actual = '" + txtStock.Text.Trim() + "'" +
                        ", Alerta_fuera_stock = '" + alertaFueraStock + "'" +
                        ", Cantidad_fuera_stock = '" + txtStockAlert.Text.Trim() + "'" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        ", Estado = '" + cbEstado.SelectedItem + "'" +
                        " WHERE " + formWhereField + " = " + txtCodigo.Text;
          }

          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (adding)
            {
              if (createSpecial)
              {
                AppConstant.Product.ProductoDescription = txtDescripcion.Text.Trim();
                AppConstant.Product.ProductoDescriptionCorta = txtDescripcionCorta.Text.Trim();
                AppConstant.Product.ProductoCodigo = txtCodigo.Text;
                AppConstant.Product.ProductoPrecio = txtPrecioFinal.Text;
                AppConstant.Product.ProductoPrecioProveedor = txtPrecioProveedor.Text;
              }

              this.Close();
            }
            else
              oldEstado = DataUtil.GetString(cbEstado.SelectedItem);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Grabar: " + ex.Message);
        }
      }
    }        
    private void btnDeleteProducto_Click(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection Seleccionados = dgwReceta.SelectedRows;
      foreach (DataGridViewRow item in Seleccionados)
      {
        DialogResult diagResult = MessageBox.Show("Está seguro de eliminar el producto seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (diagResult == DialogResult.Yes)
        {
          if (DataUtil.Update("DELETE FROM movimientos WHERE Movimiento_id = " + item.Cells["MOVIMIENTO_ID"].Value.ToString() + ""))
          {
            this.dgwReceta.Rows.RemoveAt(item.Index);
          }
        }
      }
    }
    private void btnAddCategoria_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Desea agregar una nueva sub categoria?", "Sub Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        frmProductSubCategory frmProductSubCategoryAdd = new frmProductSubCategory();
        frmProductSubCategoryAdd.adding = true;
        frmProductSubCategoryAdd.formTitle = "Producto Sub Categoria - Agregar";
        frmProductSubCategoryAdd.ShowDialog();
        string categoriaWhere = "Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";        
        DataUtil.FillComboBox(cbSubCategoria.Items, DataBaseQuerys.ProductoSubCategoriaActivos(false, DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere)), null);
      }
    }
    #endregion

    #region Tab Precio
    private void btnCalculo_Click(object sender, EventArgs e)
    {
      this.CalculoMargen();
      //frmMarkup margenForm = new frmMarkup();
      //margenForm.ShowDialog();
      //if (AppConstant.Product.Margen != 0.0)
      //{
      //  txtPrecioProveedor.Text = AppConstant.Product.PrecioProveedor.ToString(DataUtil.Format.Decimals);
      //  txtPrecioFinal.Text = AppConstant.Product.PrecioFinal.ToString(DataUtil.Format.Decimals);
      //  txtMargen.Text = AppConstant.Product.Margen.ToString(DataUtil.Format.Decimals);
      //  CalculoIGV();

      //  AppConstant.Product.PrecioProveedor = 0.0;
      //  AppConstant.Product.PrecioFinal = 0.0;
      //  AppConstant.Product.Margen = 0.0;
      //}
    }
    private void btnCalculoPrecios_Click(object sender, EventArgs e)
    {
      this.CalculoPrecioFinal();
    }
    private void btnCalculoPrecioPublico_Click(object sender, EventArgs e)
    {
      this.CalculoPrecioFinalEspecial();
    }
    #endregion

    #region Stock
    private void btnProveedor_Click(object sender, EventArgs e)
    {
      frmSupplier frmSupplierAdd = new frmSupplier();
      frmSupplierAdd.adding = true;
      frmSupplierAdd.formTitle = "Proveedor - Agregar";
      frmSupplierAdd.ShowDialog();
      DataUtil.FillComboBox(cbProveedor.Items, "SELECT Proveedor_nombre FROM Proveedor WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ORDER BY Proveedor_nombre", null);
    }
    private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbProveedor.SelectedItem != null)
      {        
        DataSet dsProveedor = DataUtil.FillDataSet(DataBaseQuerys.Proveedor(DataUtil.GetString(cbProveedor.SelectedItem)), "proveedor");
        lblRUC.Text = DataUtil.GetString(dsProveedor.Tables[0].Rows[0], "Proveedor_ruc");
        lblTelefono.Text = DataUtil.GetString(dsProveedor.Tables[0].Rows[0], "Proveedor_Telefono");
        lblVendor.Text = DataUtil.GetString(dsProveedor.Tables[0].Rows[0], "Proveedor_contacto");
      }
      else
      {
        lblRUC.Text = string.Empty;
        lblTelefono.Text = string.Empty;
        lblVendor.Text = string.Empty;
      }
    }    
    private void btnRefresh_Click(object sender, EventArgs e)
    {
      this.CalculoPrecioFinal();
      this.CalculoPrecioFinalEspecial();
    }
    #endregion

    #region Receta
    private void txtProducto_DoubleClick(object sender, EventArgs e)
    {
      AppConstant.Calculator.textIN = string.Empty;
      frmKeyboard frmKeyboardForm = new frmKeyboard();
      frmKeyboardForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        txtProducto.Text = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
    }
    private void txtProducto_Leave(object sender, EventArgs e)
    {
      txtCodigoProducto.Text = string.Empty;
      txtPrecioUnitario.Text = string.Empty;
      txtProductoPrecioProveedor.Text = string.Empty;

      if (txtProducto.Text != string.Empty)
      {
        string stringSQL = DataBaseQuerys.ProductoSearch();

        DataSet dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Producto_descripcion like '%" + txtProducto.Text.Trim().Replace("'", "''") + "%' ORDER BY p.Producto_descripcion", "producto");
        if (dsSearch.Tables[0].Rows.Count == 1)
        {
          txtProducto.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Producto");
          txtCodigo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Codigo");
          txtPrecioUnitario.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Precio final");
          txtPrecioProveedor.Text = DataUtil.GetString(dsSearch.Tables[0].Rows[0], "Precio proveedor");
        }
        else if (dsSearch.Tables[0].Rows.Count > 1)
        {
          frmProductSearch frmProductSearchForm = new frmProductSearch();
          frmProductSearchForm.descriptionSearch = txtProducto.Text;
          frmProductSearchForm.dsSearchProd = dsSearch;
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
            frmProductAdd.ShowDialog();
            SetProductValues();
          }
          else
            txtProducto.Focus();
        }
      }
    }
    private void btnAddProducto_Click(object sender, EventArgs e)
    {
      if (txtCantidad.Text.Trim() != string.Empty && txtProducto.Text.Trim() != string.Empty)
      {
        string[] row = {txtCodigoProducto.Text,
                        txtProducto.Text,
                        txtCantidad.Text,                       
                        txtPrecioUnitario.Text
                       };
        dgwReceta.Rows.Add(row);

        txtCodigoProducto.Text = string.Empty;
        txtProducto.Text = string.Empty;
        txtCantidad.Text = "1";
        txtPrecioUnitario.Text = string.Empty;
        txtProductoPrecioProveedor.Text = string.Empty;

        txtProducto.Focus();
      }
      else
      {
        txtProducto.Focus();
        MessageBox.Show("Debe ingresar el Producto y la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    #endregion

    #region Eventos
    private void tcProducto_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (tcProducto.SelectedIndex)
      {
        case 0:
          txtPrecioProveedor.Focus();
          break;
        case 1:
          txtStock.Focus();
          break;
        case 2:
          txtProducto.Focus();
          break;
        case 3:
          break;
      }
    }
    private void cbTipoProducto_SelectedValueChanged(object sender, EventArgs e)
    {
      if (DataUtil.GetString(cbTipoProducto.SelectedItem) != AppConstant.TipoProducto.Personalizado)
      {
        tcProducto.TabPages.Remove(tpReceta);
        tcProducto.TabPages.Remove(tpPaquete);
      }
      else
      {
        tcProducto.TabPages.Add(tpReceta);
        tcProducto.TabPages.Add(tpPaquete);
      }

      if (DataUtil.GetString(cbTipoProducto.SelectedItem).Equals(AppConstant.TipoProducto.Adicional))
        lblNota.Visible = true;
      else
        lblNota.Visible = false;
    }
    private void cbCategoria_SelectedValueChanged(object sender, EventArgs e)
    {
      cbSubCategoria.SelectedItem = string.Empty;
      var categoriaWhere = "Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";      
      DataUtil.FillComboBox(cbSubCategoria.Items, DataBaseQuerys.ProductoSubCategoriaActivos(false, DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere)), null);
    }
    #endregion        
  }
}
