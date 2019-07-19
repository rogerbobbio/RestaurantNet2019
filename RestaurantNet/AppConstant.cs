using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.Design;

namespace RestaurantNet
{
    public static class AppConstant
    {
        public const string CodigoAdministrador = "1";
        public static class RegistroEstado
        {
            public const string Inactivo = "INACTIVO";
            public const string Activo = "ACTIVO";
        }
        public static class DocumentVenta
        {
            public const string Boleta = "BOLETA";
            public const string Factura = "FACTURA";
            public const string NotaCredito = "NOTA CREDITO";
            public const string NotaDebito = "NOTA DEBITO";
        }
        public static class TipoProducto
        {
            public const string Personalizado = "PERSONALIZADO";
            public const string Adicional = "ADICIONAL";
        }
        public static class TipoPago
        {
            public const string Contado = "CONTADO";
            public const string TarjetaCredito = "TARJETA CREDITO";
            public const string Cheque = "CHEQUE";
            public const string VentaGratuita = "VENTA GRATUITA";
        }
        public static class TipoMovimiento
        {
            public const string Deposito = "DEPOSITO";
            public const string Retiro = "RETIRO";
        }
        public static class TipoVenta
        {
            public const string Salon = "SALON";
            public const string Delivery = "DELIVERY";
            public const string Rapida = "RAPIDA";
        }
        public static class EmpleadoCargo
        {
            public const string Administrador = "ADMINISTRADOR";
            public const string Cajero = "CAJERO";
            public const string Mozo = "MOZO";
        }
        public static class ProductoCategoriaDelSistema
        {
            public const string Bebidas = "3";
            public const string Entradas = "1";
            public const string PlatosPrincipales = "2";
            public const string Postres = "4";
        }
        public static class MenuItems
        {
            public const int ConfiguracionDelSistema = 1;
            public const int ConfiguracionMesa = 2;
            public const int BotonesProducto = 3;
            public const int Empleados = 4;
            public const int Permisos = 5;
            public const int CambiarContrasena = 6;
            public const int Estaciones = 7;
            public const int Turnos = 8;
            public const int Movimientos = 9;
            public const int MonitorVentas = 10;
            public const int CorteCaja = 11;
            public const int Clientes = 12;
            public const int Productos = 13;
            public const int ProductosCategorias = 14;
            public const int ProductosSubCategorias = 15;
            public const int Proveedores = 16;
            public const int CuentasAnuladas = 17;
            public const int NotasVenta = 18;
            public const int CuentasFacturadas = 19;
            public const int OrdenesPorCobrar = 20;
            public const int ConsultaMovimientos = 21;
            public const int OrdenesMesa = 22;
            public const int Delivery = 23;
            public const int MonitorCocina = 24;
            public const int ImprimirAgregarOrdenes = 25;
            public const int ImprimirCuenta = 26;
            public const int SepararCuenta = 27;
            public const int AnularOrden = 28;
            public const int GenerarNotaVenta = 29;
            public const int MoverPedidoMesa = 30;
            public const int ProcederPagar = 31;
            public const int ReincializarSistema = 32;
        }
        public static class PedidoEstado
        {
            public const string Atendiendo = "A";
            public const string Anulado = "C";
            public const string Facturado = "F";
            public const string NotaVenta = "N";
        }
        public static class Reportes
        {
            public const string Cocina = "Cocina";
            public const string Bar = "Bar";
            public const string Cuenta = "Cuenta";
            public const string Boleta = "Boleta";
            public const string Recibos = "Recibos";
            public const string Turno = "Turno";
            public const string ReporteVentas = "ReporteVentas";
            public const string ReporteCierre = "ReporteCierre";
        }
        public class EmployeeInfo
        {
            public static string Codigo
            {
                get;
                set;
            }
            public static string Nombres
            {
                get;
                set;
            }
            public static string Apellidos
            {
                get;
                set;
            }
            public static string Cargo
            {
                get;
                set;
            }
            public static string Password
            {
                get;
                set;
            }
        }
        public class Product
        {
            public static string ProductoDescription
            {
                get;
                set;
            }
            public static string ProductoDescriptionCorta
            {
                get;
                set;
            }
            public static string ProductoCodigo
            {
                get;
                set;
            }
            public static string ProductoPrecio
            {
                get;
                set;
            }
            public static string ProductoPrecioProveedor
            {
                get;
                set;
            }

