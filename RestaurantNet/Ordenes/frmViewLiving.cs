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
  public partial class frmViewLiving : frmMain
  {
    public frmViewLiving()
    {
      InitializeComponent();
    }
    private void frmViewTables_Load(object sender, EventArgs e)
    {
      LoadButtons();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      AppConstant.Order.PedidoID = string.Empty;
      AppConstant.Order.OrdenDiaID = string.Empty;
      AppConstant.Order.PedidoOrigenID = string.Empty;
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (sender is Button)
      {
        Button btn = sender as Button;
        frmCustomerOrder frmCustomerOrderForm = new frmCustomerOrder();
        frmCustomerOrderForm.mesaID = DataUtil.GetString(btn.Tag);
        frmCustomerOrderForm.tipoMesa = "Mesa :";
        frmCustomerOrderForm.tipoVenta = AppConstant.TipoVenta.Salon;
        frmCustomerOrderForm.ShowDialog();
        LoadButtons();
        IsReadyPaid();
      }
    }
    private void button66_Click(object sender, EventArgs e)
    {
      if (sender is Button)
      {
        Button btn = sender as Button;
        frmCustomerOrder frmCustomerOrderForm = new frmCustomerOrder();
        frmCustomerOrderForm.mesaID = DataUtil.GetString(btn.Tag);
        frmCustomerOrderForm.tipoMesa = "Bar :";
        frmCustomerOrderForm.tipoVenta = AppConstant.TipoVenta.Salon;
        frmCustomerOrderForm.ShowDialog();
        LoadButtons();
        IsReadyPaid();
      }
    }

    private void LoadButtons()
    {
      foreach (Control button in this.Controls)
      {
        if (button is Button)
        {
          Button mesa = button as Button;

          if (mesa.Tag != null)
          {
            DataSet dsMesaInfo = DataUtil.FillDataSet(DataBaseQuerys.Mesa(DataUtil.GetInt(mesa.Tag)), "mesa");
            mesa.Text = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_descripcion");
            mesa.Visible = DataUtil.GetBool(dsMesaInfo.Tables[0].Rows[0], "Mesa_habilitado");
            if (DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_estado").Equals("LIBRE"))
              mesa.Image = RestautantResource.Mesa;
            else
              mesa.Image = RestautantResource.MesaOcupada;
          }
        }
      }
    }
    private void IsReadyPaid()
    {
      if (AppConstant.Order.PedidoID != string.Empty)
        this.Close();
    }
  }
}
