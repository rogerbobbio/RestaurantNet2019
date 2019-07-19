using System;

namespace RestaurantNet
{
  public partial class frmTurnBrowser : frmMainBrowser
  {
    public frmTurnBrowser()
    {
      InitializeComponent();
    }

    private void frmTurnBrowser_Load(object sender, EventArgs e)
    {
      selectSQL = " c.Turno_id AS Codigo, " +
                  " c.Fondo_inicial_total AS [Fondo Inicial Total], " +
                  " c.Orden,  "+
                  " c.Estado, " +
                  " c.Fecha_apertura AS [Fecha Apertura], " +
                  " cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Aperturado por]," +
                  " c.Fecha_cierre AS [Fecha Cierre]," +
                  " up.Apellidos_empleado+', '+up.Nombres_empleado AS [Cerrado por]";
      tablesJoinsBrowser = "(turno AS c LEFT JOIN empleado AS cr ON c.Aperturado_por = cr.codigo_empleado)" +
                           "  LEFT JOIN empleado AS up ON c.Cerrado_por = up.codigo_empleado";
      stringBrowserSQL = "SELECT TOP 100 " + selectSQL + 
                         "  FROM " + tablesJoinsBrowser +
                         " ORDER BY c.Turno_id DESC";
      tableNameBrowser = "turno";
      formTitle = "Lista de Turnos";
      searchVisible = true;
      BindDataGrid();
      OnLoad();
    }
  }
}
