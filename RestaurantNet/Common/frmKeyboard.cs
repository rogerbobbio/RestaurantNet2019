using System;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmKeyboard : frmMain
  {
    public bool isPassword = false;
    public frmKeyboard()
    {
      InitializeComponent();
    }
    private void keyboardcontrol1_UserKeyPressed(object sender, KeyboardClassLibrary.KeyboardEventArgs e)
    {
      if (e.KeyboardKeyPressed == "{ENTER}")
        btnEnviar_Click(null,null);
      else
      {        
        txtInput.Focus();
        SendKeys.Send(e.KeyboardKeyPressed);
      }
    }    
    private void frmKeyboard_Load(object sender, EventArgs e)
    {
      if (isPassword)
        txtInput.PasswordChar = '*';
      txtInput.Text = AppConstant.Calculator.textIN;
    }
    private void btnEnviar_Click(object sender, EventArgs e)
    {
      AppConstant.Calculator.textOUT = txtInput.Text;
      Close();
    }
    private void btnCancelar_Click(object sender, EventArgs e)
    {
      AppConstant.Calculator.textOUT = string.Empty;
      Close();
    }
    private void btnBorrar_Click(object sender, EventArgs e)
    {
      txtInput.Text = string.Empty;
      txtInput.Focus();
    }
    private void frmKeyboard_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (AppConstant.Calculator.textOUT == null)
      {
        AppConstant.Calculator.textOUT = string.Empty;
        Close();
      }
    }

  }
}
