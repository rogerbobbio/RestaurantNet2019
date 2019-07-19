using System;

namespace RestaurantNet
{
  public partial class frmSupplierBrowser : frmMainBrowser
  {
    public frmSupplierBrowser()
    {
      InitializeComponent();
    }

    private void frmSupplierBrowser_Load(object sender, EventArgs e)
    {
      btnAdd.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Proveedores, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Proveedores, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      selectSQL = "p.Proveedor_id AS Codigo," +
                  "p.Proveedor_nombre AS Proveedor," +
                  "p.Proveedor_ruc AS RUC," +
                  "p.Proveedor_Telefono AS Telefono," +
                  "p.Proveedor_Fax AS Fax," +
                  "p.Proveedor_web AS [Pagina Web]," +
                  "p.Proveedor_email AS Email," +
                  "p.Proveedor_contacto AS [Vendedor]," +
                  "p.Estado," +
                  "p.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "p.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "(proveedor AS p LEFT JOIN empleado AS cr ON p.creado_por=cr.codigo_empleado) " +
                           " LEFT JOIN empleado AS up ON p.actualizado_por=up.codigo_empleado";
      stringBrowserSQL = "SELECT " + selectSQL +
                         " FROM " + tablesJoinsBrowser +
                         " ORDER BY p.Proveedor_nombre";
      tableNameBrowser = "proveedor";
      formTitle = "Lista de Proveedores";
      BindDataGrid();
      OnLoad();
    }
  }
}
