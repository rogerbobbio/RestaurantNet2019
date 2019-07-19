using System;
using System.Windows.Forms;

namespace RestaurantNet
{
  public partial class frmCustomer : frmMainTable
  {    
    public bool CreateSpecial = false;
    public string ClienteNumeroTelefono = string.Empty;
    public string ClienteApellido = string.Empty;
    public bool CustomerRUC = false;

    public frmCustomer()
    {
      InitializeComponent();
    }
    private void frmCustomer_Load(object sender, EventArgs e)
    {
      tableName = "cliente";
      formWhereField = "Cliente_id";
      OnLoad();
      BindDataFields();

      btnDelete.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Clientes, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnSave.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Clientes, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo) ||
                        DataBaseQuerys.GetAccess(AppConstant.MenuItems.Clientes, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);
    }

    #region Buttons
    private void btnSave_Click(object sender, EventArgs e)
    {
      if (IsReadyToSave())
      {
        try
        {
          string sqlForExecute;
          if (adding)
          {
            txtCodigo.Text = DataUtil.GetString(DataUtil.GetNewId(tableName));
            sqlForExecute = "INSERT INTO " + tableName + " (" +
                               formWhereField + "," +
                               "Cliente_apellidos," +
                               "Cliente_nombres," +
                               "Cliente_direccion," +
                               "Telefono_casa," +
                               "Telefono_celular," +
                               "Telefono_trabajo," +
                               "Documento," +
                               "Tipo_documento," +
                               "Comentario," +
                               "Email_principal," +
                               "Estado," +
                               "Fecha_creacion," +
                               "Creado_por," +
                               "Fecha_actualizacion," +
                               "Actualizado_por)" +
                         " VALUES (" +
                               txtCodigo.Text + "," +
                               "'" + txtApellidos.Text.Trim().Replace("'", "''") + "'," +
                               "'" + txtNombres.Text.Trim().Replace("'", "''") + "'," +
                               "'" + txtDireccion.Text.Trim() + "'," +
                               "'" + txtTelefono.Text.Trim() + "'," +
                               "'" + txtCelular.Text.Trim() + "'," +
                               "'" + txtTrabajo.Text.Trim() + "'," +
                               "'" + txtDocumento.Text.Trim() + "'," +
                               "'" + cbTipo.SelectedItem + "'," +
                               "'" + txtComentarios.Text.Trim() + "'," +
                               "'" + cbEmail.SelectedItem + "'," +
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
                        "Cliente_nombres = '" + txtNombres.Text.Trim().Replace("'", "''") + "'" +
                        ", Cliente_apellidos = '" + txtApellidos.Text.Trim().Replace("'", "''") + "'" +
                        ", Cliente_direccion = '" + txtDireccion.Text.Trim() + "'" +
                        ", Telefono_casa = '" + txtTelefono.Text.Trim() + "'" +
                        ", Telefono_celular = '" + txtCelular.Text.Trim() + "'" +
                        ", Telefono_trabajo = '" + txtTrabajo.Text.Trim() + "'" +
                        ", Email_principal = '" + cbEmail.SelectedItem + "'" +
                        ", Comentario = '" + txtComentarios.Text.Trim() + "'" +
                        ", Documento = '" + txtDocumento.Text.Trim() + "'" +
                        ", Tipo_documento = '" + cbTipo.SelectedItem + "'" +
                        ", Estado = '" + cbEstado.SelectedItem + "'" +
                        ", Fecha_actualizacion = '" + DateTime.Now + "'" +
                        ", Actualizado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                        " WHERE " + formWhereField + " = " + txtCodigo.Text;
          }

          if (DataUtil.Update(sqlForExecute))
          {
            MessageBox.Show(@"Registro grabado correctamente", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (adding)
            {
              if (CreateSpecial)
              {
                if (cbTipo.SelectedItem.Equals("RUC"))
                  AppConstant.Customer.ClienteNombre = txtApellidos.Text.Trim();
                else
                  AppConstant.Customer.ClienteNombre = txtApellidos.Text.Trim() + ", " + txtNombres.Text.Trim();
                AppConstant.Customer.ClienteCodigo = txtCodigo.Text;
                AppConstant.Customer.ClienteTelefono = txtTelefono.Text;
                AppConstant.Customer.ClienteDireccion = txtDireccion.Text;
                AppConstant.Customer.ClienteDocumento = txtDocumento.Text;
                AppConstant.Customer.ClienteTipoDocumento = cbTipo.SelectedItem.ToString();
              }

              Close();
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(@"Error en Grabar: " + ex.Message);
        }
      }
    }
    protected override void DeleteData()
    {
      idToDelete = txtCodigo.Text;
      base.DeleteData();
    }
    private void btnAddEmail_Click(object sender, EventArgs e)
    {
      string refValue = string.Empty;
      if (frmInputBox.InputBox("Agregar Email", "Email", "cliente_email", "email", formId, ref refValue, false, true) == DialogResult.OK)
      {
        DataUtil.FillComboBox(cbEmail.Items, DataBaseQuerys.FillMainDataSet("cliente_email", formWhereField, formId, "email"), null);
        cbEmail.SelectedItem = refValue;
      }
    }    
    #endregion

    #region Metodos Privados
    private void BindDataFields()
    {
      mainDataSet = DataUtil.FillDataSet(DataBaseQuerys.FillMainDataSet(tableName, formWhereField, formId, string.Empty), tableName);

      DataUtil.FillComboBox(cbEmail.Items, DataBaseQuerys.FillMainDataSet("cliente_email", formWhereField, formId, "email"), null);
      if (mainDataSet.Tables[0].Rows.Count > 0)
      {
        txtCodigo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], formWhereField);
        txtNombres.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "cliente_nombres");
        txtApellidos.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "cliente_apellidos");
        txtDireccion.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "cliente_direccion");
        txtTelefono.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Telefono_casa");
        txtCelular.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Telefono_celular");
        txtTrabajo.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Telefono_trabajo");
        txtDocumento.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Documento");
        txtComentarios.Text = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Comentario");
        cbEmail.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Email_principal");
        cbEstado.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "estado");
        cbTipo.SelectedItem = DataUtil.GetString(mainDataSet.Tables[0].Rows[0], "Tipo_documento");

        txtDocumento.Enabled = false;
        cbTipo.Enabled = false;
        cbTipo.SelectedItem = "RUC";
      }
      else
      {
        if (CreateSpecial)
        {
          txtTelefono.Text = ClienteNumeroTelefono;
          txtApellidos.Text = ClienteApellido;
          cbTipo.SelectedItem = "DNI";
          if (CustomerRUC)
          {
            cbTipo.SelectedItem = "RUC";
            cbTipo.Enabled = false;
          }            
        }
        cbEstado.SelectedItem = AppConstant.RegistroEstado.Activo;        
        btnAddEmail.Enabled = false;
        cbEmail.Enabled = false;
      }
    }
    private bool IsReadyToSave()
    {
      epApellidos.SetError(txtApellidos, string.Empty);
      epApellidos.SetError(txtDocumento, string.Empty);
      epNombres.SetError(txtNombres, string.Empty);
      epDireccion.SetError(txtDireccion, string.Empty);
      epTelefono.SetError(txtTelefono, string.Empty);
      var valueResult = true;
      if (txtApellidos.Text == string.Empty)
      {
          epApellidos.SetError(txtApellidos,
              cbTipo.SelectedItem.Equals("RUC")
                  ? "Por favor ingresar su Razon Social."
                  : "Por favor ingresar sus Apellidos.");
          valueResult = false;
      }        
      if (cbTipo.SelectedItem.Equals("RUC"))
      {
          if (txtDocumento.Text == string.Empty)
          {
              epApellidos.SetError(txtDocumento, "Por favor ingresar su RUC.");
              valueResult = false;
          }
          else if (!ValidarRuc(txtDocumento.Text.Trim()))
          {
              txtDocumento.Enabled = true;
              epRUC.SetError(txtDocumento, "RUC invalido.");
              valueResult = false;
          }                    
      }
      else
      {
        if (txtNombres.Text == string.Empty)
        {
          epNombres.SetError(txtNombres, "Por favor ingresar sus Nombres.");
          valueResult = false;
        }          
      }
      if (CreateSpecial)
      {
        if (txtDireccion.Text == string.Empty)
        {
          epDireccion.SetError(txtDireccion, "Por favor ingresar su Direccion.");
          valueResult = false;
        }          

        if (txtTelefono.Text == string.Empty)
        {
          epTelefono.SetError(txtTelefono, "Por favor ingresar su Telefono Fijo.");
          valueResult = false;
        }
      }
        if (!adding) return valueResult;
        if (VerificarDuplicados().Equals(false))
            valueResult = false;
        return valueResult;
    }

      public bool ValidarRuc(string ruc)
      {
          if (ruc.Length != 11)
          {
              epRUC.SetError(txtDocumento, "Numero de digitos del RUC es invalido.");
              return false;
          }

          var dig01 = Convert.ToInt32(ruc.Substring(0, 1)) * 5;
          var dig02 = Convert.ToInt32(ruc.Substring(1, 1)) * 4;
          var dig03 = Convert.ToInt32(ruc.Substring(2, 1)) * 3;
          var dig04 = Convert.ToInt32(ruc.Substring(3, 1)) * 2;
          var dig05 = Convert.ToInt32(ruc.Substring(4, 1)) * 7;
          var dig06 = Convert.ToInt32(ruc.Substring(5, 1)) * 6;
          var dig07 = Convert.ToInt32(ruc.Substring(6, 1)) * 5;
          var dig08 = Convert.ToInt32(ruc.Substring(7, 1)) * 4;
          var dig09 = Convert.ToInt32(ruc.Substring(8, 1)) * 3;
          var dig10 = Convert.ToInt32(ruc.Substring(9, 1)) * 2;
          var dig11 = Convert.ToInt32(ruc.Substring(10, 1));

          var suma = dig01 + dig02 + dig03 + dig04 + dig05 + dig06 + dig07 + dig08 + dig09 + dig10;
          var residuo = suma % 11;
          var resta = 11 - residuo;

          int digChk;
          switch (resta)
          {
              case 10:
                  digChk = 0;
                  break;
              case 11:
                  digChk = 1;
                  break;
              default:
                  digChk = resta;
                  break;
          }

          if (dig11 == digChk)
          {
              return true;
          }          
          return false;
      }

        private bool VerificarDuplicados()
    {
      if (txtDocumento.Text != string.Empty)
      {
        string sWhere = "Documento = '" + txtDocumento.Text + "'";
        if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
        {
          MessageBox.Show("El documento ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
      if (cbTipo.SelectedItem.Equals("RUC"))
      {
        if (txtApellidos.Text != string.Empty)
        {
          string sWhere = "Cliente_apellidos = '" + txtApellidos.Text.Replace("'", "''") + "'";
          if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
          {
            MessageBox.Show("La Razon Social ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
          }
        }
      }
      else
      {
        if (txtApellidos.Text != string.Empty && txtNombres.Text != string.Empty)
        {
          string sWhere = "Cliente_apellidos = '" + txtApellidos.Text.Replace("'", "''") + "' AND Cliente_nombres = '" + txtNombres.Text.Replace("'", "''") + "'";
          if (DataUtil.GetInt(DataUtil.FindSingleRow(tableName, "Count(*)", sWhere)) > 0)
          {
            MessageBox.Show("Los Applidos y Nombres ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
          }
        }
      }
      return true;
    }
    private string GotoKeyboard(string textIn)
    {
      string returnValue = string.Empty;
      AppConstant.Calculator.textIN = textIn;
      var frmKeyboardForm = new frmKeyboard();
      frmKeyboardForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        returnValue = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
      return returnValue;
    }
    protected override bool ExistRecord()
    {
      int recordCount = 0;
      recordCount = DataUtil.GetInt(DataUtil.FindSingleRow("venta", "Count(*)", "cliente_id = " + txtCodigo.Text + ""));
      recordCount = recordCount + DataUtil.GetInt(DataUtil.FindSingleRow("pedido", "Count(*)", "cliente_id = " + txtCodigo.Text + ""));
      if (recordCount > 0)
      {
        MessageBox.Show(@"No se puede borrar el cliente tiene ventas y ordenes asociadas.", @"Borrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      return true;
    }
    #endregion

    #region Eventos
    private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbTipo.SelectedItem.Equals("RUC"))
      {
        lblNombres.Visible = false;
        txtNombres.Visible = false;
        txtNombres.Text = string.Empty;
        lblTitulo.Text = @"Razon Social :";
      }
      else
      {
        lblNombres.Visible = true;
        txtNombres.Visible = true;
        lblTitulo.Text = @"Apellidos :";
      }
    }
    private void txtDocumento_DoubleClick(object sender, EventArgs e)
    {
      txtDocumento.Text = GotoKeyboard(string.Empty);
    }
    private void txtApellidos_DoubleClick(object sender, EventArgs e)
    {
      txtApellidos.Text = GotoKeyboard(string.Empty);
    }
    private void txtNombres_DoubleClick(object sender, EventArgs e)
    {
      txtNombres.Text = GotoKeyboard(string.Empty);
    }
    private void txtDireccion_DoubleClick(object sender, EventArgs e)
    {
      txtDireccion.Text = GotoKeyboard(string.Empty);
    }
    private void txtTelefono_DoubleClick(object sender, EventArgs e)
    {
      txtTelefono.Text = GotoKeyboard(string.Empty);
    }
    private void txtCelular_DoubleClick(object sender, EventArgs e)
    {
      txtCelular.Text = GotoKeyboard(string.Empty);
    }
    private void txtTrabajo_DoubleClick(object sender, EventArgs e)
    {
      txtTrabajo.Text = GotoKeyboard(string.Empty);
    }
    private void txtComentarios_DoubleClick(object sender, EventArgs e)
    {
      txtComentarios.Text = GotoKeyboard(string.Empty);
    }
    #endregion
  }
}
