using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmProductSearch : frmMain
  {
    public string descriptionSearch = string.Empty;
    public string categoriaIdSearch = string.Empty;
    public string subCategoriaIdSearch = string.Empty;
    public string tipoSearch = string.Empty;
    public DataSet dsSearchProd = null;

    public frmProductSearch()
    {
      InitializeComponent();
    }
    private void frmProductSearch_Load(object sender, EventArgs e)
    {
      btnAdd.Visible = DataBaseQuerys.GetAccess(13, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(13, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);      

      DataUtil.FillComboBox(cbCategoria.Items, DataBaseQuerys.ProductoCategoriaActivos(false), string.Empty);
      DataUtil.FillComboBox(cbSubCategoria.Items, DataBaseQuerys.ProductoSubCategoriaActivos(false, string.Empty), string.Empty);
      lblNo.Text = @"0";
      if (dsSearchProd != null)
      {
        cbCategoria.SelectedItem = string.Empty;
        cbSubCategoria.SelectedItem = string.Empty;
        cbTipo.SelectedItem = string.Empty;
        txtDescripcion.Text = descriptionSearch;
        dgwResult.DataSource = dsSearchProd;
        dgwResult.DataMember = "producto";
        dgwResult.Columns[1].Width = 300;
        lblNo.Text = DataUtil.GetString(dsSearchProd.Tables[0].Rows.Count);

        if (tipoSearch != string.Empty)
        {
          cbTipo.SelectedItem = tipoSearch;
          cbTipo.Enabled = false;
          btnClean.Visible = false;
        }
        if (categoriaIdSearch != string.Empty)
        {
          string sWhere = "producto_categoria_id = " + categoriaIdSearch + "";
          cbCategoria.SelectedItem = DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_descripcion", sWhere);
          sWhere = "producto_sub_categoria_id = " + subCategoriaIdSearch + "";
          cbSubCategoria.SelectedItem = DataUtil.FindSingleRow("producto_sub_categoria", "Producto_sub_categoria_descripcion", sWhere);
          cbCategoria.Enabled = false;
          cbSubCategoria.Enabled = false;
          btnClean.Visible = false;
        }
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
      var frmProductAdd = new frmProduct {adding = true, formTitle = "Producto - Agregar"};
      frmProductAdd.ShowDialog();
    }
    private void btnModify_Click(object sender, EventArgs e)
    {
      if ((dgwResult.Rows.Count > 0) && (dgwResult.CurrentRow.Cells[0].Value != null))
      {
        // Obtener el ID seleccionado
        var valueID = DataUtil.GetString(dgwResult.CurrentRow.Cells[0].Value);
        var frmProductEdit = new frmProduct();
        frmProductEdit.adding = false;
        frmProductEdit.formTitle = "Producto - Modificar";
        frmProductEdit.formId = valueID;
        frmProductEdit.ShowDialog();
        SearchRecords();
      }
      else
        MessageBox.Show(@"No se seleccionó ningún elemento, o no existen elementos a seleccionar!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    private void btnClean_Click(object sender, EventArgs e)
    {
      txtDescripcion.Text = string.Empty;
      cbCategoria.SelectedItem = string.Empty;
      cbSubCategoria.SelectedItem = string.Empty;
      cbTipo.SelectedItem = string.Empty;
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
      SearchRecords();
    }

    private void SearchRecords()
    {
      string searchWhere = string.Empty;
      if (DataUtil.GetString(cbTipo.SelectedItem) != string.Empty)
        searchWhere = " AND p.Producto_tipo = '" + cbTipo.SelectedItem + "'";
      if (txtDescripcion.Text.Trim() != string.Empty)
        searchWhere = searchWhere + " AND p.Producto_descripcion like '%" + txtDescripcion.Text.Trim().Replace("'", "''") + "%'";
      if (DataUtil.GetString(cbCategoria.SelectedItem) != string.Empty)
        searchWhere = searchWhere + " AND pc.Producto_categoria_descripcion = '" + cbCategoria.SelectedItem + "'";
      if (DataUtil.GetString(cbSubCategoria.SelectedItem) != string.Empty)
        searchWhere = searchWhere + " AND psc.Producto_sub_categoria_descripcion = '" + cbSubCategoria.SelectedItem + "'";

      string stringSQL = "p.Producto_id AS Codigo, " +
                          "p.Producto_descripcion AS [Producto], " +
                          "p.Producto_tipo AS [Tipo producto], " +
                          "pc.Producto_categoria_descripcion AS Categoria," +
                          "psc.Producto_sub_categoria_descripcion AS [Sub Categoria]," +
                          "pv.Proveedor_nombre AS Proveedor," +
                          "p.Precio_proveedor AS [Precio proveedor]," +
                          "p.Margen_ganancia AS [Margen de ganancia], " +
                          "p.Precio_final AS [Precio final], " +
                          "p.Cantidad_actual AS [Stock actual]," +
                          "p.Fecha_creacion AS [Fecha creacion], " +
                          "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                          "p.Fecha_actualizacion AS [Fecha actualizacion]," +
                          "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por],  " +
                          "p.Producto_descripcion_corta AS [Descripcion Corta] " +
                          " FROM ((((producto AS p LEFT JOIN empleado AS cr ON p.creado_por=cr.codigo_empleado)  " +
                          " LEFT JOIN empleado AS up ON p.actualizado_por = up.codigo_empleado)" +
                          " LEFT JOIN producto_categoria AS pc ON p.Producto_categoria_id = pc.Producto_categoria_id)" +
                          " LEFT JOIN producto_sub_categoria AS psc ON p.Producto_sub_categoria_id = psc.Producto_sub_categoria_id)" +
                          " LEFT JOIN proveedor AS pv ON p.Proveedor_id = pv.Proveedor_id";

      DataSet dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Producto_id <> -1 " + searchWhere + "  ORDER BY p.Producto_descripcion", "producto");

      dgwResult.DataSource = dsSearch;
      dgwResult.DataMember = "producto";
      lblNo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows.Count);

      if (dsSearch.Tables[0].Rows.Count.Equals(0))
        MessageBox.Show(@"No se encontro ningún registro.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void dgwResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
      {
        return;
      }
      if ((dgwResult.Rows.Count > 0) && (dgwResult.CurrentRow.Cells[1].Value != null))
      {
          //0.Codigo
          //1.Producto
          //2.Tipo producto
          //3.Categoria
          //4.Sub Categoria
          //5.Proveedor
          //6.Precio proveedor
          //7.Margen de ganancia
          //8.Precio final
          //9.Stock actual
          //10.Fecha creacion
          //11.Creado por
          //12.Fecha actualizacion
          //13.Actualizado por
          //14.Descripcion Corta

        AppConstant.Product.ProductoCodigo = DataUtil.GetString(dgwResult.CurrentRow.Cells[0].Value);
        AppConstant.Product.ProductoDescription = DataUtil.GetString(dgwResult.CurrentRow.Cells[1].Value);
        AppConstant.Product.ProductoPrecio = DataUtil.GetString(dgwResult.CurrentRow.Cells[8].Value);
        AppConstant.Product.ProductoPrecioProveedor = DataUtil.GetString(dgwResult.CurrentRow.Cells[6].Value);
        AppConstant.Product.ProductoDescriptionCorta = string.Empty;
        AppConstant.Product.ProductoDescriptionCorta = DataUtil.GetString(dgwResult.CurrentRow.Cells[14].Value);
        Close();
      }
    }

    private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
    {
      cbSubCategoria.SelectedItem = string.Empty;
      var categoriaWhere = "Producto_categoria_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";      
      DataUtil.FillComboBox(cbSubCategoria.Items, DataBaseQuerys.ProductoSubCategoriaActivos(false, DataUtil.FindSingleRow("producto_categoria", "Producto_categoria_id", categoriaWhere)), null);
    }
  }
}
