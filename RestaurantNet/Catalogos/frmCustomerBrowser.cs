using System;

namespace RestaurantNet
{
  public partial class frmCustomerBrowser : frmMainBrowser
  {
    public frmCustomerBrowser()
    {
      InitializeComponent();
    }
    private void frmCustomerBrowser_Load(object sender, EventArgs e)
    {
      btnAdd.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Clientes, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Nuevo);
      btnModify.Visible = DataBaseQuerys.GetAccess(AppConstant.MenuItems.Clientes, AppConstant.EmployeeInfo.Codigo, AppConstant.AccessoTipos.Edicion);

      selectSQL = "c.cliente_id AS Codigo, " +
                  "c.Tipo_documento AS [Tipo documento], " +
                  "c.Documento, " +
                  "IIf(c.Tipo_documento='RUC',c.cliente_apellidos,c.cliente_apellidos+', '+c.cliente_nombres) AS Cliente," +
                  "c.Cliente_direccion AS Direccion, " +
                  "c.Telefono_casa AS [Telefono fijo], " +
                  "c.Telefono_celular AS Celular, " +
                  "c.Telefono_trabajo AS [Telefono trabajo], " +
                  "c.Email_principal AS [Email Principal]," +
                  "c.Comentario, " +
                  "c.Fecha_creacion AS [Fecha creacion], " +
                  "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                  "c.Fecha_actualizacion AS [Fecha actualizacion]," +
                  "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por]";
      tablesJoinsBrowser = "(cliente AS c LEFT JOIN empleado AS cr ON c.creado_por=cr.codigo_empleado)"+
                           "  LEFT JOIN empleado AS up ON c.actualizado_por=up.codigo_empleado";
      stringBrowserSQL = "SELECT " + selectSQL +
                         "  FROM " + tablesJoinsBrowser +
                         "  ORDER BY c.cliente_apellidos";
      tableNameBrowser = "cliente";
      formTitle = "Lista de clientes";
      searchVisible = true;
      BindDataGrid();
      OnLoad();
    }
  }
}
