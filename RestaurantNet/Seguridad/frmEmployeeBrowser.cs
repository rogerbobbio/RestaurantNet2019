using System;

namespace RestaurantNet
{
  public partial class frmEmployeeBrowser : frmMainBrowser
  {
    public frmEmployeeBrowser()
    {
      InitializeComponent();
    }

    private void frmEmployeeBrowser_Load(object sender, EventArgs e)
    {
      btnAdd.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Empleados, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Empleados, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      selectSQL = "e.codigo_empleado AS Codigo," +
                  "e.Cargo," +
                  "e.Nombres_empleado AS Nombres," +
                  "e.Apellidos_empleado AS Apellidos," +
                  "e.Direccion," +
                  "e.Telefono_fijo AS [Telefono fijo]," +
                  "e.Celular," +
                  "e.Email," +
                  "e.Fecha_nacimiento AS [Fecha nacimiento]," +
                  "e.Fecha_ingreso AS [Fecha ingreso]," +
                  "e.Estado," +                  
                  "e.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "e.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "(empleado AS e LEFT JOIN empleado AS cr ON e.creado_por=cr.codigo_empleado) " +
                           " LEFT JOIN empleado AS up ON e.actualizado_por=up.codigo_empleado";
      stringBrowserSQL = "SELECT "+ selectSQL + 
                         " FROM "+ tablesJoinsBrowser +
                         " ORDER BY e.Nombres_empleado";
      tableNameBrowser = "empleado";
      formTitle = "Lista de empleados";
      BindDataGrid();
      OnLoad();
    }
  }
}
