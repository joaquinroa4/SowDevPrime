using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;
using System.Data.SqlClient;

namespace VentaNegocio
{
    public class H_Venta
    {
        public int id_Remito { get; set; }
        public int cod_Usuario { get; set; }
        public DateTime fecha_Hora { get; set; }
        public int id_Cliente { get; set; }
        public string subtotal { get; set; }
        public string descuento { get; set; }
        public string total { get; set; }

        //Constructor para agregar Media Venta
        public H_Venta (int Cliente, DateTime fechaHora)
        {
            id_Cliente = Cliente;
            fecha_Hora = fechaHora;
            
        }

        //Constructor para cancelar la venta
        public H_Venta(int ID_Remito)
        {
            id_Remito = ID_Remito;
        }

        //Constructor para el update de la venta
        public H_Venta(int ID_Remito, string Subtotal, string Descuento, int Usuario, string Total)
        {
            id_Remito = ID_Remito;
            subtotal = Subtotal;
            descuento = Descuento;
            cod_Usuario = Usuario;
            total = Total;
        }
    }

    public class Cliente
    {
        public int id_Cliente { get; set; }
        public int clienteDni { get; set; }
        public string clienteNombre { get; set; }
        public string clienteEmail { get; set; }
        public int clienteTelefono { get; set; }
        public string clienteDirec { get; set; }


        //Constructor para añadir un cliente nuevo
        public Cliente (int DNI, string Nombre, string Email, int Telefono, string Direccion)
        {
            clienteDni = DNI;
            clienteNombre = Nombre;
            clienteEmail = Email;
            clienteTelefono = Telefono;
            clienteDirec = Direccion;
        }

        //Constructor para añadir un cliente solo con CUIT (no existe en BD)
        public Cliente (int DNI)
        {
            clienteDni = DNI;
        }

    }
    public class H_Venta_D
    {
        public int id_Remito { get; set; }
        public string cod_Art { get; set; }
        public string descr_Venta { get; set; }
        public int cantidad { get; set; }
        public string precio_Unidad { get; set; }
        public string precio_Total { get; set; }

        //Constructor para añadir el detalle de la venta
        public H_Venta_D (int Remito, string Codigo, string Descripcion, int Cantidad, string PxU, string Total)
        {
            id_Remito = Remito;
            cod_Art = Codigo;
            descr_Venta = Descripcion;
            cantidad = Cantidad;
            precio_Unidad = PxU;
            precio_Total = Total;
        }

    }

    public class Articulo
    {
        public int id_Art { get; set; }
        public string cod_Art { get; set; }
        public string desc_Art { get; set; }
        public int stock_Art { get; set; }

        public Articulo (int ID)
        {
            id_Art = ID;
        }
        public Articulo (string Codigo)
        {
            cod_Art = Codigo;
        }


        //Constructor para actualizar stock
        public Articulo (int cantidad, string Codigo)
        {
            cod_Art = Codigo;
            stock_Art = cantidad;
        }
  
    }

    public class Vendedores
    {
        public int id_Vendedor { get; set; }
        public string nombre_Vendedor { get; set; }

        public Vendedores (int ID, string Nombre)
        {
            id_Vendedor = ID;
            nombre_Vendedor = Nombre;
        }
    }

    public class Gestion_H_Venta
    {
        //public static DataTable Regsitro_Venta()
        //{
        //    string query = "Select [ID_Remito], [Cod_Art], [Descripcion], [Precio_Unit], [Cantidad], [Precio_Total] From [dbo].[Hist_Ventas_Detalle] inner join [dbo].[Hist_Ventas] on [dbo].[Hist_Ventas_Detalle].[ID_Remito] =  [dbo].[Hist_Ventas].[ID_Remito]";
        //    DataTable productos = new DataTable();
        //    productos.Load(ConexionBD.LecturaBD(query));
        //    return productos;
        //}


        public static DataTable Codigo_Productos()
        {
            string query = "Select [ID_Articulo], [Cod_Articulo] from [dbo].[Articulos]";
            DataTable codProductos = new DataTable();
            codProductos.Load(ConexionBD.LecturaBD(query));
            return codProductos;
        }

        
        public static DataTable Descrip_ProductoXCodigo(Articulo X)
        {
            string query = "Select [Art_Descrip], [PrecioVenta] from [dbo].[Articulos] where [ID_Articulo] = " + X.id_Art;
            DataTable descProductos = new DataTable();
            descProductos.Load(ConexionBD.LecturaBD(query));
            return descProductos;
        }

        public static DataTable Traer_Vendedores()
        {
            string query = "Select [Nombre_Usuario], [ID_Usuario] from [dbo].[Usuarios]";
            DataTable vendedores = new DataTable();
            vendedores.Load(ConexionBD.LecturaBD(query));
            return vendedores;
        }


        //Insert para clientes que no se cargan
        public static string Genera_Medio_Insert_HVentas_Inex(H_Venta X)
        {
            string fechaFormateada = X.fecha_Hora.ToString("yyyy-MM-dd HH:mm:ss");
            return "INSERT INTO [dbo].[Hist_Ventas] ([Cuit_Cliente_Inex], [Fecha_Hora]) values (" + X.id_Cliente + ", '" + fechaFormateada + "')";
        }

        //Insert para clientes existentes que sí se cargan
        public static string Genera_Medio_Insert_HVentas_Ex (H_Venta X)
        {
            string fechaFormateada = X.fecha_Hora.ToString("yyyy-MM-dd HH:mm:ss");
            return "INSERT INTO [dbo].[Hist_Ventas] ([ID_Cliente], [Fecha_Hora]) values (" + X.id_Cliente + ", '" + fechaFormateada + "')";
        }
        
        //Insert para cargar un nuevo cliente desde 0
        public static string Carga_Cliente_Nuevo(Cliente X)
        {
            return "INSERT INTO [dbo].[Clientes] ([CUIT_Cliente], [Nombre_Cliente], [Telf_Cliente], [Mail_Cliente], [Direc_Cliente]) values (" + X.clienteDni + ", '" + X.clienteNombre + "', " + X.clienteTelefono + ", '" + X.clienteEmail + "', '" + X.clienteDirec + "')";
        }

        public static string Genera_Insert_Productos (H_Venta_D X)
        {
            return "INSERT INTO [dbo].[Hist_Ventas_Detalle] ([ID_Remito], [Cod_Art], [Descripcion], [Precio_Unit], [Cantidad], [Precio_Total]) VALUES (" + X.id_Remito + ", '" + X.cod_Art + "', '" + X.descr_Venta + "', '" + X.precio_Unidad + "', " + X.cantidad + ", '" + X.precio_Total + "')"; 
        }

        //Genera Update en la tabla H_Ventas
        public static string Genera_Update_HVentas (H_Venta X)
        {
            return "UPDATE [dbo].[Hist_Ventas] SET [Cod_Usuario] = " + X.cod_Usuario + ", [Subtotal] = '" + X.subtotal + "', [Descuento] = '" + X.descuento + "', [Total] = '" + X.total + "' WHERE [ID_Remito] = " + X.id_Remito;
        }

        public static string Actualiza_Stock(Articulo X)
        {
            return "UPDATE [dbo].[Articulos] SET [Stock_Articulo] = " + X.stock_Art + " where [ID_Articulo] =" + X.cod_Art;
        }

        public static string Genera_Delete_HVentas(H_Venta X)
        {
            return "DELETE FROM [dbo].[Hist_Ventas] where [ID_Remito] = " + X.id_Remito;
        }
    }


}
