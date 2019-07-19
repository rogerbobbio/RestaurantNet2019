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
  public partial class frmMainBrowser : frmMain
  {
    public string stringBrowserSQL = string.Empty;
    public string selectSQL = string.Empty;
    public string tableNameBrowser = string.Empty;
    public string tablesJoinsBrowser = string.Empty;
    public string formTitle = string.Empty;
    public bool searchVisible = false;
    public bool categoriaVisible = false;
    private string searchSQL = string.Empty;

    public int columnWidth0 = 50;
    public int columnWidth1 = 100;
    public int columnWidth2 = 100;
    public int columnWidth3 = 100;
    public int columnWidth4 = 100;
    public int columnWidth5 = 100;
    public int columnWidth6 = 100;
    public int columnWidth7 = 100;
    public int columnWidth8 = 100;

    public frmMainBrowser()
    {
      InitializeComponent();
    }

    #region Botones
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnModify_Click(object sender, EventArgs e)
    {
      ProceedOpen();
    }
    private void btnClean_Click(object sender, EventArgs e)
    {
      txtValue.Text = string.Empty;
      cbField.SelectedItem = string.Empty;
      epCampo.SetError(cbField, string.Empty);
      epValor.SetError(txtValue, string.Empty);
      searchSQL = string.Empty;
      BindDataGrid();      
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
      string sqlFill = string.Empty;
      if (IsReadyToSearch())
      {        
        if (cbField.SelectedIndex.Equals(0) || cbField.SelectedIndex.Equals(-1))
          sqlFill = "SELECT " + selectSQL + " FROM " + tablesJoinsBrowser + "";
        else
          sqlFill = "SELECT " + selectSQL + " FROM " + tablesJoinsBrowser + " WHERE " + cbField.SelectedItem + " like '%" + txtValue.Text.Trim() + "%'";
       
        
        if (cbCategoria.SelectedItem != null)
        {
          if (sqlFill.Contains("WHERE"))
            sqlFill = sqlFill + " AND pc.Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";
          else
            sqlFill = sqlFill + " WHERE pc.Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";
        }

        if (cbSubCategoria.SelectedItem != null)
        {
          if (sqlFill.Contains("WHERE"))
            sqlFill = sqlFill + " AND psc.Producto_sub_categoria_descripcion = '" + DataUtil.GetString(cbSubCategoria.SelectedItem) + "'";
          else
            sqlFill = sqlFill + " WHERE psc.Producto_sub_categoria_descripcion = '" + DataUtil.GetString(cbSubCategoria.SelectedItem) + "'";
        }

        searchSQL = sqlFill;
        DataSet dsSearch = DataUtil.FillDataSet(sqlFill, tableNameBrowser);
        dgwResult.DataSource = dsSearch;
        dgwResult.DataMember = tableNameBrowser;

        if (dsSearch.Tables[0].Rows.Count > 0)        
          lblNo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows.Count);
        else
        {
          lblNo.Text = "0";          
          MessageBox.Show("No se encontro ningún registro.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }
    #endregion    

    #region Metodos
    public void OnLoad()
    {
      this.Text = formTitle;
      lblCampo.Visible = searchVisible;
      lblValor.Visible = searchVisible;
      cbField.Visible = searchVisible;
      txtValue.Visible = searchVisible;
      btnSearch.Visible = searchVisible;
      btnClean.Visible = searchVisible;

      lblCategoria.Visible = categoriaVisible;
      lblSubCategoria.Visible = categoriaVisible;
      cbCategoria.Visible = categoriaVisible;
      cbSubCategoria.Visible = categoriaVisible;
    }
    public void BindDataGrid()
    {
      lblNo.Text = "0";
      if (stringBrowserSQL != string.Empty)
      {
        DataSet dsTable = DataUtil.FillDataSet(stringBrowserSQL, tableNameBrowser);
        dgwResult.DataSource = dsTable;
        dgwResult.DataMember = tableNameBrowser;
        dgwResult.Columns[0].Width = columnWidth0;
        dgwResult.Columns[1].Width = columnWidth1;
        dgwResult.Columns[2].Width = columnWidth2;
        dgwResult.Columns[3].Width = columnWidth3;
        dgwResult.Columns[4].Width = columnWidth4;
        dgwResult.Columns[5].Width = columnWidth5;
        dgwResult.Columns[6].Width = columnWidth6;
        if (dgwResult.Columns.Count > 7)
          dgwResult.Columns[7].Width = columnWidth7;
        if (dgwResult.Columns.Count > 8)
          dgwResult.Columns[8].Width = columnWidth8;

        lblNo.Text = DataUtil.GetString(dsTable.Tables[0].Rows.Count);
        if (searchVisible)
          DataUtil.FillComboBox(cbField.Items, "SELECT * FROM configuracion_busqueda WHERE tabla = '" + tableNameBrowser + "' ORDER BY campo", string.Empty);
      }

      if (categoriaVisible)
      {
        DataUtil.FillComboBox(cbCategoria.Items, DataBaseQuerys.ProductoCategoriaActivos(false), null);
        DataUtil.FillComboBox(cbSubCategoria.Items, DataBaseQuerys.ProductoSubCategoriaActivos(false, string.Empty), null);
      }
    }
    private void AfterSearch()
    {
      lblNo.Text = "0";
      if (searchSQL != string.Empty)
      {
        DataSet dsTable = DataUtil.FillDataSet(searchSQL, tableNameBrowser);
        dgwResult.DataSource = dsTable;
        dgwResult.DataMember = tableNameBrowser;
        lblNo.Text = DataUtil.GetString(dsTable.Tables[0].Rows.Count);        
      }
      else
        BindDataGrid();
    }    
    private bool IsReadyToSearch()
    {
      epCampo.SetError(cbField, string.Empty);
      epValor.SetError(txtValue, string.Empty);
      bool valueResult = true;

      if (categoriaVisible && cbCategoria.SelectedItem != null)
        valueResult = true;
      else
      {
        if (cbField.SelectedIndex.Equals(-1))
        {
          epCampo.SetError(cbField, "Por favor ingresar el campo por el cual quiere buscar.");
          valueResult = false;
        }

        if (cbField.SelectedIndex > 0)
        {
          if (txtValue.Text == string.Empty)
          {
            epValor.SetError(txtValue, "Por favor ingresar el valor que quiere buscar.");
            valueResult = false;
          }
        }
      }
      return valueResult;
    }
    #endregion

    #region Eventos
    private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar.Equals('\r'))
        btnSearch_Click(sender, e);
    }
    private void txtValue_DoubleClick(object sender, EventArgs e)
    {
      AppConstant.Calculator.textIN = string.Empty;
      frmKeyboard frmKeyboardForm = new frmKeyboard();
      frmKeyboardForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        txtValue.Text = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
    }
    private void dgwResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      ProceedOpen();
    }
    private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
      cbSubCategoria.SelectedItem = string.Empty;
      string categoriaWhere = "Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";
      DataUtil.FillComboBox(cbSubCategoria.Items, DataBaseQuerys.ProductoSubCategoriaActivos(false, DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere)), null);
    }
    #endregion

    #region Modificar cuando se agrege un mantenimiento.
    private void btnAdd_Click(object sender, EventArgs e)
    {
      switch (tableNameBrowser)
      {
        case "empleado":
          frmEmployee frmEmployeeAdd = new frmEmployee();
          frmEmployeeAdd.adding = true;
          frmEmployeeAdd.formTitle = "Empleados - Agregar";
          frmEmployeeAdd.ShowDialog();
          break;
        case "cliente":
          frmCustomer frmCustomerAdd = new frmCustomer();
          frmCustomerAdd.adding = true;
          frmCustomerAdd.formTitle = "Clientes - Agregar";
          frmCustomerAdd.ShowDialog();
          break;
        case "producto":
          frmProduct frmProductAdd = new frmProduct();
          frmProductAdd.adding = true;
          frmProductAdd.formTitle = "Producto - Agregar";
          frmProductAdd.ShowDialog();
          break;
        case "producto_categoria":
          frmProductCategory frmProductCategoryAdd = new frmProductCategory();
          frmProductCategoryAdd.adding = true;
          frmProductCategoryAdd.formTitle = "Producto Categoria - Agregar";
          frmProductCategoryAdd.ShowDialog();
          break;
        case "producto_sub_categoria":
          frmProductSubCategory frmProductSubCategoryAdd = new frmProductSubCategory();
          frmProductSubCategoryAdd.adding = true;
          frmProductSubCategoryAdd.formTitle = "Producto Sub Categoria - Agregar";
          frmProductSubCategoryAdd.ShowDialog();
          break;
        case "proveedor":
          frmSupplier frmSupplierAdd = new frmSupplier();
          frmSupplierAdd.adding = true;
          frmSupplierAdd.formTitle = "Proveedor - Agregar";
          frmSupplierAdd.ShowDialog();
          break;
        case "estacion":
          frmStation frmStationAdd = new frmStation();
          frmStationAdd.adding = true;
          frmStationAdd.formTitle = "Estacion de Trabajo - Agregar";
          frmStationAdd.ShowDialog();
          break;
        case "turno":
          frmTurn frmTurnAdd = new frmTurn();
          frmTurnAdd.adding = true;
          frmTurnAdd.formTitle = "Turno - Agregar";
          frmTurnAdd.ShowDialog();
          break;
        case "Insumo_grupo_clasificacion":
          frmInsumoGroupClassification frmInsumoGroupClassificationAdd = new frmInsumoGroupClassification();
          frmInsumoGroupClassificationAdd.adding = true;
          frmInsumoGroupClassificationAdd.formTitle = "Clasificación de grupos de insumos - Agregar";
          frmInsumoGroupClassificationAdd.ShowDialog();
          break;
        case "Insumo_grupo":
          frmInsumoGroup frmInsumoGroupAdd = new frmInsumoGroup();
          frmInsumoGroupAdd.adding = true;
          frmInsumoGroupAdd.formTitle = "Grupos de insumos - Agregar";
          frmInsumoGroupAdd.ShowDialog();
          break;
        case "Presentacion_Insumo":
          frmInsumoPresentacion frmInsumoPresentacionAdd = new frmInsumoPresentacion();
          frmInsumoPresentacionAdd.adding = true;
          frmInsumoPresentacionAdd.formTitle = "Presentaciones de insumos - Agregar";
          frmInsumoPresentacionAdd.ShowDialog();
          break;
      }
      BindDataGrid();
    }
    private void ProceedOpen()
    {
      if ((dgwResult.Rows.Count > 0) && (dgwResult.CurrentRow.Cells[0].Value != null))
      {
        // Obtener el ID seleccionado
        string valueID = DataUtil.GetString(dgwResult.CurrentRow.Cells[0].Value);

        switch (tableNameBrowser)
        {
          case "empleado":
            frmEmployee frmEmployeeEdit = new frmEmployee();
            frmEmployeeEdit.adding = false;
            frmEmployeeEdit.formTitle = "Empleados - Modificar";
            frmEmployeeEdit.formId = valueID;
            frmEmployeeEdit.ShowDialog();
            break;
          case "cliente":
            frmCustomer frmCustomerEdit = new frmCustomer();
            frmCustomerEdit.adding = false;
            frmCustomerEdit.formTitle = "Clientes - Modificar";
            frmCustomerEdit.formId = valueID;
            frmCustomerEdit.ShowDialog();
            break;
          case "producto":
            frmProduct frmProductEdit = new frmProduct();
            frmProductEdit.adding = false;
            frmProductEdit.formTitle = "Producto - Modificar";
            frmProductEdit.formId = valueID;
            frmProductEdit.ShowDialog();
            break;
          case "producto_categoria":
            frmProductCategory frmProductCategoryEdit = new frmProductCategory();
            frmProductCategoryEdit.adding = false;
            frmProductCategoryEdit.formTitle = "Producto Categoria - Modificar";
            frmProductCategoryEdit.formId = valueID;
            frmProductCategoryEdit.ShowDialog();
            break;
          case "producto_sub_categoria":
            frmProductSubCategory frmProductSubCategoryEdit = new frmProductSubCategory();
            frmProductSubCategoryEdit.adding = false;
            frmProductSubCategoryEdit.formTitle = "Producto Sub Categoria - Modificar";
            frmProductSubCategoryEdit.formId = valueID;
            frmProductSubCategoryEdit.ShowDialog();
            break;
          case "proveedor":
            frmSupplier frmSupplierEdit = new frmSupplier();
            frmSupplierEdit.adding = false;
            frmSupplierEdit.formTitle = "Proveedor - Modificar";
            frmSupplierEdit.formId = valueID;
            frmSupplierEdit.ShowDialog();
            break;
          case "estacion":
            frmStation frmStationEdit = new frmStation();
            frmStationEdit.adding = false;
            frmStationEdit.formTitle = "Estacion de Trabajo - Modificar";
            frmStationEdit.formId = valueID;
            frmStationEdit.ShowDialog();
            break;
          case "turno":
            frmTurn frmTurnEdit = new frmTurn();
            frmTurnEdit.adding = false;
            frmTurnEdit.formTitle = "Turno - Modificar";
            frmTurnEdit.formId = valueID;
            frmTurnEdit.ShowDialog();
            break;
          case "Insumo_grupo_clasificacion":
            frmInsumoGroupClassification frmInsumoGroupClassificationEdit = new frmInsumoGroupClassification();
            frmInsumoGroupClassificationEdit.adding = false;
            frmInsumoGroupClassificationEdit.formTitle = "Clasificación de grupos de insumos - Modificar";
            frmInsumoGroupClassificationEdit.formId = valueID;
            frmInsumoGroupClassificationEdit.ShowDialog();
            break;
          case "Insumo_grupo":
            frmInsumoGroup frmInsumoGroupEdit = new frmInsumoGroup();
            frmInsumoGroupEdit.adding = false;
            frmInsumoGroupEdit.formTitle = "Grupos de insumos - Modificar";
            frmInsumoGroupEdit.formId = valueID;
            frmInsumoGroupEdit.ShowDialog();
            break;
          case "Presentacion_Insumo":
            frmInsumoPresentacion frmInsumoPresentacionEdit = new frmInsumoPresentacion();
            frmInsumoPresentacionEdit.adding = false;
            frmInsumoPresentacionEdit.formTitle = "Presentaciones de insumos - Modificar";
            frmInsumoPresentacionEdit.formId = valueID;
            frmInsumoPresentacionEdit.ShowDialog();
            break;
        }
        AfterSearch();
      }
      else
        MessageBox.Show("No se seleccionó ningún elemento, o no existen elementos a seleccionar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    #endregion
  }
}
