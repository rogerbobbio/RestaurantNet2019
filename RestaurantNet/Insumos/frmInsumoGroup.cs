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
  public partial class frmInsumoGroup : frmMainTable
  {
    public frmInsumoGroup()
    {
      InitializeComponent();
    }

    private void frmInsumoGroup_Load(object sender, EventArgs e)
    {
      tableName = "Insumo_grupo";
      formWhereField = "Insumo_grupo_id";
      OnLoad();
      BindDataFields();
    }

    private bool IsReadyToSave()
    {
      bool valueResult = IsReadyToSaveFirst();
      if (adding)
      {
        if (VerificarDuplicados().Equals(false))
          valueResult = false;
      }
      return valueResult;
    }
    private bool IsReadyToSaveFirst()
    {
      bool valueResult = true;
      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar Descripcion.");
        valueResult = false;
      }
      else
        epDescripcion.SetError(txtDescripcion, string.Empty);

      if (cbCategoria.SelectedItem == null)
      {
        epCategoria.SetError(cbCategoria, "Por favor ingresar la clasificación.");
        valueResult = false;
      }
      else
        epCategoria.SetError(cbCategoria, string.Empty);
      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (IsReadyToSaveFirst())
      {
        string categoriaWhere = "Insumo_grupo_clasificacion_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";
        string sWhere = "Insumo_grupo_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + 
                        "' AND Insumo_grupo_clasificacion_id = " + DataUtil.FindSingleRow("Insumo_grupo_clasificacion", "Insumo_grupo_clasificacion_id", categoriaWhere) + "";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show("El Grupo de insumo '" + txtDescripcion.Text.Trim() + "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
      return true;
    }
    private void BindDataFields()
    {
      DataUtil.FillComboBox(cbCategoria.Items, DataBaseQuerys.InsumoGrupoClasificacionActivos(), null);
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Insumo_grupo_descripcion");
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");

        string sWhere = "Insumo_grupo_clasificacion_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Insumo_grupo_clasificacion_id") + "";
        cbCategoria.SelectedItem = DataUtil.FindSingleRow("Insumo_grupo_clasificacion", "Insumo_grupo_clasificacion_descripcion", sWhere);
      }
      else
      {
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
      }
    }
    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("Insumo", "Count(*)", "Insumo_grupo_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show("No se puede borrar el grupo de insumo, tiene " + recordCount + " insumos asociados.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
          string categoriaWhere = "Insumo_grupo_clasificacion_descripcion = '" + DataUtil.GetString(cbCategoria.SelectedItem) + "'";

          if (adding)
          {
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Insumo_grupo_descripcion," +
                               "Insumo_grupo_clasificacion_id," +
                               "Estado," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               DataUtil.GetNewId(tableName) + "," +
                               "'" + txtDescripcion.Text.Trim() + "'," +
                               "'" + DataUtil.FindSingleRow("Insumo_grupo_clasificacion", "Insumo_grupo_clasificacion_id", categoriaWhere) + "'," +
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
                        "  Insumo_grupo_descripcion = '" + txtDescripcion.Text.Trim() + "'" +
                        ", Insumo_grupo_clasificacion_id = '" + DataUtil.FindSingleRow("Insumo_grupo_clasificacion", "Insumo_grupo_clasificacion_id", categoriaWhere) + "'" +
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
    private void btnAddCategoria_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Desea agregar una nueva Clasificación de grupos de insumos?", "Clasificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
        frmInsumoGroupClassification frmInsumoGroupClassificationAdd = new frmInsumoGroupClassification();
        frmInsumoGroupClassificationAdd.adding = true;
        frmInsumoGroupClassificationAdd.formTitle = "Clasificación de grupos de insumos - Agregar";
        frmInsumoGroupClassificationAdd.ShowDialog();
        DataUtil.FillComboBox(cbCategoria.Items, DataBaseQuerys.InsumoGrupoClasificacionActivos(), null);
      }
    }
    protected override void DeleteData()
    {
      idToDelete = txtCodigo.Text;
      base.DeleteData();
    }
  }
}
