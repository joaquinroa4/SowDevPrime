using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;

namespace ProovedorNegocio
{
    public class Proovedor
    {
        public int id_Proov { get; set; }
        public int cuit_Proov { get; set; }
        public string nombre_Proov { get; set; }
        public int telf_Proov { get; set; }
        public string email_Proov { get; set; }
        public string direc_Proov { get; set; }
        public string estado_Proov { get; set; }

        //Constructor para eliminar registros
        public Proovedor(int ID)
        {
            id_Proov = ID;
        }

        //Constructor para agregar registros
        public Proovedor(int DNI, string Nombre, int Telefono, string Email, string Direccion, string Estado)
        {
            cuit_Proov = DNI;
            nombre_Proov = Nombre;
            telf_Proov = Telefono;
            email_Proov = Email;
            direc_Proov = Direccion;
            estado_Proov = Estado;
        }

        //Constructor para modificar registros 
        public Proovedor(int ID, int DNI, string Nombre, int Telefono, string Email, string Direccion, string Estado)
        {
            id_Proov = ID;
            cuit_Proov = DNI;
            nombre_Proov = Nombre;
            telf_Proov = Telefono;
            email_Proov = Email;
            direc_Proov = Direccion;
            estado_Proov = Estado;
        }

    }

    public class Gestion_Proovedor
    {
        public static DataTable Trae_Proovedores()
        {
            string query = "SELECT [ID_Proovedor], [Cuit_Proovedor], [Nombre_Proovedor], [Telf_Proovedor], [Email_Proovedor], [Direc_Proovedor], [Estado_Proovedor] FROM [dbo].[Proovedores]";
            DataTable tabla_Proovedores = new DataTable();
            tabla_Proovedores.Load(ConexionBD.LecturaBD(query));
            return tabla_Proovedores;
        }

        public static string Genera_Insert_Proov(Proovedor X)
        {
            return "INSERT INTO [dbo].[Proovedores] ([Cuit_Proovedor], [Nombre_Proovedor], [Telf_Proovedor], [Email_Proovedor], [Direc_Proovedor], [Estado_Proovedor]) VALUES (" + X.cuit_Proov + ", '" + X.nombre_Proov + "', " + X.telf_Proov + ", '" + X.email_Proov + "', '" + X.direc_Proov + "', '" + X.estado_Proov + "')";
        }

        public static string Genera_Update_Proov(Proovedor X)
        {
            return "UPDATE [dbo].[Proovedores] SET[Cuit_Proovedor] = " + X.cuit_Proov + ", [Nombre_Proovedor] = '" + X.nombre_Proov + "', [Telf_Proovedor] = " + X.telf_Proov + ", [Email_Proovedor] = '" + X.email_Proov + "', [Direc_Proovedor] = '" + X.direc_Proov + "', [Estado_Proovedor] = '" + X.estado_Proov + "' WHERE [ID_Proovedor] = " + X.id_Proov;
        }

        public static string Genera_Update_Art (Proovedor X)
        {
            return "UPDATE [dbo].[Articulos] SET [ID_Proovedor] = 3 WHERE [ID_Proovedor] = " + X.id_Proov; 
        }

        public static string Genera_Delete_Proov(Proovedor X)
        {
            return "DELETE FROM [dbo].[Proovedores] WHERE [ID_Proovedor] = " + X.id_Proov;
        }
    }
}
