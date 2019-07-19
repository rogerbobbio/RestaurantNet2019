namespace RestaurantNet
{  
  public sealed class DataBaseQuerys
  {
    static internal string SqlSelect = string.Empty;
    public static string ImpresoraTest()
    {
      SqlSelect = "SELECT Mesa_id, " +
                  "       Pedido_id, " +
                  "       Tipo_venta, " +
                  "       AtendidoPor, " +
                  "       Fecha_Pedido, " +
                  "       Codigo_Producto, " +
                  "       Descripcion_Producto, " +
                  "       Pedido_cantidad, " +
                  "       Precio_proveedor," +
                  "       Pedido_Descuento," +
                  "       Producto_precio, " +
                  "       9999 AS Orden_turno " +
                  "  FROM Impresora_test ";
      return SqlSelect;
    }
    public static string ProductoSearch()
    {
        SqlSelect = "p.Producto_id AS Codigo, " +
                    "p.Producto_descripcion AS [Producto], " +
                    "p.Producto_tipo AS [Tipo producto], " +
                    "pc.Producto_categoria_descripcion AS Categoria," +
                    "psc.Producto_sub_categoria_descripcion AS [Sub Categoria]," +
                    "pv.Proveedor_nombre AS Proveedor," +
                    "p.Precio_proveedor AS [Precio proveedor]," +
                    "p.Margen_ganancia AS [Margen de ganancia], " +
                    "p.Precio_final AS [Precio final], " +
                    "p.Cantidad_actual AS [Stock actual]," +
                    "p.Fecha_creacion AS [Fecha creacion], " +
                    "cr.Apellidos_empleado+', '+cr.Nombres_empleado AS [Creado por]," +
                    "p.Fecha_actualizacion AS [Fecha actualizacion]," +
                    "up.Apellidos_empleado+', '+up.Nombres_empleado AS [Actualizado por],  " +
                    "p.Producto_descripcion_corta AS [Descripcion Corta] " +
                    " FROM ((((producto AS p LEFT JOIN empleado AS cr ON p.creado_por=cr.codigo_empleado)  " +
                    " LEFT JOIN empleado AS up ON p.actualizado_por = up.codigo_empleado)" +
                    " LEFT JOIN producto_categoria AS pc ON p.Producto_categoria_id = pc.Producto_categoria_id)" +
                    " LEFT JOIN producto_sub_categoria AS psc ON p.Producto_sub_categoria_id = psc.Producto_sub_categoria_id)" +
                    " LEFT JOIN proveedor AS pv ON p.Proveedor_id = pv.Proveedor_id";
        return SqlSelect;
    }
    public static string ProductoCategoriaActivos(bool allRecords)
    {
      if (allRecords)
        SqlSelect = "SELECT * " +
                    "  FROM Producto_categoria WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' " +
                    " ORDER BY Producto_categoria_descripcion";
      else
        SqlSelect = "SELECT Producto_categoria_descripcion " +
                    "  FROM Producto_categoria WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' "+
                    " ORDER BY Producto_categoria_descripcion";
      return SqlSelect;
    }
    public static string ProductoSubCategoriaActivos(bool allRecords, string productoCategoriaId)
    {
      if (allRecords)
        SqlSelect = "SELECT * " +
                    "  FROM Producto_sub_categoria WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ";
      else
        SqlSelect = "SELECT Producto_sub_categoria_descripcion " +
                    "  FROM Producto_sub_categoria WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ";
      if (productoCategoriaId != string.Empty)
        SqlSelect = SqlSelect + " AND Producto_categoria_id = " + productoCategoriaId;
      SqlSelect =  SqlSelect + " ORDER BY Producto_sub_categoria_descripcion";
      return SqlSelect;
    }
    public static string InsumoGrupoClasificacionActivos()
    {
      SqlSelect = "SELECT Insumo_grupo_clasificacion_descripcion " +
                  "  FROM Insumo_grupo_clasificacion WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' " +
                  " ORDER BY Insumo_grupo_clasificacion_descripcion";
      return SqlSelect;
    }
    public static string Producto(string productoId, string productoTipo, string productoCategoriaId, string productoDescripcion)
    {
      SqlSelect = "SELECT * " +
                  "  FROM producto " +
                  " WHERE producto_id <> 0 ";
      if (productoId != string.Empty)
        SqlSelect = SqlSelect + " AND producto_id = " + productoId + "";
      if (productoTipo != string.Empty)
        SqlSelect = SqlSelect + " AND Producto_tipo = '" + productoTipo + "'";
      if (productoCategoriaId != string.Empty)
        SqlSelect = SqlSelect + " AND Producto_categoria_id = " + productoCategoriaId + "";
      if (productoDescripcion != string.Empty)
        SqlSelect = SqlSelect + " AND Producto_descripcion = '" + productoDescripcion + "'";
      return SqlSelect;
    }
    public static string ProductoBoton(string botonId, string productoSubCategoriaId)
    {
      SqlSelect = "SELECT * " +
                  "  FROM producto_boton " +
                  " WHERE Boton_id <> 0 ";
      if (botonId != string.Empty)
        SqlSelect = SqlSelect + " AND Boton_id = " + botonId + "";
      if (productoSubCategoriaId != string.Empty)
        SqlSelect = SqlSelect + " AND Producto_sub_categoria_id = " + productoSubCategoriaId + "";     
      return SqlSelect;
    }
    public static string PresentacionInsumo(string presentacionInsumoId, string InsumoGrupoId, string presentacionDescripcion)
    {
      SqlSelect = "SELECT * " +
                  "  FROM Presentacion_Insumo " +
                  " WHERE Presentacion_id <> 0 ";
      if (presentacionInsumoId != string.Empty)
        SqlSelect = SqlSelect + " AND Presentacion_id = " + presentacionInsumoId + "";
      if (InsumoGrupoId != string.Empty)
        SqlSelect = SqlSelect + " AND Insumo_grupo_id = " + InsumoGrupoId + "";
      if (presentacionDescripcion != string.Empty)
        SqlSelect = SqlSelect + " AND Presentacion_descripcion = '" + presentacionDescripcion + "'";
      return SqlSelect;
    }
    public static string InsumosActivos(bool allRecords, string insumoGrupoId)
    {
      if (allRecords)
        SqlSelect = "SELECT * " +
                    "  FROM Insumo WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ";
      else
        SqlSelect = "SELECT Insumo_descripcion " +
                    "  FROM Insumo WHERE Estado = '" + AppConstant.RegistroEstado.Activo + "' ";
      if (insumoGrupoId != string.Empty)
        SqlSelect = SqlSelect + " AND Insumo_grupo_id = " + insumoGrupoId;
      SqlSelect = SqlSelect + " ORDER BY Insumo_descripcion";
      return SqlSelect;
    }
    public static string ReporteCuenta(int pedidoID)
    {
      SqlSelect = "SELECT Pedido.Mesa_id, " +
                 "       Pedido.Pedido_id, " +
                 "       Pedido.Orden_turno, " +
                 "       Pedido.Tipo_venta, " +
                 "       Empleado.Nombres_empleado+', '+Empleado.Apellidos_empleado AS AtendidoPor," +
                 "       Pedido.Fecha_Pedido," +
                 "       Pedido_detalle.Codigo_Producto," +
                 "       Pedido_detalle.Descripcion_Producto," +
                 "       Producto.Producto_categoria_id," +
                 "       Producto.Precio_proveedor," +
                 "       SUM(Pedido_detalle.Cantidad) AS Pedido_cantidad," +
                 "       SUM(Pedido_detalle.Descuento) AS Pedido_Descuento," +
                 "       SUM(Producto.Precio_final) AS Producto_precio " +
                 "  FROM Producto " +
                 " INNER JOIN (Empleado INNER JOIN (Pedido INNER JOIN Pedido_detalle ON Pedido.Pedido_id = Pedido_detalle.Pedido_id) ON Empleado.Codigo_empleado = Pedido.Atendido_por) ON Producto.Producto_id = Pedido_detalle.Codigo_Producto" +
                 " WHERE Pedido.pedido_id = " + pedidoID + "" +
                 "   AND Producto_tipo <> 'ADICIONAL' " +
                 " GROUP BY Pedido.Mesa_id, Pedido.Pedido_id, Pedido.Orden_turno, Empleado.Nombres_empleado, Empleado.Apellidos_empleado," +
                 "          Pedido.Tipo_venta, Pedido.Fecha_Pedido, Pedido_detalle.Codigo_Producto," +
                 "          Pedido_detalle.Descripcion_Producto, Producto.Producto_categoria_id, Producto.Precio_proveedor";
      return SqlSelect;
    }
    public static string ReporteCocina(int pedidoID, int rePrint)
    {
      SqlSelect = "SELECT Pedido.Mesa_id, " +
                 "       Pedido.Pedido_id, " +
                 "       Pedido.Orden_turno, " +
                 "       Pedido.Tipo_venta, " +
                 "       Empleado.Nombres_empleado+', '+Empleado.Apellidos_empleado AS AtendidoPor, " +
                 "       Pedido.Fecha_Pedido, " +
                 "       Pedido_detalle.Codigo_Producto, " +
                 "       Pedido_detalle.Descripcion_Producto, " +
                 "       Producto.Producto_categoria_id, " +
                 "       Pedido_detalle.Cantidad AS Pedido_cantidad " +
                 "  FROM Producto " +
                 " INNER JOIN (Empleado " +
                 " INNER JOIN (Pedido " +
                 " INNER JOIN Pedido_detalle ON Pedido.Pedido_id = Pedido_detalle.Pedido_id) " +
                 "                           ON Empleado.Codigo_empleado = Pedido.Atendido_por) " +
                 "                           ON Producto.Producto_id = Pedido_detalle.Codigo_Producto" +
                 " WHERE Producto.Producto_categoria_id <> 3 AND Pedido.pedido_id = " + pedidoID + "" +
                 "   AND pedido_detalle.Impreso = " + rePrint +                 
                 " ORDER BY Pedido_detalle.Linea";
      return SqlSelect;
    }
    public static string PedidoCocina(int pedidoID)
    {
        SqlSelect = "SELECT Pedido.Mesa_id, " +
                   "       Pedido.Pedido_id, " +
                   "       Pedido.Orden_turno, " +
                   "       Pedido.Tipo_venta, " +
                   "       Empleado.Nombres_empleado+', '+Empleado.Apellidos_empleado AS AtendidoPor, " +
                   "       Pedido.Fecha_Pedido, " +
                   "       Pedido_detalle.Codigo_Producto, " +
                   "       Pedido_detalle.Descripcion_Producto, " +
                   "       Producto.Producto_categoria_id, " +
                   "       Pedido_detalle.Cantidad AS Pedido_cantidad " +
                   "  FROM Producto " +
                   " INNER JOIN (Empleado " +
                   " INNER JOIN (Pedido " +
                   " INNER JOIN Pedido_detalle ON Pedido.Pedido_id = Pedido_detalle.Pedido_id) " +
                   "                           ON Empleado.Codigo_empleado = Pedido.Atendido_por) " +
                   "                           ON Producto.Producto_id = Pedido_detalle.Codigo_Producto" +
                   " WHERE Producto.Producto_categoria_id <> 3 AND Pedido.pedido_id = " + pedidoID + "" +
                   " ORDER BY Pedido_detalle.Linea";
        return SqlSelect;
    }
    public static string ReporteBar(int pedidoID, int rePrint)
    {
      SqlSelect = "SELECT Pedido.Mesa_id, " +
                        "       Pedido.Pedido_id, " +
                        "       Pedido.Orden_turno, " +
                        "       Pedido.Tipo_venta, " +
                        "       Empleado.Nombres_empleado+', '+Empleado.Apellidos_empleado AS AtendidoPor, " +
                        "       Pedido.Fecha_Pedido, " +
                        "       Pedido_detalle.Codigo_Producto, " +
                        "       Pedido_detalle.Descripcion_Producto, " +
                        "       Producto.Producto_categoria_id, " +
                        "       Pedido_detalle.Cantidad AS Pedido_cantidad " +
                        "  FROM Producto " +
                        " INNER JOIN (Empleado " +
                        " INNER JOIN (Pedido " +
                        " INNER JOIN Pedido_detalle ON Pedido.Pedido_id = Pedido_detalle.Pedido_id) " +
                        "                           ON Empleado.Codigo_empleado = Pedido.Atendido_por) " +
                        "                           ON Producto.Producto_id = Pedido_detalle.Codigo_Producto" +
                        " WHERE Producto.Producto_categoria_id = 3 AND Pedido.pedido_id = " + pedidoID + "" +
                        "   AND pedido_detalle.Impreso  = " + rePrint +                        
                        " ORDER BY Pedido_detalle.Linea";
      return SqlSelect;
    }
    public static string Turno(int turnoID, int estacionID, bool allRecords)
    {
      SqlSelect = "SELECT * " +
                  "  FROM turno " +
                  " WHERE turno_id <> 0 ";
      if (turnoID != 0)
        SqlSelect = SqlSelect +  " AND turno_id = " + turnoID + "";
      if (estacionID != 0)
        SqlSelect = SqlSelect +  " AND turno_id IN (SELECT turno_id FROM turno_estacion WHERE estacion_id = " + estacionID + ") ";
      if (!allRecords)
        SqlSelect = SqlSelect + " AND Estado = 'ABIERTO'";
      return SqlSelect;
    }
    public static string TurnoEstacion()
    {      
      SqlSelect = "SELECT * FROM turno_estacion WHERE estacion_id = (SELECT estacion_id FROM estacion WHERE persona_asignada = " + AppConstant.EmployeeInfo.Codigo + ")";
      return SqlSelect;
    }
    public static string Movimientos(int turnoID, int estacionID)
    {
      SqlSelect = "SELECT * " +
                  "  FROM movimientos " +
                  " WHERE turno_id <> 0 ";
      if (turnoID != 0)
        SqlSelect = SqlSelect + " AND turno_id = " + turnoID + "";
      if (estacionID != 0)
        SqlSelect = SqlSelect + " AND Estacion_id = " + estacionID + "";
      SqlSelect = SqlSelect + " ORDER BY Movimiento_id";
      return SqlSelect;
    }
    public static string FillMainDataSet(string tableName, string formWhereField, string formId, string orderBy)
    {
      SqlSelect = "SELECT * FROM " + tableName + " WHERE " + formWhereField + " = " + formId + "";
      if (orderBy != string.Empty)
        SqlSelect = SqlSelect + " ORDER BY " + orderBy + "";
      return SqlSelect;
    }
    public static string Proveedor(string proveedorNombre)
    {
      SqlSelect = "SELECT * " +
                  "  FROM proveedor " +
                  " WHERE Proveedor_id <> 0 ";
      if (proveedorNombre != string.Empty)
        SqlSelect = SqlSelect + " AND Proveedor_nombre = '" + proveedorNombre + "'";      
      return SqlSelect;
    }
    public static string Mesa(int mesaID)
    {
      SqlSelect = "SELECT * FROM mesa WHERE mesa_id = " + mesaID + "";
      return SqlSelect;
    }

    public static bool GetAccess(int menuId, string empleadoId, string acceso)
    {
      //AppConstan.MenuItems
        
      var result = false;
      SqlSelect = "SELECT * FROM Empleado_Acceso WHERE menu_id = " + menuId + " AND Codigo_empleado = '" + empleadoId + "'";
      var dsEmpleadoAcceso = DataUtil.FillDataSet(SqlSelect, "Empleado_Acceso");
      if (dsEmpleadoAcceso.Tables["Empleado_Acceso"].Rows.Count > 0)
      {
        switch (acceso)
        {
          case AppConstant.AccessoTipos.Accesso:
            if (dsEmpleadoAcceso.Tables["Empleado_Acceso"].Rows[0]["Acceso"].ToString().Equals("1"))
              result = true;
            break;
          case AppConstant.AccessoTipos.Nuevo:
            if (dsEmpleadoAcceso.Tables["Empleado_Acceso"].Rows[0]["Nuevo"].ToString().Equals("1"))
              result = true;
            break;
          case AppConstant.AccessoTipos.Edicion:
            if (dsEmpleadoAcceso.Tables["Empleado_Acceso"].Rows[0]["Edicion"].ToString().Equals("1"))
              result = true;
            break;
          case AppConstant.AccessoTipos.Grabar:
            if (dsEmpleadoAcceso.Tables["Empleado_Acceso"].Rows[0]["Grabar"].ToString().Equals("1"))
              result = true;
            break;
          case AppConstant.AccessoTipos.Especial:
            if (dsEmpleadoAcceso.Tables["Empleado_Acceso"].Rows[0]["Especial"].ToString().Equals("1"))
              result = true;
            break;
        }        
      }      
      return result;
    }
  }
}
