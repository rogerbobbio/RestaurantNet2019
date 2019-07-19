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
  public partial class frmChangeTable : frmMain
  {
    public string mesa = string.Empty;
    public string pedidoID = string.Empty;

    public frmChangeTable()
    {
      InitializeComponent();
    }

    private void frmChangeTable_Load(object sender, EventArgs e)
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
              mesa.Visible = false;
          }
        }
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string refValue = string.Empty;
      if (frmInputBox.InputBox("Ingresar codigo de autorizacion", "Codigo", "empleado", "password", "1", ref refValue, true, AppConstant.GeneralInfo.PasswordCambioMesa) == DialogResult.OK)
      {
        if (sender is Button)
        {
          Button btn = sender as Button;
          string sqlForExecute = string.Empty;

          if (mesa != string.Empty)
          {
            sqlForExecute = "UPDATE mesa SET Mesa_estado = 'LIBRE'," +
                                   "       Pedido_id = null" +
                                   " WHERE Mesa_id = " + mesa;
            DataUtil.UpdateThrow(sqlForExecute);
          }
          else
          {
            sqlForExecute = "UPDATE pedido SET Tipo_venta = 'SALON'" +
                                   " WHERE Pedido_id = " + pedidoID;
            DataUtil.UpdateThrow(sqlForExecute);
          }

          sqlForExecute = "UPDATE pedido SET Mesa_id = " + DataUtil.GetString(btn.Tag) + "" +
                          ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                          ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                          " WHERE Pedido_id = " + pedidoID;
          DataUtil.UpdateThrow(sqlForExecute);

          sqlForExecute = "UPDATE mesa SET " +
                          "Mesa_estado = 'OCUPADA'," +
                          "Pedido_id = " + pedidoID + "" +
                          " WHERE Mesa_id = " + DataUtil.GetString(btn.Tag);
          DataUtil.UpdateThrow(sqlForExecute);

          MessageBox.Show("Se cambio la mesa correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.Close();
        }
      }
    }
  }
}
