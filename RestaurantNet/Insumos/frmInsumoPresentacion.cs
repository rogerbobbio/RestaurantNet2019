using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmInsumoPresentacion : frmMainTable
  {
    public frmInsumoPresentacion()
    {
      InitializeComponent();
    }

    private void frmInsumoPresentacion_Load(object sender, EventArgs e)
    {
      tableName = "Presentacion_Insumo";
      formWhereField = "Presentacion_id";
      OnLoad();
      BindDataFields();      
    }

    #region Metodos Privados
    private void BindDataFields()
    {
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      DataUtil.FillComboBox(cbGrupo.Items, DataBaseQuerys.InsumoGrupoClasificacionActivos(), null);
      DataUtil.FillComboBox(cbProveedor.Items, "SELECT Proveedor_nombre FROM Proveedor WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ORDER BY Proveedor_nombre", null);

      if (mainDataSet.Tables[0].Rows.Count > 0)
        EditProduct();
      else
        NewProduct();
    }
    private bool IsReadyToSave()
    {
      bool valueResult = true;
      valueResult = IsReadyToSaveFirst();      

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
      epDescripcion.SetError(txtDescripcion, string.Empty);
      epGrupo.SetError(cbGrupo, string.Empty);
      epUltimoCosto.SetError(txtUltimoCosto, string.Empty);
      epIGV.SetError(txtIGV, string.Empty);
      epCostoImpuesto.SetError(txtCostoImpuesto, string.Empty);
      epRendimiento.SetError(txtRendimiento, string.Empty);
      epUnidad.SetError(txtRendimientoUnidad, string.Empty);

      if (txtDescripcion.Text == string.Empty)
      {
        epDescripcion.SetError(txtDescripcion, "Por favor ingresar la descripcion.");
        valueResult = false;
      }        

      if (cbGrupo.SelectedItem == null)
      {
        epGrupo.SetError(cbGrupo, "Por favor ingresar el Grupo.");
        valueResult = false;
      }

      if (txtUltimoCosto.Text == string.Empty)
      {
        epUltimoCosto.SetError(txtUltimoCosto, "Por favor ingresar el Ultimo Costo.");
        valueResult = false;
      }

      if (txtIGV.Text == string.Empty)
      {
        epIGV.SetError(txtIGV, "Por favor ingresar el IGV.");
        valueResult = false;
      }

      if (txtCostoImpuesto.Text == string.Empty)
      {
        epCostoImpuesto.SetError(txtCostoImpuesto, "Por favor ingresar el Costo c/ impuesto.");
        valueResult = false;
      }

      if (txtRendimiento.Text == string.Empty)
      {
        epRendimiento.SetError(txtRendimiento, "Por favor ingresar el Rendimiento.");
        valueResult = false;
      }
      else
      {
        if (txtRendimientoUnidad.Text == string.Empty)
        {
          epUnidad.SetError(txtRendimientoUnidad, "Por favor ingresar la unidad del Rendimiento.");
          valueResult = false;
        }
      }

      return valueResult;
    }
    private bool VerificarDuplicados()
    {
      if (IsReadyToSaveFirst())
      {
        string grupoWhere = "Insumo_grupo_descripcion = '" + DataUtil.GetString(cbGrupo.SelectedItem) + "'";
        DataSet dsSearch = DataUtil.FillDataSet(DataBaseQuerys.PresentacionInsumo(string.Empty,
                                                                                  DataUtil.FindSingleRow("Insumo_grupo", "Insumo_grupo_id", grupoWhere),
                                                                                  txtDescripcion.Text.Trim().Replace("'", "''")), "Presentacion_Insumo");
        if (dsSearch.Tables[0].Rows.Count > 0)
        {
          MessageBox.Show("La presentacion '" + txtDescripcion.Text.Trim() + "' ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
        return true;
      }
      else
        return false;
    }    
    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("Insumo_Presentacion", "Count(*)", "Presentacion_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show("No se puede borrar la presentacion esta asociado a insumos.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      else
        return true;
    }
    private void CalculoCostoImpuesto()
    {
      if (txtUltimoCosto.Text != string.Empty && txtIGV.Text != string.Empty)
      {
        try
        {
          double subTotal = DataUtil.GetDouble(txtUltimoCosto.Text);
          double igvValue = (subTotal * (DataUtil.GetDouble(txtIGV.Text) / 100));
          double totalGeneral = subTotal + igvValue;
          txtCostoImpuesto.Text = totalGeneral.ToString(DataUtil.Format.Decimals);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error en Calculo :" + ex.Message);
        }
      }
    }
    
    private void EditProduct()
    {
      string sWhere = string.Empty;

      txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
      txtDescripcion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Presentacion_descripcion");      
      cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");

      sWhere = "Insumo_grupo_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Insumo_grupo_id") + "";
      cbGrupo.SelectedItem = DataUtil.FindSingleRow("Insumo_grupo", "Insumo_grupo_descripcion", sWhere);

      if (DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Insumo_base_id") != string.Empty)
      {
        sWhere = "Insumo_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Insumo_base_id") + "";
        cbInsumoBase.SelectedItem = DataUtil.FindSingleRow("Insumo", "Insumo_descripcion", sWhere);
      }

      txtUltimoCosto.Text = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "Ultimo_costo").ToString(DataUtil.Format.Decimals);
      txtCostoPromedio.Text = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "Costo_promedio").ToString(DataUtil.Format.Decimals);
      txtIGV.Text = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "IGV").ToString(DataUtil.Format.Decimals);
      txtCostoImpuesto.Text = DataUtil.GetDouble(mainDataSet.Tables[0].Rows[0], "Costo_impuesto").ToString(DataUtil.Format.Decimals);
      txtRendimiento.Text = DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Rendimiento_valor").ToString(DataUtil.Format.Decimals);
      txtRendimientoUnidad.Text = DataUtil.GetInt(mainDataSet.Tables[0].Rows[0], "Rendimiento_unidad").ToString();

      if (DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_id") != string.Empty)
      {
        sWhere = "Proveedor_id = " + DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Proveedor_id") + "";
        cbProveedor.SelectedItem = DataUtil.FindSingleRow("proveedor", "Proveedor_nombre", sWhere);
      }      
    }
    private void NewProduct()
    {
      txtIGV.Text = AppConstant.GeneralInfo.IGV;
      cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;
    }
    #endregion

    #region Botones
    protected override void DeleteData()
    {
      idToDelete = txtCodigo.Text;
      base.DeleteData();
    }
    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        string sqlForExecute = string.Empty;
        try
        {
          string grupoWhere = "Insumo_grupo_descripcion = '" + DataUtil.GetString(cbGrupo.SelectedItem) + "'";
          string insumoWhere = "Insumo_descripcion = '" + DataUtil.GetString(cbInsumoBase.SelectedItem) + "'";
          string proveedorWhere = "Proveedor_nombre = '" + DataUtil.GetString(cbProveedor.SelectedItem) + "'";
          string proveedorValue = "null";
          string insumoValue = "null";

          if (DataUtil.GetString(cbProveedor.SelectedItem) != string.Empty)          
            proveedorValue = DataUtil.FindSingleRow("proveedor", "Proveedor_id", proveedorWhere);            

          if (DataUtil.GetString(cbInsumoBase.SelectedItem) != string.Empty)
            insumoValue = DataUtil.FindSingleRow("insumo", "Insumo_id", proveedorWhere);


          if (adding)
          {
            txtCodigo.Text = DataUtil.GetString(DataUtil.GetNewId(tableName));

            if (DataUtil.GetString(cbProveedor.SelectedItem) != string.Empty)            
              proveedorValue = "'" + proveedorValue + "',";            
            else
              proveedorValue = "" + proveedorValue + ",";

            if (DataUtil.GetString(cbInsumoBase.SelectedItem) != string.Empty)                        
              insumoValue = "'" + insumoValue + "',";            
            else
              insumoValue = "" + insumoValue + ",";

            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Insumo_grupo_id," +
                               "Presentacion_descripcion," +
                               "Ultimo_costo," +
                               "Costo_promedio," +
                               "IGV," +
                               "Costo_impuesto," +
                               "Proveedor_id," +
                               "Insumo_base_id," +
                               "Rendimiento_valor," +
                               "Rendimiento_unidad," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por," +
                               "Estado)" +
                         " VALUES (" +
                               txtCodigo.Text + "," +
                               "'" + DataUtil.FindSingleRow("Insumo_grupo", "Insumo_grupo_id", grupoWhere) + "'," +
                               "'" + txtDescripcion.Text.Replace("'", "''") + "'," +
                               "'" + txtUltimoCosto.Text.Trim() + "'," +
                               "'" + txtCostoPromedio.Text.Trim() + "'," +
                               "'" + txtIGV.Text.Trim() + "'," +
                               "'" + txtCostoImpuesto.Text.Trim() + "'," +
                               proveedorValue +
                               insumoValue +
                               "'" + txtRendimiento.Text.Trim() + "'," +
                               "'" + txtRendimientoUnidad.Text.Trim() + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + DateTime.Now + "'," +
                               "'" + AppConstant.EmployeeInfo.Codigo + "'," +
                               "'" + cbEstado.SelectedItem + "'" +
                         ")";
          }
          else
          {
            if (DataUtil.GetString(cbProveedor.SelectedItem) != string.Empty)
              proveedorValue = ", Proveedor_id = '" + proveedorValue + "'";
            else
              proveedorValue = ", Proveedor_id = " + proveedorValue + "";

            if (DataUtil.GetString(cbInsumoBase.SelectedItem) != string.Empty)
              insumoValue = ", Insumo_base_id = '" + insumoValue + "'";
            else
              insumoValue = ", Insumo_base_id = " + insumoValue + "";

            sqlForExecute = "UPDATE " + tableName + " SET " +
                            " Insumo_grupo_id = '" + DataUtil.FindSingleRow("Insumo_grupo", "Insumo_grupo_id", grupoWhere) + "'" +
                            ",Presentacion_descripcion = '" + txtDescripcion.Text.Trim().Replace("'", "''") + "'" +
                            ",Ultimo_costo = '" + txtUltimoCosto.Text.Trim() + "'" +
                            ",Costo_promedio = '" + txtCostoPromedio.Text.Trim() + "'" +
                            ",IGV = '" + txtIGV.Text.Trim() + "'" +
                            ",Costo_impuesto = '" + txtCostoImpuesto.Text.Trim() + "'" +
                            proveedorValue +
                            insumoValue +
                            ",Rendimiento_valor = '" + txtRendimiento.Text.Trim() + "'" +
                            ",Rendimiento_unidad = '" + txtRendimientoUnidad.Text.Trim() + "'" +
                            ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                            ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                            ", Estado = '" + cbEstado.SelectedItem + "'" +
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
    private void btnCalculo_Click(object sender, EventArgs e)
    {
      CalculoCostoImpuesto();
    }
    #endregion

    #region Eventos
    private void cbGrupo_SelectedValueChanged(object sender, EventArgs e)
    {
      cbInsumoBase.SelectedItem = string.Empty;
      string categoriaWhere = "Insumo_grupo_descripcion = '" + DataUtil.GetString(cbGrupo.SelectedItem) + "'";
      DataUtil.FillComboBox(cbInsumoBase.Items, DataBaseQuerys.InsumosActivos(false, DataUtil.FindSingleRow("Insumo_grupo", "Insumo_grupo_id", categoriaWhere)), null);
    }
    private void txtUltimoCosto_TextChanged(object sender, EventArgs e)
    {
      CalculoCostoImpuesto();
    }
    #endregion
  }
}
