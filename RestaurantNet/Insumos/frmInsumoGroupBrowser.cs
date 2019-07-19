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
  public partial class frmInsumoGroupBrowser : frmMainBrowser
  {
    public frmInsumoGroupBrowser()
    {
      InitializeComponent();
    }

    private void frmInsumoGroupBrowser_Load(object sender, EventArgs e)
    {
      selectSQL = "ig.Insumo_grupo_id AS Codigo," +
                  "ig.Insumo_grupo_descripcion AS Descripcion," +
                  "igc.Insumo_grupo_clasificacion_descripcion AS Clasificación," +
                  "ig.Estado," +
                  "ig.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "ig.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "((Insumo_grupo AS ig LEFT JOIN empleado AS cr ON ig.creado_por = cr.codigo_empleado) " +
                           "  LEFT JOIN empleado AS up ON ig.actualizado_por = up.codigo_empleado)" +
                           "  LEFT JOIN Insumo_grupo_clasificacion AS igc ON ig.Insumo_grupo_clasificacion_id = igc.Insumo_grupo_clasificacion_id";
      stringBrowserSQL = "SELECT " + selectSQL +
                         "  FROM " + tablesJoinsBrowser +
                         " ORDER BY ig.Insumo_grupo_descripcion";
      tableNameBrowser = "Insumo_grupo";
      formTitle = "Lista de Grupos de insumos";
      BindDataGrid();
      OnLoad();
    }
  }
}
