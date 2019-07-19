using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace RestaurantNet
{
  public partial class frmQuickButtonsConfig : frmMain
  {
    private int categoriaIdSelected = 0;
    private string categoriaTextSelected = string.Empty;
    private int subCategoriaIdSelected = 0;
    private string subCategoriaTextSelected = string.Empty;

    private int defaultCategoriaId = 2; // Platos principales
    private string defaultCategoriaText = "PLATOS PRINC";

    public bool productoPedido = false;

    public frmQuickButtonsConfig()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmQuickButtonsConfig_Load(object sender, EventArgs e)
    {
      if (productoPedido)
        this.Text = "Productos (Botones)";
      CategoriasCarouselDataBinding_Load();
      SubCategoriasCarouselDataBinding_Load(defaultCategoriaId);
    }

    #region QuickButtons
    private void btnProductoNormal_Click(object sender, EventArgs e)
    {
      SetButtonInfo("NORMAL", sender, e);
    }
    private void btnAdicionales_Click(object sender, EventArgs e)
    {
      SetButtonInfo("ADICIONAL", sender, e);
    }
    private void SetButtonInfo(string tipo, object sender, EventArgs e)
    {
      if (sender is Button)
      {
        Button btn = sender as Button;
                
        DataSet dsBoton = DataUtil.FillDataSet(DataBaseQuerys.ProductoBoton(DataUtil.GetString(btn.Tag), DataUtil.GetString(subCategoriaIdSelected)), "producto_boton");
        if (dsBoton.Tables[0].Rows.Count.Equals(1))
        {
          if (!productoPedido)
          {
            frmQuickButtons frmQuickButtonsForm = new frmQuickButtons();
            frmQuickButtonsForm.categoriaId = categoriaIdSelected.ToString();
            frmQuickButtonsForm.subCategoriaId = subCategoriaIdSelected.ToString();
            frmQuickButtonsForm.botonId = DataUtil.GetString(btn.Tag);
            frmQuickButtonsForm.tipo = tipo;
            frmQuickButtonsForm.adding = false;
            frmQuickButtonsForm.ShowDialog();
            GetButtonInfo(btn, subCategoriaIdSelected);
          }
          else
          {            
            DataSet dsProducto = DataUtil.FillDataSet(DataBaseQuerys.Producto(DataUtil.GetString(dsBoton.Tables[0].Rows[0], "Producto_id"),
                                                                              string.Empty,
                                                                              string.Empty,
                                                                              string.Empty), "producto");
            AppConstant.ProductButtonSelected.ProductoId = DataUtil.GetString(dsBoton.Tables[0].Rows[0], "Producto_id");
            AppConstant.ProductButtonSelected.ProductoDescripcion = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Producto_descripcion");
            AppConstant.ProductButtonSelected.PrecioFinal = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_final");
            AppConstant.ProductButtonSelected.PrecioProveedor = DataUtil.GetString(dsProducto.Tables[0].Rows[0], "Precio_proveedor");
            this.Close();
          }
        }
        else if (dsBoton.Tables[0].Rows.Count.Equals(0))
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
        boton.Text = "PRODUCTO";
        boton.Image = null;
        boton.BackColor = Color.Transparent;
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

          if (categoriaTextSelected == string.Empty)
            categoriaTextSelected = defaultCategoriaText;

          tpProductos.Text = categoriaTextSelected + " (" + subCategoriaTextSelected + ")";
          tpAdicionales.Text = "ADICIONALES (" + subCategoriaTextSelected + ")";

          LoadButtons(tpProductos, subCategoriaID);
          LoadButtons(tpAdicionales, subCategoriaID);
        }
      }
    }
    #endregion

    #region CategoriasCarousel
    public class CategoriasFeatures
    {
      public CategoriasFeatures(int id, string name)
      {
        _id = id;
        _name = name;
      }
      private int _id;
      public int ID
      {
        get { return _id; }
        set { _id = value; }
      }
      private string _name;
      public string Name
      {
        get { return _name; }
        set { _name = value; }
      }
    }
    private void CategoriasCarouselDataBinding_Load()
    {
      rcCategorias.ItemDataBound += new ItemDataBoundEventHandler(rcCategorias_ItemDataBound);
      rcCategorias.NewCarouselItemCreating += new NewCarouselItemCreatingEventHandler(rcCategorias_NewCarouselItemCreating);      

      // Create a generic list of Feature objects and bind it
      List<CategoriasFeatures> products = new List<CategoriasFeatures>();

      DataSet dsCategorias = DataUtil.FillDataSet(DataBaseQuerys.ProductoCategoriaActivos(true), "producto_categoria");
      if (dsCategorias.Tables["producto_categoria"].Rows.Count > 0)
      {
        foreach (DataRow categoriaRow in dsCategorias.Tables["producto_categoria"].Rows)
        {
          string categoriaDesc = DataUtil.GetString(categoriaRow["Producto_categoria_descripcion"]);
          if (categoriaDesc.Length > 12)
            categoriaDesc = categoriaDesc.Remove(12);
          int categoriaID = DataUtil.GetInt(categoriaRow["Producto_categoria_id"]);
          products.Add(new CategoriasFeatures(categoriaID, categoriaDesc));
        }
      }      
      rcCategorias.DataSource = products;
    }
    void CategoriasCarouselDataBinding_Click(object sender, EventArgs e)
    {
      categoriaTextSelected = (sender as RadButtonElement).Text.ToString();
      SubCategoriasCarouselDataBinding_Load(DataUtil.GetInt((sender as RadButtonElement).Tag));
    }
    private void rcCategorias_ItemDataBound(object sender, Telerik.WinControls.UI.ItemDataBoundEventArgs e)
    {
      if (e.DataBoundItem is RadButtonElement)
      {
        RadButtonElement button = (e.DataBoundItem as RadButtonElement);
        button.Text = (e.DataItem as CategoriasFeatures).Name;
        button.Tag = (e.DataItem as CategoriasFeatures).ID;
        button.Font = new Font("Arial", 15);
        button.Click += new EventHandler(CategoriasCarouselDataBinding_Click);
      }
    }
    private void rcCategorias_NewCarouselItemCreating(object sender, Telerik.WinControls.UI.NewCarouselItemCreatingEventArgs e)
    {
      e.NewCarouselItem = new RadButtonElement();
    }
    #endregion

    #region SubCategoriasCarousel
    public class SubCategoriasFeatures
    {
      public SubCategoriasFeatures(int id, string name)
      {
        _id = id;
        _name = name;
      }
      private int _id;
      public int ID
      {
        get { return _id; }
        set { _id = value; }
      }
      private string _name;
      public string Name
      {
        get { return _name; }
        set { _name = value; }
      }
    }
    private void SubCategoriasCarouselDataBinding_Load(int categoriaID)
    {      
      if (categoriaID != 0)
      {
        if (categoriaIdSelected != categoriaID)
        {
          tcAdicionales.Visible = false;
          tcProductos.Visible = false;
          categoriaIdSelected = categoriaID;
          rcSubCategorias.ItemDataBound += new ItemDataBoundEventHandler(rcSubCategorias_ItemDataBound);
          rcSubCategorias.NewCarouselItemCreating += new NewCarouselItemCreatingEventHandler(rcSubCategorias_NewCarouselItemCreating);

          // Create a generic list of Feature objects and bind it
          List<SubCategoriasFeatures> sub_products = new List<SubCategoriasFeatures>();
          
          DataSet dsSubCategorias = DataUtil.FillDataSet(DataBaseQuerys.ProductoSubCategoriaActivos(true, categoriaID.ToString()), "producto_sub_categoria");
          if (dsSubCategorias.Tables["producto_sub_categoria"].Rows.Count > 0)
          {
            foreach (DataRow subCategoriaRow in dsSubCategorias.Tables["producto_sub_categoria"].Rows)
            {
              string subCategoriaDesc = DataUtil.GetString(subCategoriaRow["Producto_sub_categoria_descripcion"]);
              if (subCategoriaDesc.Length > 12)
                subCategoriaDesc = subCategoriaDesc.Remove(12);
              int subCategoriaID = DataUtil.GetInt(subCategoriaRow["Producto_sub_categoria_id"]);
              sub_products.Add(new SubCategoriasFeatures(subCategoriaID, subCategoriaDesc));
            }
          }
          rcSubCategorias.DataSource = sub_products;
        }
      }
    }
    void SubCategoriasCarouselDataBinding_Click(object sender, EventArgs e)
    {
      subCategoriaTextSelected = (sender as RadButtonElement).Text.ToString();
      GetSubCategoriaProducts(DataUtil.GetInt((sender as RadButtonElement).Tag));      
    }
    private void rcSubCategorias_ItemDataBound(object sender, ItemDataBoundEventArgs e)
    {
      if (e.DataBoundItem is RadButtonElement)
      {
        RadButtonElement button = (e.DataBoundItem as RadButtonElement);
        button.Text = (e.DataItem as SubCategoriasFeatures).Name;
        button.Tag = (e.DataItem as SubCategoriasFeatures).ID;
        button.Font = new Font("Arial", 15);
        button.Click += new EventHandler(SubCategoriasCarouselDataBinding_Click);
      }
    }
    private void rcSubCategorias_NewCarouselItemCreating(object sender, NewCarouselItemCreatingEventArgs e)
    {
      e.NewCarouselItem = new RadButtonElement();
    }    
    #endregion    
  }
}
