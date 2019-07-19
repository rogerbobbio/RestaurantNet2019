using System;
using System.Data;

namespace RestaurantNet
{
  public partial class frmTurnProduct : frmMain
  {
    public int TurnoId;

    public frmTurnProduct()
    {
      InitializeComponent();
    }

    private void frmTurnProduct_Load(object sender, EventArgs e)
    {
      CargarProductos("2 DESC");
    }

    private void rbCantidad_CheckedChanged(object sender, EventArgs e)
    {
      CargarProductos(rbCantidad.Checked ? "2 DESC" : "1");
    }

    private void CargarProductos(string orderBy)
    {
      dgwProducto.Rows.Clear();
      string sqlCommand = "SELECT vd.Descripcion_Producto AS Descripcion," +
                          "       SUM(vd.Cantidad) AS Cantidad" +
                          " FROM (venta AS v LEFT JOIN venta_detalle AS vd ON v.venta_id = vd.venta_id)" +
                          " WHERE v.turno_id = " + TurnoId + "" +
                          " GROUP BY vd.Descripcion_Producto" +
                          " ORDER BY " + orderBy;
      DataSet dsVenta = DataUtil.FillDataSet(sqlCommand, "venta_detalle");
      foreach (DataRow ventaRow in dsVenta.Tables["venta_detalle"].Rows)
      {
        string[] row =
        {
          DataUtil.GetString(ventaRow["Descripcion"]),
          DataUtil.GetString(ventaRow["Cantidad"])
        };
        dgwProducto.Rows.Add(row);
      }
    }
  }
}
