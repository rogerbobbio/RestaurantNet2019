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
  public partial class frmInsumoGroupClassification : frmMainTable
  {  
    public frmInsumoGroupClassification()
    {
      InitializeComponent();
    }

    private void frmInsumoGroupClassification_Load(object sender, EventArgs e)
    {
      tableName = "Insumo_grupo_clasificacion";
      formWhereField = "Insumo_grupo_clasificacion_id";
      OnLoad();
      BindDataFields();
    }

    private bool IsReadyToSave()
    {
      bool valueResult = true;
      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar Descripcion.");
        valueResult = false;
      }
      else
        epDescripcion.SetError(txtDescripcion, string.Empty);


      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (txtDescripcion.Text != string.Empty)
      {
        string sWhere = "Insumo_grupo_clasificacion_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + "'";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show("La Clasificación '" + txtDescripcion.Text.Trim() + "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
      return true;
    }
    private void BindDataFields()
    {
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Insumo_grupo_clasificacion_descripcion");
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");        
      }
      else
      {
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;        
      }
    }
    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("Insumo_grupo", "Count(*)", "Insumo_grupo_clasificacion_id = " + txtCodigo.Text + ""));      
      if (recordCount > 0)
      {
        MessageBox.Show("No se puede borrar la clasificación, tiene Grupos de Insumos asociados.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      else
        return true;
    }
    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        string sqlForExecute = string.Empty;
        try
        {
          if (adding)
          {
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Insumo_grupo_clasificacion_descripcion," +
                               "Estado," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               DataUtil.GetNewId(tableName) + "," +
                               "'" + txtDescripcion.Text.Trim() + "'," +
                               "'" + cbEstado.SelectedItem + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'" +
                         ")";
          }
          else
          {
            sqlForExecute = "UPDATE " + tableName + " SET " +
                        "  Insumo_grupo_clasificacion_descripcion = '" + txtDescripcion.Text.Trim() + "'" +
                        ", Estado = '" + cbEstado.SelectedItem + "'" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE " + formWhereField + " = " + txtCodigo.Text;
          }

          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show("Registro grabado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (adding)
              this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Grabar: " + ex.Message);
        }
      }
    }
    protected override void DeleteData()
    {
      idToDelete = txtCodigo.Text;
      base.DeleteData();
    }
  }
}
