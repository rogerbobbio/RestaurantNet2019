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
  public partial class frmInsumoGroupClassificationBrowser : frmMainBrowser
  {
    public frmInsumoGroupClassificationBrowser()
    {
      InitializeComponent();
    }
    private void frmInsumoGroupClassificationBrowser_Load(object sender, EventArgs e)
    {
      selectSQL = "igc.Insumo_grupo_clasificacion_id AS Codigo," +
                  "igc.Insumo_grupo_clasificacion_descripcion AS Descripcion," +
                  "igc.Estado," +                  
                  "igc.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "igc.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "(Insumo_grupo_clasificacion AS igc LEFT JOIN empleado AS cr ON igc.creado_por = cr.codigo_empleado) " +
                           "  LEFT JOIN empleado AS up ON igc.actualizado_por = up.codigo_empleado";
      stringBrowserSQL = "SELECT " + selectSQL +
                         "  FROM " + tablesJoinsBrowser +
                         " ORDER BY igc.Insumo_grupo_clasificacion_descripcion";
      tableNameBrowser = "Insumo_grupo_clasificacion";
      formTitle = "Lista de Clasificación de grupos de insumos";
      BindDataGrid();
      OnLoad();
    }
  }
}
