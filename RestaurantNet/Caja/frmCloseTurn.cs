using RestaurantNet.Reports;
using System;
using System.Data;
using System.Windows.Forms;

namespace RestaurantNet
{
    public partial class frmCloseTurn : frmMain
    {
        public int TurnoIDValue = 0;
        private double _montoDeposito;
        private double _montoRetiro;

        public frmCloseTurn()
        {
            InitializeComponent();
        }
        private void frmCloseTurn_Load(object sender, EventArgs e)
        {
            DataUtil.Update("DELETE FROM reporte_turno");
            GetTurnInfo();
            int turnoID = DataUtil.GetInt(lblTurno.Text);
            CargarTurnoEstacion(turnoID);
            CargarTurnoOrdenesPagadas(turnoID);
            CargarInformacionExtra(turnoID);
            CargarGastos(turnoID);
            CargarProductos(turnoID);

            if (TurnoIDValue != 0)
            {
                lblTurnoLabel.Text = @"Turno Cerrado:";
                btnCerrarTurno.Visible = false;
            }

            txtVentaTotal.Text = txtDetalleTotal.Text;
            txtBalance.Text = DataUtil.GetString(DataUtil.GetDouble(txtFondoInicialTotal.Text) + DataUtil.GetDouble(txtDetalleTotal.Text) + _montoDeposito - _montoRetiro);
            InsertarValoresReporte("Venta Total", txtVentaTotal.Text);
            InsertarValoresReporte("Balance de Cajas", txtBalance.Text);
        }

      private void CargarProductos(int turnoId)
      {        
        var sqlCommand = "SELECT vd.Descripcion_Producto AS Descripcion," +
                         "       SUM(vd.Cantidad) AS Cantidad" +
                         " FROM (venta AS v LEFT JOIN venta_detalle AS vd ON v.venta_id = vd.venta_id)" +
                         " WHERE v.turno_id = " + turnoId + "" +
                         " GROUP BY vd.Descripcion_Producto" +
                         " ORDER BY 2 DESC";

        var dsProductosInfo = DataUtil.FillDataSet(sqlCommand, "venta_detalle");
        foreach (DataRow productoRow in dsProductosInfo.Tables["venta_detalle"].Rows)
        {
          InsertarValoresReporte(DataUtil.GetString(productoRow["Descripcion"]),
                                 DataUtil.GetString(productoRow["Cantidad"]));          
        }        
        InsertarValoresReporte(string.Empty, string.Empty);
      }

      private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Desea cerrar el turno actual?", @"Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sqlForExecute;
                foreach (DataGridViewRow row in dgwEstaciones.Rows)
                {
                    sqlForExecute = "INSERT INTO Turno_Cierre (" +
                                     "Turno_Cierre_id," +
                                     "Turno_id," +
                                     "Estacion_id," +
                                     "Estacion_texto," +
                                     "Grid," +
                                     "Descripcion," +
                                     "Cantidad," +
                                     "Importe)" +
                                    " VALUES (" +
                                     DataUtil.GetString(DataUtil.GetNewId("Turno_Cierre")) + "," +
                                     lblTurno.Text + "," +
                                     "" + DataUtil.GetString(row.Cells[0].Value) + "," +
                                     "'" + DataUtil.GetString(row.Cells[1].Value) + "'," +
                                     "'dgwEstaciones'," +
                                     "'" + DataUtil.GetString(row.Cells[1].Value).Replace("'", "''") + "'," +
                                     "0," +
                                     "" + DataUtil.GetCurrency(row.Cells[2].Value) + "" +
                                     ")";
                    DataUtil.UpdateThrow(sqlForExecute);
                }

                foreach (DataGridViewRow row in dgwCuentas.Rows)
                {
                    sqlForExecute = "INSERT INTO Turno_Cierre (" +
                                     "Turno_Cierre_id," +
                                     "Turno_id," +
                                     "Estacion_id," +
                                     "Estacion_texto," +
                                     "Grid," +
                                     "Descripcion," +
                                     "Cantidad," +
                                     "Importe)" +
                                    " VALUES (" +
                                     DataUtil.GetString(DataUtil.GetNewId("Turno_Cierre")) + "," +
                                     lblTurno.Text + "," +
                                     "" + DataUtil.GetString(row.Cells[4].Value) + "," +
                                     "'" + DataUtil.GetString(row.Cells[0].Value) + "'," +
                                     "'dgwCuentas'," +
                                     "'" + DataUtil.GetString(row.Cells[1].Value).Replace("'", "''") + "'," +
                                     "" + DataUtil.GetString(row.Cells[2].Value) + "," +
                                     "" + DataUtil.GetCurrency(row.Cells[3].Value) + "" +
                                     ")";
                    DataUtil.UpdateThrow(sqlForExecute);
                }

