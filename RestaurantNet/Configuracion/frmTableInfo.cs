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
  public partial class frmTableConfig : frmMain
  {
    public string mesaID;
    public string enableMesa;


    public frmTableConfig()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.No;
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        string sqlForExecute = string.Empty;
        try
        {
          string habilitado = DataUtil.GetString(cbEstado.SelectedItem) == "SI" ? "1" : "0";

          sqlForExecute = "UPDATE mesa SET " +
                      "Mesa_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + "'" +
                      ", Mesa_habilitado = '" + habilitado + "'" +
                      ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                      ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                      " WHERE Mesa_id = " + mesaID;


          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Grabar: " + ex.Message);
        }
      }      
    }

    private void frmTableConfig_Load(object sender, EventArgs e)
    {
      DataSet dsMesaInfo = DataUtil.FillDataSet(DataBaseQuerys.Mesa(DataUtil.GetInt(mesaID)), "mesa");
      txtDescripcion.Text = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_descripcion");
      if (txtDescripcion.Text.Equals("CONFIG. MESA") || txtDescripcion.Equals("CONFIG. BAR"))
        txtDescripcion.Text = string.Empty;
      lblTipo.Text = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_tipo");
      cbEstado.SelectedItem = enableMesa;
    }
    private bool IsReadyToSave()
    {
      epDescripcion.SetError(txtDescripcion, string.Empty);
      epDuplicado.SetError(txtDescripcion, string.Empty);
      bool valueResult = true;

      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar el Numero de Mesa o una descripcion.");
        valueResult = false;
      }
      
      if (txtDescripcion.Text != string.Empty)
      {
          string sWhere = "Mesa_descripcion = '" + txtDescripcion.Text.Replace("'", "''") + "'";
          if (DataUtil.GetInt(DataUtil.FindSingleRow("mesa", "Count(*)", sWhere)) >= 1)
          {
              epDuplicado.SetError(txtDescripcion, "La descripcion ya existe.");
              valueResult = false;
          }
      }
      
      return valueResult;
    }
  }
}
