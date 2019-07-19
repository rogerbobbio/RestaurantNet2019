using System;

namespace RestaurantNet
{
  public partial class frmStationBrowser : frmMainBrowser
  {
    public frmStationBrowser()
    {
      InitializeComponent();
    }

    private void frmStationBrowser_Load(object sender, EventArgs e)
    {
      btnAdd.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Estaciones, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Estaciones, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      selectSQL = "e.estacion_id AS Codigo," +
                  "e.Estacion_descripcion AS Descripcion," +
                  "asig.Apellidos_empleado+', '+asig.Nombres_empleado AS [Estacion Asignada a]," +
                  "e.Estado," +
                  "e.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "e.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "((estacion AS e LEFT JOIN empleado AS cr ON e.creado_por=cr.codigo_empleado) " +
                           " LEFT JOIN empleado AS up ON e.actualizado_por=up.codigo_empleado)" +
                           " LEFT JOIN empleado AS asig ON e.Persona_asignada=asig.codigo_empleado";
      stringBrowserSQL = "SELECT " + selectSQL +
                         " FROM " + tablesJoinsBrowser +
                         " ORDER BY e.Estacion_descripcion";
      tableNameBrowser = "estacion";
      formTitle = "Lista de estaciones de trabajo";
      BindDataGrid();
      OnLoad();
    }
  }
}
