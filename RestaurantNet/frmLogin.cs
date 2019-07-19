using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace RestaurantNet
{
  public partial class frmLogin : frmMain 
  {
    public frmLogin()
    {
      InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (ValidatePassword())
      {
        var directoryName = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        if (directoryName != null)
          DataUtil.AppPath = directoryName.Remove(0, 6);
        if (DataUtil.ConnectDB())
        {
          var dsLogin = DataUtil.FillDataSet("SELECT estado, codigo_empleado, nombres_empleado, apellidos_empleado, cargo, [password] FROM empleado WHERE password = '" + txtPassword.Text + "'", "empleado");
          if (dsLogin != null && dsLogin.Tables[0].Rows.Count > 0)
          {
            if (DataUtil.GetString(dsLogin.Tables[0].Rows[0], "estado").Equals("0"))
              MessageBox.Show(@"Empleado deshabilitado consultar con tu Administrador.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
              AppConstant.EmployeeInfo.Codigo = DataUtil.GetString(dsLogin.Tables[0].Rows[0], "codigo_empleado");
              AppConstant.EmployeeInfo.Nombres = DataUtil.GetString(dsLogin.Tables[0].Rows[0], "nombres_empleado");
              AppConstant.EmployeeInfo.Apellidos = DataUtil.GetString(dsLogin.Tables[0].Rows[0], "apellidos_empleado");
              AppConstant.EmployeeInfo.Cargo = DataUtil.GetString(dsLogin.Tables[0].Rows[0], "cargo");
              AppConstant.EmployeeInfo.Password = dsLogin.Tables[0].Rows[0]["password"].ToString();
              SetGlobalConstant();
              DialogResult = DialogResult.OK;
            }
          }
          else
            MessageBox.Show(@"Contraseña incorrecta, trate nuevamente.", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
          DialogResult = DialogResult.No;
      }
    }

    private void txtPassword_Validated(object sender, EventArgs e)
    {
      ValidatePassword();
    }
    private bool ValidatePassword()
    {
      epPassword.SetError(txtPassword, string.Empty);
      bool valueResult = true;
      if (txtPassword.Text == string.Empty)
      {
        epPassword.SetError(txtPassword, "Por favor ingresar su contraseña.");
        valueResult = false;
      }
      return valueResult;
    }

    private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar.Equals('\r'))
        btnLogin_Click(sender,e);
    }
    private void SetGlobalConstant()
    {
      AppConstant.Order.PedidoID = string.Empty;
      AppConstant.Order.PedidoOrigenID = string.Empty;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void txtPassword_DoubleClick(object sender, EventArgs e)
    {
      AppConstant.Calculator.textIN = string.Empty;
      var frmKeyboardForm = new frmKeyboard();
      frmKeyboardForm.isPassword = true;
      frmKeyboardForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        txtPassword.Text = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
    }
  }
}
