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
  public partial class frmTable : frmMain
  {
    public frmTable()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void frmTable_Load(object sender, EventArgs e)
    {
      DataSet dsMesaInfo = null;

      foreach (Control mesa in gbSalon.Controls)
      {
        CheckBox cb = mesa as CheckBox;

        dsMesaInfo = DataUtil.FillDataSet(DataBaseQuerys.Mesa(DataUtil.GetInt(cb.Tag)), "mesa");
        cb.Text = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_descripcion");
        cb.Checked = DataUtil.GetBool(dsMesaInfo.Tables[0].Rows[0], "Mesa_habilitado");
      }
      foreach (Control bar in gbBar.Controls)
      {
        CheckBox cb = bar as CheckBox;

        dsMesaInfo = DataUtil.FillDataSet(DataBaseQuerys.Mesa(DataUtil.GetInt(cb.Tag)), "mesa");
        cb.Text = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_descripcion");
        cb.Checked = DataUtil.GetBool(dsMesaInfo.Tables[0].Rows[0], "Mesa_habilitado");
      }
    }
    private void checkBox1_Click(object sender, EventArgs e)
    {
      CheckBox cb = sender as CheckBox;
      frmTableConfig configForm = new frmTableConfig();
      configForm.mesaID = cb.Tag.ToString();
      configForm.enableMesa = "NO";
      if (cb.Checked)
        configForm.enableMesa = "SI";
      DialogResult result = configForm.ShowDialog();
      if (result == DialogResult.OK)
      {
        DataSet dsMesaInfo = DataUtil.FillDataSet(DataBaseQuerys.Mesa(DataUtil.GetInt(cb.Tag)), "mesa");
        cb.Text = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Mesa_descripcion");
        cb.Checked = DataUtil.GetBool(dsMesaInfo.Tables[0].Rows[0], "Mesa_habilitado");
      }
      else
      {
        if (cb.Checked)
          cb.Checked = false;
        else
          cb.Checked = true;
      }
    }
  }
}
