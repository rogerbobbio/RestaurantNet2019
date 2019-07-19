using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;

namespace RestaurantNet.Seguridad
{
  public partial class frmSecurityPermissions : frmMain
  {
    public frmSecurityPermissions()
    {
      InitializeComponent();
    }

    private void BindDataFields()
    {
      DataUtil.FillComboBoxValues(cbEmpleado.Items, "SELECT Apellidos_empleado + ', ' + Nombres_empleado AS Nombre, Codigo_empleado FROM empleado ORDER BY Apellidos_empleado", null);
    }

    private void frmSecurityPermissions_Load(object sender, System.EventArgs e)
    {
      BindDataFields();
      SetDefaultValues(false);
    }

    private void btnClose_Click(object sender, System.EventArgs e)
    {      
      Close();
    }

    private void SetDefaultValues(bool value)
    {
          cbBotonesProducto.Checked = value;
          cbMesa.Checked = value;
          cbConfiguracionSistema.Checked = value;
          cbReiniciarSistema.Checked = value;
          cbCambiarContrasena.Checked = value;
          cbPermisos.Checked = value;          
          cbEmpleadosEdicion.Checked = value;
          cbEmpleadosNuevo.Checked = value;
          cbEmpleados.Checked = value;
          cbCorteCaja.Checked = value;
          cbMonitorVentas.Checked = value;
          cbMovimientosNuevo.Checked = value;
          cbMovimientos.Checked = value;
          cbTurnosCerrar.Checked = value;
          cbTurnosAbir.Checked = value;
          cbTurnos.Checked = value;         
          cbEstacionesEdicion.Checked = value;
          cbEstacionesNuevo.Checked = value;
          cbEstaciones.Checked = value;          
          cbProveedoresEdicion.Checked = value;
          cbProveedoresNuevo.Checked = value;
          cbProveedores.Checked = value;          
          cbProductosSubCEdicion.Checked = value;
          cbProductosSubCNuevo.Checked = value;
          cbProductosSubC.Checked = value;          
          cbProductosCEdicion.Checked = value;
          cbProductosCNuevo.Checked = value;
          cbProductosC.Checked = value;          
          cbProductosEdicion.Checked = value;
          cbProductosNuevo.Checked = value;
          cbProductos.Checked = value;        
          cbClientesEdicion.Checked = value;
          cbClientesNuevo.Checked = value;
          cbClientes.Checked = value;
          cbConsultaMovimientos.Checked = value;
          cbOrdernesCobrar.Checked = value;
          cbCuentasFacturadasReprint.Checked = value;
          cbCuentasFacturadas.Checked = value;
          cbNotasVenta.Checked = value;
          cbCuentasAnuladas.Checked = value;
          cbProcederPagar.Checked = value;
          cbMoverPedido.Checked = value;
          cbNotaVenta.Checked = value;
          cbAnularOrden.Checked = value;
          cbSepararCuenta.Checked = value;
          cbImprimirCuenta.Checked = value;
          cbImprimirAgregarOrdenes.Checked = value;
          cbMonitorCocina.Checked = value;
          cbDelivery.Checked = value;
          cbOrdenesMesa.Checked = value;
    }

    private void cbEmpleado_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      SetDefaultValues(false);
      var empleadoId = ((System.Web.UI.WebControls.ListItem)(cbEmpleado.SelectedItem)).Value;
      var mainDataSet = DataUtil.FillDataSet("SELECT * FROM Empleado_Acceso WHERE Codigo_empleado = '" + empleadoId + "'", "Empleado_Acceso");

