using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmMainTable : frmMain
  {
    public bool adding;
    public string formTitle;
    public string formId = "-1";
    public DataSet mainDataSet;
    public string idToDelete = string.Empty;
    public string tableName = string.Empty;
    public string formWhereField = string.Empty;

    public frmMainTable()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
    public void OnLoad()
    {
      if (adding)
        btnDelete.Enabled = false;
      else
        btnDelete.Enabled = true;
 
      Text = formTitle;
    }
    protected virtual void DeleteData()
    {
      DialogResult result = MessageBox.Show(@"Está seguro de eliminar el registro actual?", @"Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        if (ExistRecord())
        {
          if (DataUtil.Update("DELETE FROM " + tableName + " WHERE " + formWhereField + " = " + idToDelete))
          {
            MessageBox.Show(string.Format("Se eliminó {0} elemento(s).", 1), @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idToDelete = string.Empty;
            this.Close();
          }
        }
      }
    }
    protected virtual bool ExistRecord()
    {
      return true;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      DeleteData();
    }
  }
}