            public static double PrecioProveedor
            {
                get;
                set;
            }
            public static double Margen
            {
                get;
                set;
            }
            public static double PrecioFinal
            {
                get;
                set;
            }
        }
        public class Customer
        {
            public static string ClienteNombre
            {
                get;
                set;
            }
            public static string ClienteCodigo
            {
                get;
                set;
            }
            public static string ClienteTelefono
            {
                get;
                set;
            }
            public static string ClienteDocumento
            {
                get;
                set;
            }
            public static string ClienteTipoDocumento
            {
                get;
                set;
            }
            public static string ClienteDireccion
            {
                get;
                set;
            }
        }
        public class GeneralInfo
        {
            public static string Compania
            {
                get;
                set;
            }
            public static string RUC
            {
                get;
                set;
            }
            public static string Direccion
            {
                get;
                set;
            }
            public static string Telefono
            {
                get;
                set;
            }
            public static string Fax
            {
                get;
                set;
            }
            public static string Mobile
            {
                get;
                set;
            }
            public static string Logo
            {
                get;
                set;
            }
            public static string Email
            {
                get;
                set;
            }
            public static string Web
            {
                get;
                set;
            }
            public static string IGV
            {
                get;
                set;
            }
            public static string Mensaje1
            {
                get;
                set;
            }
            public static string Mensaje2
            {
                get;
                set;
            }
            public static string Mensaje3
            {
                get;
                set;
            }
            public static string MontoCaja
            {
                get;
                set;
            }
            public static bool PasswordSalir
            {
                get;
                set;
            }
            public static bool PasswordAnulaciones
            {
                get;
                set;
            }
            public static bool PasswordNotaVenta
            {
                get;
                set;
            }
            public static bool PasswordDividirCuentas
            {
                get;
                set;
            }
            public static bool PasswordCambioMesa
            {
                get;
                set;
            }
            public static bool PasswordReimpresiones
            {
                get;
                set;
            }
            public static bool PasswordCambioMesero
            {
                get;
                set;
            }
            public static bool PasswordEliminarProducto
            {
                get;
                set;
            }
            public static bool MostrarIGVBoleta
            {
                get;
                set;
            }
            public static string AlegraUsuario
            {
                get;
                set;
            }
            public static string AlegraToken
            {
                get;
                set;
            }

            public class Impresora
            {
                public static string Bar
                {
                    get;
                    set;
                }
                public static string Cocina
                {
                    get;
                    set;
                }
                public static string Boleta
                {
                    get;
                    set;
                }
                public static string Recibos
                {
                    get;
                    set;
                }
                public static string Reportes
                {
                    get;
                    set;
                }
            }

            public class FontHeader
            {
                public static string Bar
                {
                    get;
                    set;
                }
                public static string Cocina
                {
                    get;
                    set;
                }
                public static string Boleta
                {
                    get;
                    set;
                }
                public static string Recibos
                {
                    get;
                    set;
                }
                public static string Reportes
                {
                    get;
                    set;
                }
            }

            public class FontDetail
            {
                public static string Bar
                {
                    get;
                    set;
                }
                public static string Cocina
                {
                    get;
                    set;
                }
                public static string Boleta
                {
                    get;
                    set;
                }
                public static string Recibos
                {
                    get;
                    set;
                }
                public static string Reportes
                {
                    get;
                    set;
                }
            }

            public class Preview
            {
                public static bool Bar
                {
                    get;
                    set;
                }
                public static bool Cocina
                {
                    get;
                    set;
                }
                public static bool Boleta
                {
                    get;
                    set;
                }
                public static bool Recibos
                {
                    get;
                    set;
                }
                public static bool Reportes
                {
                    get;
                    set;
                }
            }

            public class PrintText
            {
                public static bool Bar
                {
                    get;
                    set;
                }
                public static bool Cocina
                {
                    get;
                    set;
                }
            }
        }
        public class Order
        {
            public static string PedidoID
            {
                get;
                set;
            }
            public static string MesaID
            {
                get;
                set;
            }
            public static string MesaDescripcion
            {
                get;
                set;
            }
            public static string MesaTipo
            {
                get;
                set;
            }
            public static string TipoVenta
            {
                get;
                set;
            }
            public static string PedidoOrigenID
            {
                get;
                set;
            }
            public static string OrdenDiaID
            {
                get;
                set;
            }
        }
        public class Pay
        {
            public static bool paySuccesfully
            {
                get;
                set;
            }
        }
        public class Calculator
        {
            public static string textIN
            {
                get;
                set;
            }
            public static string textOUT
            {
                get;
                set;
            }
        }
        public class Turno
        {
            public static string Codigo
            {
                get;
                set;
            }
            public static string FechaHora
            {
                get;
                set;
            }
            public static string Estado
            {
                get;
                set;
            }
        }
        public class ProductButtonSelected
        {
            public static string ProductoId
            {
                get;
                set;
            }
            public static string ProductoDescripcion
            {
                get;
                set;
            }
            public static string PrecioFinal
            {
                get;
                set;
            }
            public static string PrecioProveedor
            {
                get;
                set;
            }
        }
        public class ReporteVentas
        {
            public static string FechaInicio
            {
                get;
                set;
            }
            public static string FechaFin
            {
                get;
                set;
            }
        }
        public static class AccessoTipos
        {
            public const string Accesso = "ASC";
            public const string Nuevo = "ADD";
            public const string Edicion = "EDI";
            public const string Grabar = "SAV";
            public const string Especial = "ESP";
        }
    }
}