      foreach (DataRow empleadoAccesoRow in mainDataSet.Tables["Empleado_Acceso"].Rows)
      {
        switch (DataUtil.GetInt(empleadoAccesoRow["Menu_id"]))
        {
          case AppConstant.MenuItems.ConfiguracionDelSistema:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbConfiguracionSistema.Checked = true;
            break;
          case AppConstant.MenuItems.ConfiguracionMesa:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbMesa.Checked = true;
            break;
          case AppConstant.MenuItems.BotonesProducto:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbBotonesProducto.Checked = true;
            break;

          case AppConstant.MenuItems.Empleados:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbEmpleados.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbEmpleadosNuevo.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbEmpleadosEdicion.Checked = true;            
            break;
          case AppConstant.MenuItems.Permisos:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbPermisos.Checked = true;
            break;
          case AppConstant.MenuItems.CambiarContrasena:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbCambiarContrasena.Checked = true;
            break;
          case AppConstant.MenuItems.ReincializarSistema:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbReiniciarSistema.Checked = true;
            break;


          case AppConstant.MenuItems.Estaciones:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbEstaciones.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbEstacionesNuevo.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbEstacionesEdicion.Checked = true;            
            break;
          case AppConstant.MenuItems.Turnos:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbTurnos.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbTurnosAbir.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbTurnosCerrar.Checked = true;
            break;
          case AppConstant.MenuItems.Movimientos:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbMovimientos.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbMovimientosNuevo.Checked = true;
            break;
          case AppConstant.MenuItems.MonitorVentas:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbMonitorVentas.Checked = true;
            break;
          case AppConstant.MenuItems.CorteCaja:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbCorteCaja.Checked = true;
            break;


          case AppConstant.MenuItems.Clientes:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbClientes.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbClientesNuevo.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbClientesEdicion.Checked = true;            
            break;
          case AppConstant.MenuItems.Productos:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbProductos.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbProductosNuevo.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbProductosEdicion.Checked = true;            
            break;
          case AppConstant.MenuItems.ProductosCategorias:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbProductosC.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbProductosCNuevo.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbProductosCEdicion.Checked = true;            
            break;
          case AppConstant.MenuItems.ProductosSubCategorias:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbProductosSubC.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbProductosSubCNuevo.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbProductosSubCEdicion.Checked = true;            
            break;
          case AppConstant.MenuItems.Proveedores:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbProveedores.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Nuevo"]).Equals(1))
              cbProveedoresNuevo.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Edicion"]).Equals(1))
              cbProveedoresEdicion.Checked = true;            
            break;



          case AppConstant.MenuItems.CuentasAnuladas:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbCuentasAnuladas.Checked = true;            
            break;
          case AppConstant.MenuItems.NotasVenta:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbNotasVenta.Checked = true;
            break;
          case AppConstant.MenuItems.CuentasFacturadas:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbCuentasFacturadas.Checked = true;
            if (DataUtil.GetInt(empleadoAccesoRow["Especial"]).Equals(1))
              cbCuentasFacturadasReprint.Checked = true;
            break;
          case AppConstant.MenuItems.OrdenesPorCobrar:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbOrdernesCobrar.Checked = true;            
            break;
          case AppConstant.MenuItems.ConsultaMovimientos:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbConsultaMovimientos.Checked = true;
            break;



          case AppConstant.MenuItems.OrdenesMesa:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbOrdenesMesa.Checked = true;
            break;
          case AppConstant.MenuItems.Delivery:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbDelivery.Checked = true;
            break;
          case AppConstant.MenuItems.MonitorCocina:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbMonitorCocina.Checked = true;
            break;
          case AppConstant.MenuItems.ImprimirAgregarOrdenes:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbImprimirAgregarOrdenes.Checked = true;            
            break;
          case AppConstant.MenuItems.ImprimirCuenta:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbImprimirCuenta.Checked = true;
            break;
          case AppConstant.MenuItems.SepararCuenta:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbSepararCuenta.Checked = true;
            break;
          case AppConstant.MenuItems.AnularOrden:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbAnularOrden.Checked = true;
            break;
          case AppConstant.MenuItems.GenerarNotaVenta:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbNotaVenta.Checked = true;
            break;
          case AppConstant.MenuItems.MoverPedidoMesa:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbMoverPedido.Checked = true;            
            break;
          case AppConstant.MenuItems.ProcederPagar:
            if (DataUtil.GetInt(empleadoAccesoRow["Acceso"]).Equals(1))
              cbProcederPagar.Checked = true;
            break;
        }
      }
    }

