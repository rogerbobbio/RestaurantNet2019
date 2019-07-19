using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using RestaurantNet.Common;

namespace RestaurantNet
{
    public sealed class DataUtil
    {
        public const int True = 1;
        public const int False = 0;

        private static OleDbConnection dbConnection;
        private static DataSet dbDataSet;
        private static OleDbDataAdapter dbDataAdapter;

        private static string CadenaConexion;
        private static string ArchivoDatos = string.Empty;

        public static string AppPath = string.Empty;
        public const string Integer = "#,##0";
        public static readonly string Double = string.Format("{0}.00", Integer);
        public static readonly string Amount = string.Format("{0};({1})", Double, Double);

        public static DataGridView dgvTemporal = null;

        public static bool ConnectDB()
        {
            ReadConfig();
            CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=password1234; Data Source=" +
                             ArchivoDatos;

            try
            {
                dbConnection = new OleDbConnection(CadenaConexion);
                dbConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("RestaurantNet.mdb") || e.Message.Contains("Disk or network"))
                    MessageBox.Show(@"No se pudo encontrar la ubicacion de la base de datos.", @"Base de Datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(@"Error al crear la conexión: " + e.Message, @"Conexión", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return false;
            }
        }

        public static void DisconectDB()
        {
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
        }

        public static DataSet FillDataSet(string commandString, string nombreTabla)
        {
            if (dbConnection == null)
                ConnectDB();

            try
            {
                dbDataSet = new DataSet();
                dbDataAdapter = new OleDbDataAdapter(commandString, dbConnection);
                dbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                dbDataAdapter.Fill(dbDataSet, nombreTabla);
                return dbDataSet;
            }
            catch (Exception ex)
            {
                var frmShowError = new frmShowError {MensajeError = ex.Message, SentenciaError = commandString};
                frmShowError.ShowDialog();
                return null;
            }
        }

        public static int GetNewId(string tableName)
        {
            int result = 0;
            string sqlUpdate;
            DataSet dsNewId = FillDataSet("SELECT ultimo_valor FROM secuencia WHERE nombre_tabla = '" + tableName + "'",
                tableName);
            if (dsNewId.Tables[0].Rows.Count.Equals(1))
            {
                result = GetInt(dsNewId.Tables[0].Rows[0], "ultimo_valor") + 1;
                sqlUpdate = "UPDATE secuencia SET ultimo_valor = " + result + " WHERE nombre_tabla = '" + tableName +
                            "'";
                Update(sqlUpdate);
            }
            else if (dsNewId.Tables[0].Rows.Count.Equals(0))
            {
                sqlUpdate = "INSERT INTO secuencia (ultimo_valor, nombre_tabla) VALUES ('1','" + tableName + "')";
                Update(sqlUpdate);
                result = 1;
            }
            return result;
        }

        public static int GetOrderByTurn(int turnoId)
        {
            int result = 0;
            string sqlUpdate = string.Empty;
            DataSet dsNewID = FillDataSet("SELECT Orden FROM turno WHERE Turno_id = " + turnoId + "", "turno");
            if (dsNewID.Tables[0].Rows.Count.Equals(1))
            {
                result = GetInt(dsNewID.Tables[0].Rows[0], "Orden") + 1;
                sqlUpdate = "UPDATE turno SET Orden = " + result + " WHERE Turno_id = " + turnoId + "";
                Update(sqlUpdate);
            }
            return result;
        }

