using System;

namespace RestaurantNet
{
  public partial class frmProductSubCategoryBrowser : frmMainBrowser
  {
    public frmProductSubCategoryBrowser()
    {
      InitializeComponent();
    }

    private void frmProductSubCategoryBrowser_Load(object sender, EventArgs e)
    {
      btnAdd.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosSubCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosSubCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      selectSQL = "psc.Producto_sub_categoria_id AS Codigo," +
                  "psc.Producto_sub_categoria_descripcion AS Descripcion," +
                  "pc.Producto_categoria_descripcion AS Categoria," +
                  "psc.Estado," +                  
                  "psc.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "psc.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "((producto_sub_categoria AS psc LEFT JOIN empleado AS cr ON psc.creado_por=cr.codigo_empleado) " +
                           "  LEFT JOIN empleado AS up ON psc.actualizado_por=up.codigo_empleado)" +
                           "  LEFT JOIN producto_categoria AS pc ON psc.Producto_categoria_id=pc.Producto_categoria_id";
      stringBrowserSQL = "SELECT " + selectSQL +
                         "  FROM " + tablesJoinsBrowser +
                         " ORDER BY psc.Producto_sub_categoria_descripcion";
      tableNameBrowser = "producto_sub_categoria";
      formTitle = "Lista de Sub Categorias de Productos";
      searchVisible = true;
      categoriaVisible = true;
      BindDataGrid();
      OnLoad();
    }
  }
}
