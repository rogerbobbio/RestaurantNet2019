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
  public partial class frmCalculator : frmMain
  {
    public frmCalculator()
    {
      InitializeComponent();
    }

    private void btn7_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "7";
    }

    private void btn8_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "8";
    }

    private void btn9_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "9";
    }

    private void btn4_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "4";
    }

    private void btn5_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "5";
    }

    private void btn6_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "6";
    }

    private void btn1_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "1";
    }

    private void btn2_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "2";
    }

    private void btn3_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "3";
    }

    private void btn0_Click(object sender, EventArgs e)
    {
      txtInput.Text = txtInput.Text + "0";
    }

    private void btnPunto_Click(object sender, EventArgs e)
    {
      if (!txtInput.Text.Contains("."))
        txtInput.Text = txtInput.Text + ".";
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      AppConstant.Calculator.textOUT = txtInput.Text;
      this.Close();
    }

    private void btnBorrar_Click(object sender, EventArgs e)
    {
      txtInput.Text = string.Empty;
      txtInput.Focus();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      AppConstant.Calculator.textOUT = string.Empty;
      this.Close();
    }

    private void frmCalculator_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (AppConstant.Calculator.textOUT == null)
      {
        AppConstant.Calculator.textOUT = string.Empty;
        this.Close();
      }
    }
  }
}