    private void btnSave_Click(object sender, System.EventArgs e)
    {
      if (cbEmpleado.SelectedItem != null)
      {
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ConfiguracionDelSistema, cbConfiguracionSistema.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ConfiguracionMesa, cbMesa.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.BotonesProducto, cbBotonesProducto.Checked, false, false, false);

        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Empleados, cbEmpleados.Checked, cbEmpleadosNuevo.Checked, cbEmpleadosEdicion.Checked, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Permisos, cbPermisos.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.CambiarContrasena, cbCambiarContrasena.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ReincializarSistema, cbReiniciarSistema.Checked, false, false, false);

        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Estaciones, cbEstaciones.Checked, cbEstacionesNuevo.Checked, cbEstacionesEdicion.Checked, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Turnos, cbTurnos.Checked, cbTurnosAbir.Checked, cbTurnosCerrar.Checked, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Movimientos, cbMovimientos.Checked, cbMovimientosNuevo.Checked, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.MonitorVentas, cbMonitorVentas.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.CorteCaja, cbCorteCaja.Checked, false, false, false);
        
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Clientes, cbClientes.Checked, cbClientesNuevo.Checked, cbClientesEdicion.Checked, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Productos, cbProductos.Checked, cbProductosNuevo.Checked, cbProductosEdicion.Checked, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ProductosCategorias, cbProductosC.Checked, cbProductosCNuevo.Checked, cbProductosCEdicion.Checked, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ProductosSubCategorias, cbProductosSubC.Checked, cbProductosSubCNuevo.Checked, cbProductosSubCEdicion.Checked, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Proveedores, cbProveedores.Checked, cbProveedoresNuevo.Checked, cbProveedoresEdicion.Checked, false);
        
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.CuentasAnuladas, cbCuentasAnuladas.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.NotasVenta, cbNotasVenta.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.CuentasFacturadas, cbCuentasFacturadas.Checked, false, false, cbCuentasFacturadasReprint.Checked);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.OrdenesPorCobrar, cbOrdernesCobrar.Checked, false, false, false);  
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ConsultaMovimientos, cbConsultaMovimientos.Checked, false, false, false);
        
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.OrdenesMesa, cbOrdenesMesa.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.Delivery, cbDelivery.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.MonitorCocina, cbMonitorCocina.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ImprimirAgregarOrdenes, cbImprimirAgregarOrdenes.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ImprimirCuenta, cbImprimirCuenta.Checked, false, false, false);
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.SepararCuenta, cbSepararCuenta.Checked, false, false, false); 
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.AnularOrden, cbAnularOrden.Checked, false, false, false);   
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.GenerarNotaVenta, cbNotaVenta.Checked, false, false, false);     
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.MoverPedidoMesa, cbMoverPedido.Checked, false, false, false);       
        SaveEmpleadoAccesoValues(AppConstant.MenuItems.ProcederPagar, cbProcederPagar.Checked, false, false, false);

        MessageBox.Show(@"Registro grabado correctamente", @"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        Close();
      }
    }

    private void SaveEmpleadoAccesoValues(int menuId, bool acceso, bool nuevo, bool edicion, bool especial)
    {
      var accesoFlag = '0';
      var nuevoFlag = '0';
      var edicionFlag = '0';
      const char grabarFlag = '0';
      var especialFlag = '0';

      if (acceso)
        accesoFlag = '1';
      if (nuevo)
        nuevoFlag = '1';
      if (edicion)
        edicionFlag = '1';      
      if (especial)
        especialFlag = '1';

      var empleadoId = ((System.Web.UI.WebControls.ListItem)(cbEmpleado.SelectedItem)).Value;
      var sqlForExecute = "Codigo_empleado = '" + empleadoId + "' AND Menu_id = " + menuId + "";
      if (DataUtil.GetInt(DataUtil.FindSingleRow("Empleado_Acceso", "Count(*)", sqlForExecute)) > 0)
      {
        sqlForExecute = "UPDATE Empleado_Acceso SET " +
                                "Acceso = '" + accesoFlag + "'" +
                                ", Nuevo = '" + nuevoFlag + "'" +
                                ", Edicion = '" + edicionFlag + "'" +
                                ", Grabar = '" + grabarFlag + "'" +
                                ", Especial = '" + especialFlag + "'" +
                                " WHERE Menu_id = " + menuId + " AND Codigo_empleado = '" + empleadoId + "'";
        DataUtil.UpdateThrow(sqlForExecute);
      }
      else
      {
        sqlForExecute = "INSERT INTO Empleado_Acceso (" +
                                     "Menu_id," +
                                     "Codigo_empleado," +
                                     "Acceso," +
                                     "Nuevo," +
                                     "Edicion," +
                                     "Grabar," +
                                     "Especial)" +
                                    " VALUES (" +
                                     DataUtil.GetString(menuId) + "," +
                                     "" + DataUtil.GetString(empleadoId) + "," +
                                     "'" + DataUtil.GetString(accesoFlag) + "'," +
                                     "'" + DataUtil.GetString(nuevoFlag) + "'," +
                                     "'" + DataUtil.GetString(edicionFlag) + "'," +
                                     "'" + DataUtil.GetString(grabarFlag) + "'," +
                                     "" + DataUtil.GetString(especialFlag) + "" +
                                     ")";
        DataUtil.UpdateThrow(sqlForExecute);
      }
    }
  }
}
