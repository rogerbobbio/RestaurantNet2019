using System;

namespace RestaurantNet
{
  public partial class frmAccountViewer : frmMain
  {
    public frmAccountViewer()
    {
      InitializeComponent();
    }

    private void btnAnuladas_Click(object sender, EventArgs e)
    {
        var frmAccountSearchForm = new frmAccountSearch
        {
            titleForm = "Busqueda de Cuentas Anuladas",
            pedidoEstado = AppConstant.PedidoEstado.Anulado
        };
        frmAccountSearchForm.ShowDialog();
    }

    private void btnNotaVenta_Click(object sender, EventArgs e)
    {
        var frmAccountSearchForm = new frmAccountSearch
        {
            titleForm = "Busqueda de Notas de venta",
            pedidoEstado = AppConstant.PedidoEstado.NotaVenta
        };
        frmAccountSearchForm.ShowDialog();
    }

    private void btnFacturada_Click(object sender, EventArgs e)
    {
      var frmBillSearchForm = new frmBillSearch();
      frmBillSearchForm.ShowDialog();
    }

    private void btnOrdenCobrar_Click(object sender, EventArgs e)
    {
        var frmAccountSearchForm = new frmAccountSearch
        {
            titleForm = "Busqueda de Ordenes por Cobrar",
            pedidoEstado = AppConstant.PedidoEstado.Atendiendo
        };
        frmAccountSearchForm.ShowDialog();
      if (AppConstant.Order.PedidoID != string.Empty)
        this.Close();
    }
  }
}
