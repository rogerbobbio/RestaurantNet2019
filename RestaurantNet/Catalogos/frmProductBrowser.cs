using System;

namespace RestaurantNet
{
  public partial class frmProductBrowser : frmMainBrowser
  {
    public frmProductBrowser()
    {
      InitializeComponent();
    }

    private void frmProductBrowser_Load(object sender, EventArgs e)
    {
      columnWidth1 = 300;
      btnAdd.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Productos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Productos, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      selectSQL = "p.Producto_id AS Codigo, " +
                  "p.Producto_descripcion AS [Producto], " +
                  "p.Producto_tipo AS [Tipo producto], " +
                  "pc.Producto_categoria_descripcion AS Categoria," +
                  "psc.Producto_sub_categoria_descripcion AS [Sub Categoria]," +
                  "pv.Proveedor_nombre AS Proveedor," +
                  "p.Precio_proveedor AS [Precio proveedor]," +
                  "p.Margen_ganancia AS [Margen de ganancia], " +
                  "p.Precio_final AS [Precio final], " +
                  "p.Cantidad_actual AS [Stock actual]," +
                  "p.Estado," +
                  "p.Fecha_creacion AS [Fecha creacion], " +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "p.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]  ";
      tablesJoinsBrowser = "((((producto AS p LEFT JOIN empleado AS cr ON p.creado_por=cr.codigo_empleado)  "+
                           " LEFT JOIN empleado AS up ON p.actualizado_por = up.codigo_empleado)"+
                           " LEFT JOIN producto_categoria AS pc ON p.Producto_categoria_id = pc.Producto_categoria_id)"+
                           " LEFT JOIN producto_sub_categoria AS psc ON p.Producto_sub_categoria_id = psc.Producto_sub_categoria_id)" +
                           " LEFT JOIN proveedor AS pv ON p.Proveedor_id = pv.Proveedor_id";
      stringBrowserSQL = "SELECT " + selectSQL +                  
                         " FROM " + tablesJoinsBrowser +
                         " ORDER BY p.Producto_descripcion";
      tableNameBrowser = "producto";
      formTitle = "Lista de Productos";
      searchVisible = true;
      categoriaVisible = true;
      BindDataGrid();
      OnLoad();
    }
  }
}
