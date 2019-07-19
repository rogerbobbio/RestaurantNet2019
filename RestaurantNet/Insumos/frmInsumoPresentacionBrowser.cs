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
  public partial class frmInsumoPresentacionBrowser : frmMainBrowser
  {
    public frmInsumoPresentacionBrowser()
    {
      InitializeComponent();
    }

    private void frmInsumoPresentacionBrowser_Load(object sender, EventArgs e)
    {
      selectSQL = "pi.Presentacion_id AS Codigo," +
                  "pi.Presentacion_descripcion AS Descripcion," +
                  "Insumo_grupo.Insumo_grupo_descripcion AS Grupo," +
                  "pi.Ultimo_costo AS [Ultimo Costo]," +
                  "pi.Costo_promedio AS [Costo Promedio]," +
                  "pi.IGV," +
                  "pi.Costo_impuesto AS [Costo + Impuesto]," +
                  "Proveedor.Proveedor_nombre AS Proveedor," +
                  "Insumo.Insumo_descripcion AS [Insumo Base]," +
                  "pi.Rendimiento_valor AS [Rendimiento]," +
                  "pi.Rendimiento_unidad AS [Rendimiento Unidad]," +
                  "pi.Estado," +
                  "pi.Fecha_creacion AS [Fecha creacion]," +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "pi.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "((((Presentacion_Insumo AS pi " +
                           "INNER JOIN Insumo_grupo ON pi.Insumo_grupo_id = Insumo_grupo.Insumo_grupo_id) "+
                           "LEFT JOIN Insumo ON pi.Insumo_base_id = Insumo.Insumo_id) "+
                           "LEFT JOIN Proveedor ON pi.Proveedor_id = Proveedor.Proveedor_id) "+
                           "LEFT JOIN empleado AS cr ON pi.creado_por = cr.codigo_empleado)"+
                           "LEFT JOIN empleado AS up ON pi.actualizado_por = up.codigo_empleado";
      stringBrowserSQL = "SELECT " + selectSQL +
                         "  FROM " + tablesJoinsBrowser +
                         " ORDER BY pi.Presentacion_descripcion";
      tableNameBrowser = "Presentacion_Insumo";
      formTitle = "Lista de Presentaciones de insumos";
      BindDataGrid();
      OnLoad();
    }
  }
}
