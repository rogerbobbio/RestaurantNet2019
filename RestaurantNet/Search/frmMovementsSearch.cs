using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace RestaurantNet
{
  public partial class frmMovementsSearch : frmMain
  {
    public frmMovementsSearch()
    {
      InitializeComponent();
      IniTurnoCombo();
    }   
    private void frmMovementsSearch_Load(object sender, EventArgs e)
    {
      FillTurnoCombo();
      FillEstacionCombo();
      FillGrid();
    }
    
    private void IniTurnoCombo()
    {
      this.radmccbTurno.AutoSizeDropDownToBestFit = true;
      RadMultiColumnComboBoxElement multiColumnComboElement = this.radmccbTurno.MultiColumnComboBoxElement;
      multiColumnComboElement.DropDownSizingMode = SizingMode.UpDownAndRightBottom;
      //multiColumnComboElement.DropDownMinSize = new Size(420, 300);
      multiColumnComboElement.EditorControl.MasterGridViewTemplate.AutoGenerateColumns = false;
      GridViewTextBoxColumn column = new GridViewTextBoxColumn("Turno_id");
      column.HeaderText = "Turno Code";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_apertura");
      column.HeaderText = "Fecha Apertura";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Fecha_cierre");
      column.HeaderText = "Fecha Cierre";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Estado");
      column.HeaderText = "Estado";
      multiColumnComboElement.Columns.Add(column);
      column = new GridViewTextBoxColumn("Turno_Desc");
      column.HeaderText = "Turno Descripcion";
      column.IsVisible = false;
      multiColumnComboElement.Columns.Add(column);
    }
    private void FillTurnoCombo()
    {
      DataSet dsResult = DataUtil.FillDataSet("SELECT Turno_id, Fecha_apertura, Fecha_cierre, Estado, LTrim((Str(Turno_id))+ ' - ' +Format(Fecha_apertura , 'Short Date')) AS Turno_Desc FROM turno ORDER BY fecha_apertura DESC", "turno");
      this.radmccbTurno.DataSource = dsResult.Tables[0];
      this.radmccbTurno.DisplayMember = "Turno_Desc";
      // Filtering START
      FilterExpression filter = new FilterExpression(this.radmccbTurno.DisplayMember,
                                                     FilterExpression.BinaryOperation.AND,
                                                     GridKnownFunction.StartsWith,
                                                     GridFilterCellElement.ParameterName);
      filter.Parameters.Add(GridFilterCellElement.ParameterName, string.Empty);
      this.radmccbTurno.EditorControl.MasterGridViewTemplate.FilterExpressions.Add(filter);
      this.radmccbTurno.MultiColumnComboBoxElement.AutoCompleteMode = AutoCompleteMode.None;
      this.radmccbTurno.DropDownStyle = RadDropDownStyle.DropDown;
      // Filtering END
      this.radmccbTurno.SelectedItem = null;
    }
    private void FillEstacionCombo()
    {
      DataUtil.FillComboBoxValues(cbEstacion.Items, "SELECT Estacion_descripcion, Estacion_id FROM Estacion ORDER BY Estacion_descripcion", string.Empty);
      cbEstacion.Text = string.Empty;
    }
    private string BuildWhere()
    {     
      string searchWhere = string.Empty;
      if (radmccbTurno.Text != string.Empty)
        searchWhere = searchWhere + " AND m.Turno_id = " + radmccbTurno.EditorControl.Rows[radmccbTurno.SelectedIndex].Cells["Turno_id"].Value + "";

      if (cbEstacion.Text != string.Empty)
        searchWhere = searchWhere + " AND m.Estacion_id = " + ((System.Web.UI.WebControls.ListItem)(cbEstacion.SelectedItem)).Value + "";

      if (cbTipoMovimiento.Text != string.Empty)
        searchWhere = " AND m.Tipo_movimiento = '" + cbTipoMovimiento.Text.Trim() + "'";      
      
      return searchWhere;
    }
    private void FillGrid()
    {
      string commandSQL = string.Empty;
      double importe = 0;
      this.dgwResult.Rows.Clear();

      commandSQL = "SELECT t.Turno_id AS [Turno Code], e.Estacion_descripcion AS [Estacion], m.Tipo_movimiento AS [Tipo Movimiento], m.Concepto, m.Importe, m.Fecha_Creacion AS [Realizado el] " +
                   "  FROM (movimientos AS m LEFT JOIN turno AS t ON m.turno_id=t.turno_id) " +
                   "  LEFT JOIN estacion AS e ON m.estacion_id=e.estacion_id WHERE movimiento_id <> 0 " + BuildWhere() + " ORDER BY Movimiento_id";

      DataSet dsMovimientosInfo = DataUtil.FillDataSet(commandSQL, "movimientos");
      foreach (DataRow movimientosRow in dsMovimientosInfo.Tables["movimientos"].Rows)
      {
        importe = importe + DataUtil.GetDouble(movimientosRow["Importe"]);
        string[] row = {DataUtil.GetString(movimientosRow["Turno Code"]),
                        DataUtil.GetString(movimientosRow["Estacion"]),
                        DataUtil.GetString(movimientosRow["Tipo Movimiento"]),
                        DataUtil.GetString(movimientosRow["Concepto"]),
                        DataUtil.GetString(movimientosRow["Importe"]),
                        DataUtil.GetString(movimientosRow["Realizado el"])
                       };
        dgwResult.Rows.Add(row);
      }
      txtTotal.Text = importe.ToString(DataUtil.Format.Decimals);
      lblNo.Text = DataUtil.GetString(dsMovimientosInfo.Tables[0].Rows.Count);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnSearch_Click(object sender, EventArgs e)
    {
      FillGrid();
    }
    private void btnClean_Click(object sender, EventArgs e)
    {
      radmccbTurno.Text = string.Empty;
      cbEstacion.Text = string.Empty;
      FillGrid();
    }    
  }
}