        public static bool Update(string commandString)
        {
            try
            {
                var cmd = new OleDbCommand(commandString, dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                var frmShowError = new frmShowError {MensajeError = ex.Message, SentenciaError = commandString};
                frmShowError.ShowDialog();
                return false;
            }
        }

        public static void UpdateThrow(string commandString)
        {
            try
            {
                var cmd = new OleDbCommand(commandString, dbConnection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                var frmShowError = new frmShowError {MensajeError = ex.Message, SentenciaError = commandString};
                frmShowError.ShowDialog();
                throw;
            }
        }

        public static string FindSingleRow(string table, string field, string sWhere)
        {
            string sSql;

            if (sWhere != string.Empty)
                sSql = "SELECT " + field + " FROM " + table + " WHERE " + sWhere;
            else
                sSql = "SELECT " + field + " FROM " + table;

            var command = new OleDbCommand(sSql, dbConnection);
            OleDbDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
            string valueReturn;

            if (reader.Read())
            {
                valueReturn = GetString(reader[0]);
                if (valueReturn == null)
                    valueReturn = string.Empty;
            }
            else
                valueReturn = string.Empty;

            reader.Close();
            return valueReturn;
        }

        public static int GetInt(object obj)
        {
            //return (int)GetValue(obj, (int)0);
            return ConvertUtil.ChangeTypeSafe<int>(obj);
        }

        public static int GetInt(DataRow drowCur, string colName)
        {
            return GetInt(drowCur[colName]);
        }

        public static object GetIntNull(object value)
        {
            //return GetValueNull(GetInt(value), (int)0);
            return ConvertUtil.DbNullIfDefault(GetInt(value));
        }

        public static bool GetBool(object obj)
        {
            //return (bool)GetValue(GetBool(Convert.ToString(obj)), false);
            return ConvertUtil.ChangeTypeSafe<bool>(GetBool(ConvertUtil.ChangeTypeSafe<string>(obj)));
        }

        public static bool GetBool(DataRow drowCur, string colName)
        {
            return DataUtil.GetString(drowCur[colName]) == "0" ? false : true;
        }

        public static string GetBoolString(bool value)
        {
            return value ? DataUtil.TrueString : DataUtil.FalseString;
        }

        public static string GetString(object obj)
        {
            return ConvertUtil.ChangeTypeSafe<string>(obj) ?? string.Empty;
        }

        public static string GetString(DataRow drowCur, string colName)
        {
            return GetString(drowCur[colName]).ToUpper();
        }

        public static object GetStringNull(object value)
        {
            return ConvertUtil.DbNullIf(GetString(value), string.Empty);
        }

        public static double GetDouble(object obj)
        {
            //return (double)GetValue(obj, (double)0);
            return ConvertUtil.ChangeTypeSafe<double>(obj);
        }

        public static double GetDouble(DataRow drowCur, string colName)
        {
            return GetDouble(drowCur[colName]);
        }

        public static object GetDoubleNull(object value)
        {
            //return GetValueNull(GetDouble(value), (double)0);
            return ConvertUtil.DbNullIfDefault(GetDouble(value));
        }

        public static decimal GetDecimal(object obj)
        {
            //return (decimal)GetValue(obj, decimal.Zero);
            return ConvertUtil.ChangeTypeSafe<decimal>(obj);
        }

        public static decimal GetDecimal(DataRow drowCur, string colName)
        {
            return (decimal) GetDecimal(drowCur[colName]);
        }

        public static object GetDecimalNull(object value)
        {
            //return GetValueNull(GetDecimal(value), decimal.Zero);
            return ConvertUtil.DbNullIfDefault(GetDecimal(value));
        }

        public static DateTime GetDateTime(object obj)
        {
            return ConvertUtil.ChangeTypeSafe<DateTime>(obj);
        }

        public static DateTime GetDateTime(DataRow drowCur, string colName)
        {
            return GetDateTime(drowCur[colName]);
        }

        public static object GetDateTimeNull(object value)
        {
            //return GetValueNull(GetDateTime(value), DefaultDateTime);
            return ConvertUtil.DbNullIfDefault(GetDateTime(value));
        }

        public static string GetCurrency(object obj)
        {
            return (ConvertUtil.ChangeTypeSafe<string>(obj) ?? string.Empty).Trim().Replace(",", ".");
        }

        private const int Millon = 1000000;
        private const long Billon = 1000000000000;

        public static string Enletras(decimal num)
        {
            var entero = Convert.ToInt64(Math.Truncate(num));
            var decimales = Convert.ToInt32(Math.Round((num - entero) * 100, 2));
            var dec = decimales > 0 ? $" CON {decimales}/100" : " CON 00/100";

            var res = ToText(entero) + dec;
            return res;
        }

        private static string ToText(decimal value)
        {
            string num2Text;
            value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = $"DIECI{ToText(value - 10)}";
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = $"VEINTI{ToText(value - 20)}";
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = $"{ToText(Math.Truncate(value / 10) * 10)} Y {ToText(value % 10)}";
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = $"CIENTO {ToText(value - 100)}";
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800))
                num2Text =
                    $"{ToText(Math.Truncate(value / 100))}CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = $"{ToText(Math.Truncate(value / 100) * 100)} {ToText(value % 100)}";
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = $"MIL {ToText(value % 1000)}";
            else if (value < Millon)
            {
                num2Text = $"{ToText(Math.Truncate(value / 1000))} MIL";
                if ((value % 1000) > 0) num2Text = $"{num2Text} {ToText(value % 1000)}";
            }

            else if (value == Millon) num2Text = "UN MILLON";
            else if (value < 2000000) num2Text = $"UN MILLON {ToText(value % Millon)}";
            else if (value < Billon)
            {
                num2Text = $"{ToText(Math.Truncate(value / Millon))} MILLONES ";
                if ((value - Math.Truncate(value / Millon) * Millon) > 0)
                    num2Text =
                        $"{num2Text} {ToText(value - Math.Truncate(value / Millon) * Millon)}";
            }

            else if (value == Billon) num2Text = "UN BILLON";
            else if (value < 2000000000000)
                num2Text =
                    $"UN BILLON {ToText(value - Math.Truncate(value / Billon) * Billon)}";

            else
            {
                num2Text = $"{ToText(Math.Truncate(value / Billon))} BILLONES";
                if ((value - Math.Truncate(value / Billon) * Billon) > 0)
                    num2Text =
                        $"{num2Text} {ToText(value - Math.Truncate(value / Billon) * Billon)}";
            }
            return num2Text;

        }