                foreach (DataGridViewRow row in dgwMovimientos.Rows)
                {
                    sqlForExecute = "INSERT INTO Turno_Cierre (" +
                                     "Turno_Cierre_id," +
                                     "Turno_id," +
                                     "Estacion_id," +
                                     "Estacion_texto," +
                                     "Grid," +
                                     "Descripcion," +
                                     "Cantidad," +
                                     "Importe)" +
                                    " VALUES (" +
                                     DataUtil.GetString(DataUtil.GetNewId("Turno_Cierre")) + "," +
                                     lblTurno.Text + "," +
                                     "" + DataUtil.GetString(row.Cells[4].Value) + "," +
                                     "'" + DataUtil.GetString(row.Cells[0].Value) + "'," +
                                     "'dgwMovimientos'," +
                                     "'" + DataUtil.GetString(row.Cells[1].Value).Replace("'", "''") + "'," +
                                     "" + DataUtil.GetString(row.Cells[2].Value) + "," +
                                     "" + DataUtil.GetCurrency(row.Cells[3].Value) + "" +
                                     ")";
                    DataUtil.UpdateThrow(sqlForExecute);
                }

                foreach (DataGridViewRow row in dgwExtra.Rows)
                {
                    sqlForExecute = "INSERT INTO Turno_Cierre (" +
                                     "Turno_Cierre_id," +
                                     "Turno_id," +
                                     "Estacion_id," +
                                     "Estacion_texto," +
                                     "Grid," +
                                     "Descripcion," +
                                     "Cantidad," +
                                     "Importe)" +
                                    " VALUES (" +
                                     DataUtil.GetString(DataUtil.GetNewId("Turno_Cierre")) + "," +
                                     lblTurno.Text + "," +
                                     "null," +
                                     "''," +
                                     "'dgwExtra'," +
                                     "'" + DataUtil.GetString(row.Cells[0].Value).Replace("'", "''") + "'," +
                                     "" + DataUtil.GetString(row.Cells[1].Value) + "," +
                                     "0" +
                                     ")";
                    DataUtil.UpdateThrow(sqlForExecute);
                }

                sqlForExecute = "UPDATE turno SET " +
                                "Estado = 'CERRADO'" +
                                ", Fecha_cierre = '" + DateTime.Now + "'" +
                                ", Cerrado_por = '" + AppConstant.EmployeeInfo.Codigo + "'" +
                                ", Venta_total = '" + txtVentaTotal.Text + "'" +
                                " WHERE Turno_id = " + lblTurno.Text;
                DataUtil.UpdateThrow(sqlForExecute);

                ImprimirReporteTurno();

                MessageBox.Show(@"Turno cerrado correctamente", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AppConstant.Turno.Codigo = string.Empty;
                AppConstant.Turno.FechaHora = string.Empty;
                AppConstant.Turno.Estado = string.Empty;
                Close();
            }
        }
        private void btnVerProductosVendidos_Click(object sender, EventArgs e)
        {
          var frmTurnProductForm = new frmTurnProduct {TurnoId = Convert.ToInt32(lblTurno.Text)};
          frmTurnProductForm.ShowDialog();
        }

