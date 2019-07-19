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
  public partial class frmCustomerOrderSaleNote : frmMain
  {
    public int pedidoID = 0;
    public int mesaID = 0;

    public frmCustomerOrderSaleNote()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnAnular_Click(object sender, EventArgs e)
    {
      string refValue = string.Empty;
      if (IsReadyToSave())
      {
        if (frmInputBox.InputBox("Ingresar codigo de autorizacion", "Codigo", "empleado", "password", "1", ref refValue, true, AppConstant.GeneralInfo.PasswordNotaVenta) == DialogResult.OK)
        {
          string sqlForExecute = string.Empty;
          try
          {
            sqlForExecute = "UPDATE pedido SET " +
                            "Comentarios = '" + txtComentarios.Text.Trim() + "'" +
                            ", Estado = 'N'" +
                            ", Fecha_anulacion = '" + DateTime.Now + "'" +
                            ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                            ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                            " WHERE pedido_id = " + pedidoID;

            DataUtil.UpdateThrow(sqlForExecute);

            if (mesaID != 0)
            {
              sqlForExecute = "UPDATE mesa SET " +
                            "Mesa_estado = 'LIBRE'," +
                            "Pedido_id = null" +
                            " WHERE Mesa_id = " + mesaID;

              DataUtil.UpdateThrow(sqlForExecute);
            }


            if (DataUtil.Update(sqlForExecute))
            {
              MessageBox.Show("Registro guardado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              this.Close();
            }
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error en Grabar: " + ex.Message);
          }
        }
      }
    }
    private bool IsReadyToSave()
    {
      epComentarios.SetError(txtComentarios, string.Empty);
      bool valueResult = true;
      if (txtComentarios.Text == string.Empty)
      {
        txtComentarios.Focus();
        epComentarios.SetError(txtComentarios, "Por favor ingresar las razones de la nota de venta.");
        valueResult = false;
      }   
      return valueResult;
    }

    private void txtComentarios_DoubleClick(object sender, EventArgs e)
    {
      AppConstant.Calculator.textIN = string.Empty;
      frmKeyboard frmKeyboardForm = new frmKeyboard();
      frmKeyboardForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        txtComentarios.Text = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;   
    }
  }
}
