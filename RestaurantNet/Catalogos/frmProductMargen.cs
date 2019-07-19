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
  public partial class frmProductMargen : frmMain
  {
    public frmProductMargen()
    {
      InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        try
        {
          double calculo = ((DataUtil.GetDouble(txtPrecioFinal.Text) - DataUtil.GetDouble(txtPrecioProveedor.Text)) / DataUtil.GetDouble(txtPrecioProveedor.Text)) * 100;
          txtMargen.Text = DataUtil.GetDouble(calculo).ToString(DataUtil.Format.Decimals);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Calculo :" + ex.Message);
        }
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      if (txtMargen.Text != string.Empty && txtMargen.Text != "NAN")
      {
        AppConstant.Product.PrecioProveedor = DataUtil.GetDouble(txtPrecioProveedor.Text);
        AppConstant.Product.PrecioFinal = DataUtil.GetDouble(txtPrecioFinal.Text);
        AppConstant.Product.Margen = DataUtil.GetDouble(txtMargen.Text);
      }

      this.Close();
    }

    private bool IsReadyToSave()
    {
      epPrecioFinal.SetError(txtPrecioFinal, string.Empty);
      epPrecioProveedor.SetError(txtPrecioProveedor, string.Empty);
      bool valueResult = true;
      if (txtPrecioProveedor.Text == string.Empty)
      {
        epPrecioProveedor.SetError(txtPrecioProveedor, "Por favor ingresar el Precio del Proveedor.");
        valueResult = false;
      }
        
      if (txtPrecioFinal.Text == string.Empty)
      {
        epPrecioFinal.SetError(txtPrecioFinal, "Por favor ingresar el Precio Final.");
        valueResult = false;
      }
        
      return valueResult;
    }
  }
}