        private void GetTurnInfo()
        {
            if (TurnoIDValue == 0)
            {
                if (AppConstant.Turno.Codigo != string.Empty)
                {
                    lblTurno.Text = AppConstant.Turno.Codigo;
                    lblTurnoFecha.Text = AppConstant.Turno.FechaHora;
                }
                else
                {
                    lblTurno.Text = string.Empty;
                    lblTurnoFecha.Text = string.Empty;
                }
            }
            else
            {
                DataSet dsConfig = DataUtil.FillDataSet(DataBaseQuerys.Turno(TurnoIDValue, 0, true), "turno");

                if (dsConfig.Tables[0].Rows.Count > 0)
                {
                    lblTurno.Text = DataUtil.GetString(dsConfig.Tables[0].Rows[0], "Turno_id");
                    lblTurnoFecha.Text = DataUtil.GetString(dsConfig.Tables[0].Rows[0], "Fecha_apertura");
                    lblCierreLabel.Visible = true;
                    lblCierreValue.Visible = true;
                    lblCierreValue.Text = DataUtil.GetString(dsConfig.Tables[0].Rows[0], "Fecha_cierre");
                }
                else
                {
                    lblTurno.Text = string.Empty;
                    lblTurnoFecha.Text = string.Empty;
                }
            }
        }
        private void CargarTurnoEstacion(int turnoId)
        {
            decimal montoInicial = 0;
            string sqlCommand = "SELECT turno_estacion.*, Estacion.Estacion_descripcion FROM Estacion INNER JOIN turno_estacion ON Estacion.Estacion_id = turno_estacion.Estacion_id WHERE turno_id = " + turnoId + " order by Linea";
            var dsTurnoEstacionInfo = DataUtil.FillDataSet(sqlCommand, "turno_estacion");
            foreach (DataRow turnoEstacionRow in dsTurnoEstacionInfo.Tables["turno_estacion"].Rows)
            {
                string[] row = {DataUtil.GetString(turnoEstacionRow["Estacion_id"]),
                        DataUtil.GetString(turnoEstacionRow["Estacion_Descripcion"]),
                        DataUtil.GetString(turnoEstacionRow["Fondo_inicial"])
                       };                
                dgwEstaciones.Rows.Add(row);
                InsertarValoresReporte(DataUtil.GetString(turnoEstacionRow["Estacion_Descripcion"]), DataUtil.GetString(turnoEstacionRow["Fondo_inicial"]));
                montoInicial = montoInicial + DataUtil.GetDecimal(turnoEstacionRow["Fondo_inicial"]);
            }
            txtFondoInicialTotal.Text = montoInicial.ToString(DataUtil.Format.Decimals);
            InsertarValoresReporte("Fondo Inicial Total:", montoInicial.ToString(DataUtil.Format.Decimals));
            InsertarValoresReporte(string.Empty, string.Empty);
        }
        private void CargarTurnoOrdenesPagadas(int turnoId)
        {
            decimal montoTotal = 0;
            DataSet dsVentaInfo = DataUtil.FillDataSet("SELECT v.tipo_pago," +
                                                       "       e.Estacion_descripcion," +
                                                       "       e.estacion_id," +
                                                       "       count(*) AS numero," +
                                                       "       SUM(v.Monto_total) AS total" +
                                                       " FROM (venta AS v LEFT JOIN estacion AS e ON v.estacion_id = e.estacion_id)" +
                                                       " WHERE v.turno_id = " + turnoId + "" +
                                                       " GROUP BY v.tipo_pago, e.Estacion_descripcion, e.estacion_id" +
                                                       " ORDER BY e.estacion_id", "venta");
            foreach (DataRow ventaRow in dsVentaInfo.Tables["venta"].Rows)
            {
                string[] row = {DataUtil.GetString(ventaRow["Estacion_descripcion"]),
                                DataUtil.GetString(ventaRow["tipo_pago"]),
                                DataUtil.GetString(ventaRow["numero"]),
                                DataUtil.GetString(ventaRow["total"]),
                                DataUtil.GetString(ventaRow["estacion_id"])};
                dgwCuentas.Rows.Add(row);
                string descripcion = DataUtil.GetString(ventaRow["Estacion_descripcion"]) + "/" +
                                     DataUtil.GetString(ventaRow["tipo_pago"]) + " = " +
                                     DataUtil.GetString(ventaRow["numero"]);
                InsertarValoresReporte(descripcion, DataUtil.GetString(ventaRow["total"]));
                montoTotal = montoTotal + DataUtil.GetDecimal(ventaRow["total"]);
            }
            txtDetalleTotal.Text = montoTotal.ToString(DataUtil.Format.Decimals);
            InsertarValoresReporte("Detalle de Ordenes Total:", montoTotal.ToString(DataUtil.Format.Decimals));
            InsertarValoresReporte(string.Empty, string.Empty);
        }
        private void CargarGastos(int turnoId)
        {
            decimal montoTotal = 0;
            var dsMovimientoInfo = DataUtil.FillDataSet("SELECT v.tipo_movimiento," +
                                                       "       e.Estacion_descripcion," +
                                                       "       e.estacion_id," +
                                                       "       count(*) AS numero," +
                                                       "       SUM(v.Importe) AS total" +
                                                       " FROM (movimientos AS v LEFT JOIN estacion AS e ON v.estacion_id = e.estacion_id)" +
                                                       " WHERE v.turno_id = " + turnoId + "" +
                                                       " GROUP BY v.tipo_movimiento, e.Estacion_descripcion, e.estacion_id" +
                                                       " ORDER BY e.estacion_id", "movimientos");
            foreach (DataRow movimientoRow in dsMovimientoInfo.Tables["movimientos"].Rows)
            {
                string[] row = {DataUtil.GetString(movimientoRow["Estacion_descripcion"]),
                                DataUtil.GetString(movimientoRow["tipo_movimiento"]),
                                DataUtil.GetString(movimientoRow["numero"]),
                                DataUtil.GetString(movimientoRow["total"]),
                                DataUtil.GetString(movimientoRow["estacion_id"])};
                if (DataUtil.GetString(movimientoRow["tipo_movimiento"]) == AppConstant.TipoMovimiento.Deposito)
                    _montoDeposito = _montoDeposito + DataUtil.GetDouble(movimientoRow["total"]);

                if (DataUtil.GetString(movimientoRow["tipo_movimiento"]) == AppConstant.TipoMovimiento.Retiro)
                    _montoRetiro = _montoRetiro + DataUtil.GetDouble(movimientoRow["total"]);

                dgwMovimientos.Rows.Add(row);
                string descripcion = DataUtil.GetString(movimientoRow["Estacion_descripcion"]) + "/" +
                                     DataUtil.GetString(movimientoRow["tipo_movimiento"]) + " = " +
                                     DataUtil.GetString(movimientoRow["numero"]);
                InsertarValoresReporte(descripcion, DataUtil.GetString(movimientoRow["total"]));
                montoTotal = montoTotal + DataUtil.GetDecimal(movimientoRow["total"]);
            }
            txtMovimientosTotal.Text = montoTotal.ToString(DataUtil.Format.Decimals);
            InsertarValoresReporte("Gastos e Ingresos Total:", montoTotal.ToString(DataUtil.Format.Decimals));
            InsertarValoresReporte(string.Empty, string.Empty);
        }
        private void CargarInformacionExtra(int turnoId)
        {
            DataSet dsVentaExtraInfo = DataUtil.FillDataSet("SELECT v.venta_documento_tipo," +
                                                            "       count(*) AS numero" +
                                                            " FROM (venta AS v)" +
                                                            " WHERE v.turno_id = " + turnoId + "" +
                                                            " GROUP BY v.venta_documento_tipo" +
                                                            " ORDER BY v.venta_documento_tipo", "venta");
            foreach (DataRow ventaRow in dsVentaExtraInfo.Tables["venta"].Rows)
            {
                string[] row = {DataUtil.GetString(ventaRow["venta_documento_tipo"]),
                                DataUtil.GetString(ventaRow["numero"])};
                dgwExtra.Rows.Add(row);
                InsertarValoresReporte(DataUtil.GetString(ventaRow["venta_documento_tipo"]), DataUtil.GetString(ventaRow["numero"]));
            }

            dsVentaExtraInfo = DataUtil.FillDataSet("SELECT v.tipo_venta," +
                                                    "       count(*) AS numero" +
                                                    " FROM (venta AS v)" +
                                                    " WHERE v.turno_id = " + turnoId + "" +
                                                    " GROUP BY v.tipo_venta" +
                                                    " ORDER BY v.tipo_venta", "venta");
            foreach (DataRow ventaRow in dsVentaExtraInfo.Tables["venta"].Rows)
            {
                string[] row = {DataUtil.GetString(ventaRow["tipo_venta"]),
                                DataUtil.GetString(ventaRow["numero"])};
                dgwExtra.Rows.Add(row);
                InsertarValoresReporte(DataUtil.GetString(ventaRow["tipo_venta"]), DataUtil.GetString(ventaRow["numero"]));
            }

            dsVentaExtraInfo = DataUtil.FillDataSet("SELECT e.estado_descripcion," +
                                                    "       count(*) AS numero" +
                                                    " FROM (pedido AS v LEFT JOIN pedido_estado AS e ON v.estado = e.pedido_estado)" +
                                                    " WHERE v.turno_id = " + turnoId + " AND estado <> 'F'" +
                                                    " GROUP BY e.estado_descripcion" +
                                                    " ORDER BY e.estado_descripcion", "pedido");
            foreach (DataRow ventaRow in dsVentaExtraInfo.Tables["pedido"].Rows)
            {
                string[] row = {DataUtil.GetString(ventaRow["estado_descripcion"]),
                                DataUtil.GetString(ventaRow["numero"])};
                dgwExtra.Rows.Add(row);
                InsertarValoresReporte(DataUtil.GetString(ventaRow["estado_descripcion"]), DataUtil.GetString(ventaRow["numero"]));
            }
            InsertarValoresReporte(string.Empty, string.Empty);
            InsertarValoresReporte(string.Empty, string.Empty);
        }
        private void InsertarValoresReporte(string descripcion, string valor)
        {
          string sqlForExecute = "INSERT INTO Reporte_Turno (" +
                                 "Descripcion," +
                                 "Valor," +
                                 "Turno_id)" +
                                 " VALUES (" +
                                 "'" + descripcion + "'," +
                                 "'" + valor + "'," +
                                 "" + lblTurno.Text + "" +
                                 ")";
          DataUtil.Update(sqlForExecute);
        }
        private void ImprimirReporteTurno()
        {
          var dsResult = DataUtil.FillDataSet("SELECT * FROM reporte_turno", "reporte_turno");
          var reportViewerForm = new ReportViewer
          {
            dsReport = dsResult,
            reporteName = AppConstant.Reportes.Turno,
            tableNameReport = "reporte_turno",
            printerName = AppConstant.GeneralInfo.Impresora.Recibos,
          };
          reportViewerForm.ShowDialog();          
        }        
    }
}
