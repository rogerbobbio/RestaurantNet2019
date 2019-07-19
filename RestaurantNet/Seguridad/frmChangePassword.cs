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
  public partial class frmChangePassword : frmMain
  {
    public string oldPassword;

    public frmChangePassword()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmChangePassword_Load(object sender, EventArgs e)
    {
      txtOldPassword.Text = oldPassword;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        try
        {
          string sqlUpdate = "UPDATE empleado SET " +
                      "[password] = '" + txtNewPassword.Text.Trim() + "'" +
                      " WHERE [password] = '" + txtOldPassword.Text.Trim() + "'";

          if (DataUtil.Update(sqlUpdate))
          {
            MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Grabar: " + ex.Message);
        }
      }
    }
    private bool IsReadyToSave()
    {
      epNewPassword.SetError(txtNewPassword, string.Empty);
      epRePassword.SetError(txtRePassword, string.Empty);
      epDiferents.SetError(txtRePassword, string.Empty);
      bool valueResult = true;
      if (txtNewPassword.Text == string.Empty)
      {
        epNewPassword.SetError(txtNewPassword, "Por favor ingresar Nuevo Password.");
        valueResult = false;
      }       
      if (txtRePassword.Text == string.Empty)
      {
        epRePassword.SetError(txtRePassword, "Por favor ingresar Confirmacion del Password.");
        valueResult = false;
      } 
      if (txtNewPassword.Text != string.Empty && txtRePassword.Text != string.Empty)
      {
        if (txtNewPassword.Text != txtRePassword.Text)
        {
          epDiferents.SetError(txtRePassword, "El Nuevo Password y la confirmacion del Password son diferentes.");
          valueResult = false;
        }   
      }
      return valueResult;
    }
  }
}