        public static readonly string TrueString = True.ToString();
        public static readonly string FalseString = False.ToString();

        public static void FillComboBox(ComboBox.ObjectCollection Items, string commandString,
            string CustomInitialDisplayValue)
        {
            Items.Clear();
            OleDbCommand command = new OleDbCommand(commandString, dbConnection);
            OleDbDataReader reader = command.ExecuteReader();

            if (CustomInitialDisplayValue != null)
                Items.Add(CustomInitialDisplayValue);

            while (reader.Read())
                Items.Add(GetString(reader[0]));

            reader.Close();
        }

        public static void FillComboBoxValues(ComboBox.ObjectCollection Items, string commandString,
            string CustomInitialDisplayValue)
        {
            Items.Clear();
            OleDbCommand command = new OleDbCommand(commandString, dbConnection);
            OleDbDataReader reader = command.ExecuteReader();

            if (CustomInitialDisplayValue != null)
                Items.Add(CustomInitialDisplayValue);

            while (reader.Read())
            {
                ListItem newListItem = new ListItem();
                newListItem.Text = reader.GetString(0);
                newListItem.Value = reader.GetInt32(1).ToString();
                Items.Add(newListItem);
            }

            reader.Close();
        }

        public static void FillComboBoxValuesInt(ComboBox.ObjectCollection Items, string commandString,
            string CustomInitialDisplayValue)
        {
            Items.Clear();
            OleDbCommand command = new OleDbCommand(commandString, dbConnection);
            OleDbDataReader reader = command.ExecuteReader();

            if (CustomInitialDisplayValue != null)
                Items.Add(CustomInitialDisplayValue);

            while (reader.Read())
            {
                ListItem newListItem = new ListItem();
                newListItem.Text = reader.GetInt32(0).ToString();
                newListItem.Value = reader.GetInt32(1).ToString();
                Items.Add(newListItem);
            }

            reader.Close();
        }

        public static class Format
        {
            public const string Integer = "#,##0";
            public static readonly string Decimals = string.Format("{0}.00", Integer);
        }

        static void ReadConfig()
        {
            Properties.Settings set = Properties.Settings.Default;
            //ArchivoDatos = AppPath + "\\" + set.DataBaseSetting;
            ArchivoDatos = set.DataBaseSetting;
        }

