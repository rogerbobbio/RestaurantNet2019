using System;

namespace RestaurantNet
{
  public partial class frmProductCategoryBrowser : frmMainBrowser
  {
    public frmProductCategoryBrowser()
    {
      InitializeComponent();
    }
    private void frmProductCategoryBrowser_Load(object sender, EventArgs e)
    {
      btnAdd.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.ProductosCategorias, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      selectSQL = "pc.Producto_categoria_id AS Codigo," +
                  "pc.Producto_categoria_descripcion AS Descripcion," +
                  "pc.Estado," +
                  "IIF(Producto_sistema<>0, 'SI', 'NO') AS [Categoria del Sistema?]," +
                  "pc.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "pc.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "(producto_categoria AS pc LEFT JOIN empleado AS cr ON pc.creado_por=cr.codigo_empleado) " +
                           "  LEFT JOIN empleado AS up ON pc.actualizado_por=up.codigo_empleado";
      stringBrowserSQL = "SELECT " + selectSQL +                         
                         "  FROM " + tablesJoinsBrowser +
                         " ORDER BY pc.Producto_categoria_id";
      tableNameBrowser = "producto_categoria";
      formTitle = "Lista de Categorias de Productos";
      BindDataGrid();
      OnLoad();
    }
  }
}
