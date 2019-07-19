using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBAccessManagement
{
  public partial class frmMain : Form
  {
    private string CadenaConexion = string.Empty;
    private OleDbConnection dbConnection;

    public frmMain()
    {
      InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {

    }

    private void btnSearchDB_Click(object sender, EventArgs e)
    {
      DialogResult result = this.openFileDialog1.ShowDialog();
      if (result == DialogResult.OK)
        txtDB.Text = openFileDialog1.FileName;
    }

    private void btnCleanDB_Click(object sender, EventArgs e)
    {
      txtDB.Text = string.Empty;
    }

    public bool ConnectDB()
    {
      CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=password1234; Data Source=" + txtDB.Text;
      MessageBox.Show(CadenaConexion, "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

      try
      {
        dbConnection = new OleDbConnection(CadenaConexion);
        dbConnection.Open();
        return true;
      }
      catch (Exception e)
      {
        if (e.Message.Contains("RestaurantNet.mdb") || e.Message.Contains("Disk or network"))
        {
          MessageBox.Show("No se pudo encontrar la ubicacion de la base de datos.", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtMensaje.Text = "Error - No se pudo encontrar la ubicacion de la base de datos.";
        }
        else
        {
          MessageBox.Show("Error al crear la conexión: " + e.Message, "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtMensaje.Text = "Error - Al crear la conexión: " + e.Message;
        }
        return false;
      }
    }
    public void UpdateThrow(string commandString)
    {
      if (dbConnection == null)
        ConnectDB();

      try
      {
        OleDbCommand cmd = new OleDbCommand(commandString, dbConnection);
        cmd.ExecuteNonQuery();
        txtMensaje.Text = "Ejecuccion de la sentencia satisfactoria.";
      }
      catch (Exception errActualizar)
      {
        txtMensaje.Text = errActualizar.ToString();
        throw (errActualizar);
      }
    }
    public DataSet FillDataSet(string commandString, string nombreTabla)
    {
      if (dbConnection == null)
        ConnectDB();

      try
      {
        var dbDataSet = new DataSet();
        var dbDataAdapter = new OleDbDataAdapter(commandString, dbConnection);
        OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dbDataAdapter);
        dbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        dbDataAdapter.Fill(dbDataSet, nombreTabla);
        txtMensajeDatos.Text = "Ejecuccion de la sentencia satisfactoria.";
        return dbDataSet;
      }
      catch (Exception ex)
      {
        txtMensajeDatos.Text = "Error en FillDataSet: " + ex.Message;
        MessageBox.Show("Error en FillDataSet: " + ex.Message);
        return null;
      }
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
      if (txtDB.Text != string.Empty)
      {
        if (txtSentencia.Text != string.Empty)
        {
          UpdateThrow(txtSentencia.Text);
        }
        else
          MessageBox.Show("Debe ingresar la sentencia a ejecutar", "Sentencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
        MessageBox.Show("Debe ingresar la ruta de la base de datos", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void btnVerDatos_Click(object sender, EventArgs e)
    {
      if (txtDB.Text != string.Empty)
      {
        if (txtSentenciaDatos.Text != string.Empty)
        {
          DataSet dsSearch = FillDataSet(txtSentenciaDatos.Text, "result");

          dgwResult.DataSource = dsSearch;
          dgwResult.DataMember = "result";
          lblNo.Text = dsSearch.Tables[0].Rows.Count.ToString();

          if (dsSearch.Tables[0].Rows.Count.Equals(0))
          {
            txtMensajeDatos.Text = "No se encontro ningún registro.";
            MessageBox.Show("No se encontro ningún registro.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
        else
          MessageBox.Show("Debe ingresar la sentencia a ejecutar", "Sentencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
        MessageBox.Show("Debe ingresar la ruta de la base de datos", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    private void btnClearAll_Click(object sender, EventArgs e)
    {
      txtSentencia.Text = string.Empty;
      txtMensaje.Text = string.Empty;
    }

    private void btnLimpiarDatos_Click(object sender, EventArgs e)
    {
      txtSentenciaDatos.Text = string.Empty;
      txtMensajeDatos.Text = string.Empty;
    }
  }
}