        public static void GetGeneralInfo()
        {
            try
            {
                DataSet dsConfig = FillDataSet("SELECT * FROM configuracion_general", "configuracion_general");

                if (dsConfig.Tables[0].Rows.Count > 0)
                {
                    AppConstant.GeneralInfo.Compania = GetString(dsConfig.Tables[0].Rows[0], "Nombre_compania");
                    AppConstant.GeneralInfo.RUC = GetString(dsConfig.Tables[0].Rows[0], "Documento_compania");
                    AppConstant.GeneralInfo.Direccion = GetString(dsConfig.Tables[0].Rows[0], "Direccion_compania");
                    AppConstant.GeneralInfo.Logo = GetString(dsConfig.Tables[0].Rows[0], "Ruta_logo_compania");
                    AppConstant.GeneralInfo.Telefono = GetString(dsConfig.Tables[0].Rows[0], "Telefono1_compania");
                    AppConstant.GeneralInfo.Fax = GetString(dsConfig.Tables[0].Rows[0], "Telefono2_compania");
                    AppConstant.GeneralInfo.Mobile = GetString(dsConfig.Tables[0].Rows[0], "Telefono3_compania");
                    AppConstant.GeneralInfo.Email = GetString(dsConfig.Tables[0].Rows[0], "Email_compania");
                    AppConstant.GeneralInfo.Web = GetString(dsConfig.Tables[0].Rows[0], "Web_compania");
                    AppConstant.GeneralInfo.IGV = GetString(dsConfig.Tables[0].Rows[0], "IGV");
                    AppConstant.GeneralInfo.Mensaje1 = GetString(dsConfig.Tables[0].Rows[0], "Mensaje_recibo_1");
                    AppConstant.GeneralInfo.Mensaje2 = GetString(dsConfig.Tables[0].Rows[0], "Mensaje_recibo_2");
                    AppConstant.GeneralInfo.Mensaje3 = GetString(dsConfig.Tables[0].Rows[0], "Mensaje_recibo_3");
                    AppConstant.GeneralInfo.MontoCaja = GetString(dsConfig.Tables[0].Rows[0], "Monto_caja");
                    AppConstant.GeneralInfo.PasswordAnulaciones = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_Anulaciones");
                    AppConstant.GeneralInfo.PasswordNotaVenta = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_NotaVenta");
                    AppConstant.GeneralInfo.PasswordDividirCuentas = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_DividirCuenta");
                    AppConstant.GeneralInfo.PasswordCambioMesero = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_CambioMesero");
                    AppConstant.GeneralInfo.PasswordReimpresiones = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_ReImpresiones");
                    AppConstant.GeneralInfo.PasswordCambioMesa = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_CambioMesa");
                    AppConstant.GeneralInfo.PasswordSalir = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_Salir");
                    AppConstant.GeneralInfo.PasswordEliminarProducto = GetBool(dsConfig.Tables[0].Rows[0], "Contrasena_EliminarProducto");
                    AppConstant.GeneralInfo.MostrarIGVBoleta = GetBool(dsConfig.Tables[0].Rows[0], "Mostrar_IGV_Boleta");
                    AppConstant.GeneralInfo.AlegraUsuario = GetString(dsConfig.Tables[0].Rows[0], "Alegra_Usuario");
                    AppConstant.GeneralInfo.AlegraToken = GetString(dsConfig.Tables[0].Rows[0], "Alegra_Token");
                    AppConstant.ProductButtonSelected.ProductoId = string.Empty;
                    AppConstant.ProductButtonSelected.ProductoDescripcion = string.Empty;
                    AppConstant.ProductButtonSelected.PrecioFinal = string.Empty;
                    AppConstant.ProductButtonSelected.PrecioProveedor = string.Empty;
                }

                DataSet dsImpresoraBar = FillDataSet("SELECT * FROM Impresora WHERE tipo = 'B'", "Impresora");
                if (dsImpresoraBar.Tables[0].Rows.Count > 0)
                {
                    AppConstant.GeneralInfo.Impresora.Bar = GetString(dsImpresoraBar.Tables[0].Rows[0], "Ruta");
                    AppConstant.GeneralInfo.Preview.Bar = GetBool(dsImpresoraBar.Tables[0].Rows[0], "Preview");
                    AppConstant.GeneralInfo.FontHeader.Bar = GetString(dsImpresoraBar.Tables[0].Rows[0], "Font_header");
                    AppConstant.GeneralInfo.FontDetail.Bar = GetString(dsImpresoraBar.Tables[0].Rows[0], "Font_detail");
                    AppConstant.GeneralInfo.PrintText.Bar = GetBool(dsImpresoraBar.Tables[0].Rows[0], "Texto");
                }
                DataSet dsImpresoraCocina = FillDataSet("SELECT * FROM Impresora WHERE tipo = 'C'", "Impresora");
                if (dsImpresoraCocina.Tables[0].Rows.Count > 0)
                {
                    AppConstant.GeneralInfo.Impresora.Cocina = GetString(dsImpresoraCocina.Tables[0].Rows[0], "Ruta");
                    AppConstant.GeneralInfo.Preview.Cocina = GetBool(dsImpresoraCocina.Tables[0].Rows[0], "Preview");
                    AppConstant.GeneralInfo.FontHeader.Cocina =
                        GetString(dsImpresoraCocina.Tables[0].Rows[0], "Font_header");
                    AppConstant.GeneralInfo.FontDetail.Cocina =
                        GetString(dsImpresoraCocina.Tables[0].Rows[0], "Font_detail");
                    AppConstant.GeneralInfo.PrintText.Cocina = GetBool(dsImpresoraCocina.Tables[0].Rows[0], "Texto");
                }
                DataSet dsImpresoraBoleta = FillDataSet("SELECT * FROM Impresora WHERE tipo = 'L'", "Impresora");
                if (dsImpresoraBoleta.Tables[0].Rows.Count > 0)
                {
                    AppConstant.GeneralInfo.Impresora.Boleta = GetString(dsImpresoraBoleta.Tables[0].Rows[0], "Ruta");
                    AppConstant.GeneralInfo.Preview.Boleta = GetBool(dsImpresoraBoleta.Tables[0].Rows[0], "Preview");
                    AppConstant.GeneralInfo.FontHeader.Boleta =
                        GetString(dsImpresoraBoleta.Tables[0].Rows[0], "Font_header");
                    AppConstant.GeneralInfo.FontDetail.Boleta =
                        GetString(dsImpresoraBoleta.Tables[0].Rows[0], "Font_detail");
                }

                DataSet dsImpresoraRecibos = FillDataSet("SELECT * FROM Impresora WHERE tipo = 'R'", "Impresora");
                if (dsImpresoraRecibos.Tables[0].Rows.Count > 0)
                {
                    AppConstant.GeneralInfo.Impresora.Recibos = GetString(dsImpresoraRecibos.Tables[0].Rows[0], "Ruta");
                    AppConstant.GeneralInfo.Preview.Recibos = GetBool(dsImpresoraRecibos.Tables[0].Rows[0], "Preview");
                    AppConstant.GeneralInfo.FontHeader.Recibos =
                        GetString(dsImpresoraRecibos.Tables[0].Rows[0], "Font_header");
                    AppConstant.GeneralInfo.FontDetail.Recibos =
                        GetString(dsImpresoraRecibos.Tables[0].Rows[0], "Font_detail");
                }

                DataSet dsImpresoraReportes = FillDataSet("SELECT * FROM Impresora WHERE tipo = 'P'", "Impresora");
                if (dsImpresoraReportes.Tables[0].Rows.Count > 0)
                {
                    AppConstant.GeneralInfo.Impresora.Reportes =
                        GetString(dsImpresoraReportes.Tables[0].Rows[0], "Ruta");
                    AppConstant.GeneralInfo.Preview.Reportes =
                        GetBool(dsImpresoraReportes.Tables[0].Rows[0], "Preview");
                    AppConstant.GeneralInfo.FontHeader.Reportes =
                        GetString(dsImpresoraReportes.Tables[0].Rows[0], "Font_header");
                    AppConstant.GeneralInfo.FontDetail.Reportes =
                        GetString(dsImpresoraReportes.Tables[0].Rows[0], "Font_detail");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(@"Error al obtener los valores de la tabla configuracion general: " + err.Message);
            }
        }

        public static void GetTurnInfo(int turnoId)
        {
            DataSet dsConfig = null;
            if (turnoId.Equals(0))
                dsConfig = DataUtil.FillDataSet(DataBaseQuerys.Turno(0, 0, false), "turno");
            else
                dsConfig = DataUtil.FillDataSet(DataBaseQuerys.Turno(turnoId, 0, false), "turno");

            if (dsConfig.Tables[0].Rows.Count > 0)
            {
                AppConstant.Turno.Codigo = DataUtil.GetString(dsConfig.Tables[0].Rows[0], "Turno_id");
                AppConstant.Turno.FechaHora = DataUtil.GetString(dsConfig.Tables[0].Rows[0], "Fecha_apertura");
                AppConstant.Turno.Estado = DataUtil.GetString(dsConfig.Tables[0].Rows[0], "Estado");
            }
            else
            {
                AppConstant.Turno.Codigo = string.Empty;
                AppConstant.Turno.FechaHora = string.Empty;
                AppConstant.Turno.Estado = string.Empty;
            }
        }
    }
}
