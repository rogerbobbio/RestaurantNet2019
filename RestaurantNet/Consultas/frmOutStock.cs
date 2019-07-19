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
  public partial class frmOutStock : frmMain
  {
    public frmOutStock()
    {
      InitializeComponent();
    }

    private void frmOutStock_Load(object sender, EventArgs e)
    {
      string searchWhere = "AND p.Alerta_fuera_stock = '1' AND p.Cantidad_actual <= p.Cantidad_fuera_stock";
      string stringSQL = "p.Producto_id AS Codigo, " +
                  "p.Producto_descripcion AS [Producto], " +
                  "p.Producto_tipo AS [Tipo producto], " +
                  "pc.Producto_categoria_descripcion AS Categoria," +
                  "pv.Proveedor_nombre AS Proveedor," +
                  "p.Precio_proveedor AS [Precio proveedor]," +
                  "p.Margen_ganancia AS [Margen de ganancia], " +
                  "p.Precio_final AS [Precio final], " +
                  "p.Cantidad_actual AS [Stock actual]," +
                  "p.Fecha_creacion AS [Fecha creacion], " +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "p.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]  " +
                  " FROM (((producto AS p LEFT JOIN empleado AS cr ON p.creado_por=cr.codigo_empleado)  " +
                  " LEFT JOIN empleado AS up ON p.actualizado_por=up.codigo_empleado)" +
                  " LEFT JOIN producto_categoria AS pc ON p.Producto_categoria_id=pc.Producto_categoria_id)" +
                  " LEFT JOIN proveedor AS pv ON p.Proveedor_id = pv.Proveedor_id";

      DataSet dsSearch = DataUtil.FillDataSet("SELECT " + stringSQL + " WHERE p.Producto_id <> -1 " + searchWhere + "  ORDER BY p.Producto_descripcion", "producto");

      dgwResult.DataSource = dsSearch;
      dgwResult.DataMember = "producto";
      lblNo.Text = DataUtil.GetString(dsSearch.Tables[0].Rows.Count);
    }
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dgwResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == -1)
        return;
      else
      {
        frmProduct frmProductEdit = new frmProduct();
        frmProductEdit.adding = false;
        frmProductEdit.formTitle = "Producto - Modificar";
        frmProductEdit.formId = DataUtil.GetString(dgwResult.CurrentRow.Cells[0].Value);
        frmProductEdit.ShowDialog();
      }
    }
  }
}
