using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;
using System.Data.SqlClient;

namespace CompraNegocio
{
    public class H_Compra
    {
        public int idRemito { get; set; }
        public int codUsuario { get; set; }
        public DateTime fecha_Hora { get; set; }
        public int id_Proov { get; set; }
        public string subtotal { get; set; }
        public string descuento { get; set; }
        public string total { get; set; }

        //Constructor para crear media compra
        public H_Compra (int Proovedor, DateTime fechaHora)
        {
            id_Proov = Proovedor;
            fecha_Hora = fechaHora;
        }

        //Constructor para cancelar la compra
        public H_Compra (int IDRemito)
        {
            idRemito = IDRemito;
        }
        
        //Constructor para actualizar compra
        public H_Compra (int IDRemito, int Vendedor, string Subtotal, string Descuento, string Total)
        {
            idRemito = IDRemito;
            codUsuario = Vendedor;
            subtotal = Subtotal;
            descuento = Descuento;
            total = Total;
        }
    }

    public class Proovedor
    {
        public int id_Proov { get; set; }
        public int Cuit_Proov { get; set; }
        public string nombre_Proov { get; set; }
        public string email_Proov { get; set; }
        public string telf_Proov { get; set; }


        public Proovedor (int Cuit, string Nombre, string Email, string Telefono)
        {
            Cuit_Proov = Cuit;
            nombre_Proov = Nombre;
            email_Proov = Email;
            telf_Proov = Telefono;
        }

        public Proovedor (int Cuit)
        {
            Cuit_Proov = Cuit;
        }

    }

    public class Gestion_H_Compra
    {
        public static DataTable Traer_Compradores()
        {
            string query = "Select [Nombre_Usuario], [ID_Usuario] from [dbo].[Usuarios]";
            DataTable compradores = new DataTable();
            compradores.Load(ConexionBD.LecturaBD(query));
            return compradores;
        }

        public static string Genera_Medio_Insert_Compras(H_Compra X)
        {
            return "INSERT INTO [dbo].[Hist_Compras] ([Fecha_hora], [ID_Proovedores]) ";
        }
    }
    

    
}
