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
  public partial class frmTakeOrder : Form
  {
    #region Constant
    private int lineGrid = 0;

    private int maxCategorias = 9;
    private int maxSubCategorias = 20;

    private int categoriaIdSelected = 0;
    private int subCategoriaIdSelected = 0;
    private string categoriaTextSelected = string.Empty;
    private string subCategoriaTextSelected = string.Empty;

    private int gridLineaNumero = 0;
    private int gridProdCodigo = 1;
    private int gridProdDescripcion = 2;
    private int gridCantidad = 3;
    #endregion

    public frmTakeOrder()
    {
      InitializeComponent();
    }

    private void frmTakeOrder_Load(object sender, EventArgs e)
    {
      CargarCategorias();
    }
    private void CargarCategorias()
    {
      DataSet dsCategorias = DataUtil.FillDataSet("SELECT TOP " + maxCategorias + " * FROM producto_categoria ORDER BY Producto_categoria_id", "producto_categoria");
      int rowCount = dsCategorias.Tables["producto_categoria"].Rows.Count;
      if (rowCount == maxCategorias)
        btnSiguienteCategoria.Enabled = true;
      if (rowCount > 0)
      {
        int countButton = 1;
        foreach (DataRow categoriaRow in dsCategorias.Tables["producto_categoria"].Rows)
        {          
          string categoriaDesc = DataUtil.GetString(categoriaRow["Producto_categoria_descripcion"]);
          int categoriaID = DataUtil.GetInt(categoriaRow["Producto_categoria_id"]);

          if (countButton == 1) SetButton(btnCategotia1, categoriaID, categoriaDesc);
          if (countButton == 2) SetButton(btnCategotia2, categoriaID, categoriaDesc);
          if (countButton == 3) SetButton(btnCategotia3, categoriaID, categoriaDesc);
          if (countButton == 4) SetButton(btnCategotia4, categoriaID, categoriaDesc);
          if (countButton == 5) SetButton(btnCategotia5, categoriaID, categoriaDesc);
          if (countButton == 6) SetButton(btnCategotia6, categoriaID, categoriaDesc);
          if (countButton == 7) SetButton(btnCategotia7, categoriaID, categoriaDesc);
          if (countButton == 8) SetButton(btnCategotia8, categoriaID, categoriaDesc);
          if (countButton == 9) SetButton(btnCategotia9, categoriaID, categoriaDesc);

          countButton++;
        }
        //ADICIONAL
        if (countButton == 1) SetButton(btnCategotia1, 0, "ADICIONAL");
        if (countButton == 2) SetButton(btnCategotia2, 0, "ADICIONAL");
        if (countButton == 3) SetButton(btnCategotia3, 0, "ADICIONAL");
        if (countButton == 4) SetButton(btnCategotia4, 0, "ADICIONAL");
        if (countButton == 5) SetButton(btnCategotia5, 0, "ADICIONAL");
        if (countButton == 6) SetButton(btnCategotia6, 0, "ADICIONAL");
        if (countButton == 7) SetButton(btnCategotia7, 0, "ADICIONAL");
        if (countButton == 8) SetButton(btnCategotia8, 0, "ADICIONAL");
        if (countButton == 9) SetButton(btnCategotia9, 0, "ADICIONAL");
      }
    }
    private void CargarSubCategorias(int productoCategoriaID)
    {
      if (productoCategoriaID != 0)
      {
        if (categoriaIdSelected != productoCategoriaID)
        {
          categoriaIdSelected = productoCategoriaID;

          LimpiarTabPage(tabPageSubCategorias, false, false);
          string sqlCommand = "SELECT TOP " + maxSubCategorias + " * FROM producto_sub_categoria WHERE Producto_categoria_id = " + productoCategoriaID + " ORDER BY Producto_sub_categoria_id";
          DataSet dsSubCategorias = DataUtil.FillDataSet(sqlCommand, "producto_sub_categoria");
          int rowCount = dsSubCategorias.Tables["producto_sub_categoria"].Rows.Count;
          if (rowCount == maxSubCategorias)
            btnSiguienteSubCategoria.Enabled = true;
          if (rowCount > 0)
          {
            int countButton = 1;
            foreach (DataRow subCategoriaRow in dsSubCategorias.Tables["producto_sub_categoria"].Rows)
            {
              string subCategoriaDesc = DataUtil.GetString(subCategoriaRow["Producto_sub_categoria_descripcion"]);
              int subCategoriaID = DataUtil.GetInt(subCategoriaRow["Producto_sub_categoria_id"]);

              if (countButton == 1) SetButton(btnSubCategotia1, subCategoriaID, subCategoriaDesc);
              if (countButton == 2) SetButton(btnSubCategotia2, subCategoriaID, subCategoriaDesc);
              if (countButton == 3) SetButton(btnSubCategotia3, subCategoriaID, subCategoriaDesc);
              if (countButton == 4) SetButton(btnSubCategotia4, subCategoriaID, subCategoriaDesc);
              if (countButton == 5) SetButton(btnSubCategotia5, subCategoriaID, subCategoriaDesc);
              if (countButton == 6) SetButton(btnSubCategotia6, subCategoriaID, subCategoriaDesc);
              if (countButton == 7) SetButton(btnSubCategotia7, subCategoriaID, subCategoriaDesc);
              if (countButton == 8) SetButton(btnSubCategotia8, subCategoriaID, subCategoriaDesc);
              if (countButton == 9) SetButton(btnSubCategotia9, subCategoriaID, subCategoriaDesc);
              if (countButton == 10) SetButton(btnSubCategotia10, subCategoriaID, subCategoriaDesc);
              if (countButton == 11) SetButton(btnSubCategotia11, subCategoriaID, subCategoriaDesc);
              if (countButton == 12) SetButton(btnSubCategotia12, subCategoriaID, subCategoriaDesc);
              if (countButton == 13) SetButton(btnSubCategotia13, subCategoriaID, subCategoriaDesc);
              if (countButton == 14) SetButton(btnSubCategotia14, subCategoriaID, subCategoriaDesc);
              if (countButton == 15) SetButton(btnSubCategotia15, subCategoriaID, subCategoriaDesc);
              if (countButton == 16) SetButton(btnSubCategotia16, subCategoriaID, subCategoriaDesc);
              if (countButton == 17) SetButton(btnSubCategotia17, subCategoriaID, subCategoriaDesc);
              if (countButton == 18) SetButton(btnSubCategotia18, subCategoriaID, subCategoriaDesc);
              if (countButton == 19) SetButton(btnSubCategotia19, subCategoriaID, subCategoriaDesc);
              if (countButton == 20) SetButton(btnSubCategotia20, subCategoriaID, subCategoriaDesc);

              countButton++;
            }
          }
        }
      }
    }
    private void SetButton(Button button, int categoriaID, string categoriaDesc)
    {
      if (DataUtil.GetString(button.Tag) == string.Empty)
      {
        button.Tag = categoriaID;
        button.Text = categoriaDesc;
        button.Visible = true;
      }
    }
    private void LimpiarTabPage(Control tabPage, bool incluyeSeleccionado, bool isProduct)
    {
      foreach (Control button in tabPage.Controls)
      {
        if (button is Button)
        {
          Button boton = button as Button;
          if (boton.Text != "ANTERIOR" && boton.Text != "SIGUIENTE")
          {
            if (incluyeSeleccionado)
              boton.BackColor = Color.Transparent;
            else
            {
              if (!isProduct)              
                boton.Tag = string.Empty;
              boton.Text = string.Empty;              
              boton.Visible = false;
              boton.BackColor = Color.Transparent;
            }
          }
        }
      }
    }
    private void GetSubCategoriaProducts(int subCategoriaID)
    {
      if (subCategoriaID != 0)
      {
        if (subCategoriaIdSelected != subCategoriaID)
        {
          subCategoriaIdSelected = subCategoriaID;
          tcAdicionales.Visible = true;
          tcProductos.Visible = true;

          tpProductos.Text = categoriaTextSelected + " (" + subCategoriaTextSelected + ")";
          tpAdicionales.Text = "ADICIONALES (" + subCategoriaTextSelected + ")";

          LoadButtons(tpProductos, subCategoriaID);
          LoadButtons(tpAdicionales, subCategoriaID);
        }
      }
    }
    private void LoadButtons(Control tabs, int productoSubCategoriaID)
    {
      foreach (Control button in tabs.Controls)
      {
        if (button is Button)
        {
          Button boton = button as Button;

          if (boton.Tag != null)
            GetButtonInfo(boton, productoSubCategoriaID);
        }
      }
    }
    private void GetButtonInfo(Button boton, int productoSubCategoriaID)
    {      
      DataSet dsMesaInfo = DataUtil.FillDataSet(DataBaseQuerys.ProductoBoton(DataUtil.GetString(boton.Tag), DataUtil.GetString(productoSubCategoriaID)), "producto_boton");
      if (dsMesaInfo.Tables[0].Rows.Count > 0)
      {
        boton.Visible = true;
        boton.Text = DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Boton_descripcion");
        boton.BackColor = Color.LightSteelBlue;
        try
        {
          if (DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Boton_ruta_imagen") != string.Empty)
            boton.Image = Image.FromFile(DataUtil.GetString(dsMesaInfo.Tables[0].Rows[0], "Boton_ruta_imagen"));
          else
            boton.Image = null;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al cargar imagen: " + ex.Message);
        }
      }
      else
      {
        boton.Visible = true;
        boton.Text = "PRODUCTO";
        boton.Image = null;
        boton.BackColor = Color.Transparent;
      }
    }
    private void SetButtonInfo(string tipo, object sender, EventArgs e)
    {
      if (sender is Button)
      {
        Button btn = sender as Button;        
        DataSet dsBoton = DataUtil.FillDataSet(DataBaseQuerys.ProductoBoton(DataUtil.GetString(btn.Tag), DataUtil.GetString(subCategoriaIdSelected)), "producto_boton");
        if (dsBoton.Tables[0].Rows.Count.Equals(0))
        {
          DialogResult result = MessageBox.Show("Desea asignar un producto al boton?", "Asignar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            frmQuickButtons frmQuickButtonsForm = new frmQuickButtons();
            frmQuickButtonsForm.categoriaId = categoriaIdSelected.ToString();
            frmQuickButtonsForm.subCategoriaId = subCategoriaIdSelected.ToString();
            frmQuickButtonsForm.botonId = DataUtil.GetString(btn.Tag);
            frmQuickButtonsForm.tipo = tipo;
            frmQuickButtonsForm.ShowDialog();
            GetButtonInfo(btn, subCategoriaIdSelected);
          }
        }
        else
        {
          DataSet dsProducto = DataUtil.FillDataSet(DataBaseQuerys.Producto(DataUtil.GetString(dsBoton.Tables[0].Rows[0], "Producto_id"), string.Empty, string.Empty, string.Empty), "producto");
          txtCodigoProducto.Text = DataUtil.GetString(dsBoton.Tables[0].Rows[0], "Producto_id");
          txtProducto.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Producto_descripcion");
          txtPrecioUnitario.Text = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_final");
          this.btnAdd_Click(tipo, null);
        }
      }
    }
    private bool ExistRecord(string codigoProductoGrid, int cantidadGrid)
    {
      bool existe = false;

      foreach (DataGridViewRow row in dgwOrden.Rows)
      {
        string codigoProducto = DataUtil.GetString(row.Cells[gridProdCodigo].Value);
        int cantidadProducto = DataUtil.GetInt(row.Cells[gridCantidad].Value);

        if (codigoProducto == codigoProductoGrid)
        {
          row.Cells[gridCantidad].Value = cantidadProducto + cantidadGrid;
          existe = true;
        }
      }
      return existe;
    }

    private void btnCategoria_Click(object sender, EventArgs e)
    {
      LimpiarTabPage(tabPageCategorias, true, false);
      LimpiarTabPage(tpProductos, false, true);
      LimpiarTabPage(tpAdicionales, false, true);
      Button btn = sender as Button;
      if (btn.Text != "ADICIONAL")
      {
          categoriaTextSelected = btn.Text;
          btn.BackColor = Color.LightSteelBlue;
          CargarSubCategorias(DataUtil.GetInt(btn.Tag));
      }
      else
      {

      }
    }
    private void btnSubCategoria_Click(object sender, EventArgs e)
    {
      LimpiarTabPage(tabPageSubCategorias, true, false);
      Button btn = sender as Button;
      subCategoriaTextSelected = btn.Text;
      btn.BackColor = Color.LightSteelBlue;
      GetSubCategoriaProducts(DataUtil.GetInt(btn.Tag));
    }

    private void btnAdicional_Click(object sender, EventArgs e)
    {
      SetButtonInfo("ADICIONAL", sender, e);
    }
    private void btnNormal_Click(object sender, EventArgs e)
    {
      SetButtonInfo("NORMAL", sender, e);
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (txtCantidad.Text.Trim() != string.Empty && txtProducto.Text.Trim() != string.Empty)
      {
        if (DataUtil.GetInt(txtCantidad.Text) >= 0)
          txtCantidad.Text = "1";

        bool isExiste = false;
        if (sender.ToString() != "ADICIONAL")
          isExiste = ExistRecord(txtCodigoProducto.Text, DataUtil.GetInt(txtCantidad.Text));

        if (!isExiste)
        {
          lineGrid = lineGrid + 1;
          string[] row = {DataUtil.GetString(lineGrid),
                        txtCodigoProducto.Text,
                        txtProducto.Text,
                        txtCantidad.Text,
                       };
          dgwOrden.Rows.Add(row);

          txtCodigoProducto.Text = string.Empty;
          txtProducto.Text = string.Empty;
          txtCantidad.Text = "1";
          txtPrecioUnitario.Text = string.Empty;
        }
      }
      else      
        MessageBox.Show("Debe ingresar el Producto y la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);      
    }

    #region Cantidad
    private void txtCantidad_DoubleClick(object sender, EventArgs e)
    {
      txtCantidad.Text = GoToCalculator(string.Empty);
    }
    private string GoToCalculator(string textIn)
    {
      string returnValue = string.Empty;
      AppConstant.Calculator.textIN = textIn;
      frmCalculator frmCalculatorForm = new frmCalculator();
      frmCalculatorForm.ShowDialog();
      if (AppConstant.Calculator.textOUT != string.Empty)
        returnValue = AppConstant.Calculator.textOUT;

      AppConstant.Calculator.textIN = string.Empty;
      AppConstant.Calculator.textOUT = string.Empty;
      return returnValue;
    }
    #endregion

    private void btnExit_Click(object sender, EventArgs e)
    {
      if (this.dgwOrden.RowCount > 0)
      {
        DialogResult result = MessageBox.Show("Desea proceder a agregar estos productos a la orden?", "Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
          DataUtil.dgvTemporal = this.dgwOrden;
          this.Close();
        }
      }
      else
        this.Close();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (isRecordSelected())
      {
        DialogResult diagResult = MessageBox.Show("Está seguro de eliminar la linea seleccionada?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (diagResult == DialogResult.Yes)
        {
          DataGridViewSelectedRowCollection Seleccionados = dgwOrden.SelectedRows;
          foreach (DataGridViewRow item in Seleccionados)          
            this.dgwOrden.Rows.RemoveAt(item.Index);                      
        }
      }
      else
        MessageBox.Show("Seleccione una linea de la grilla", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private bool isRecordSelected()
    {
      bool result = false;
      DataGridViewSelectedRowCollection Seleccionados = dgwOrden.SelectedRows;
      foreach (DataGridViewRow item in Seleccionados)
        result = true;
      return result;
    }
  }
}
