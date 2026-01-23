using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;

namespace TipoUsuarioNegocio
{
    public class TipoUsuario
    {
        public int id_TipoUsuario { get; set; }
        public string desc_TipoUsuario { get; set; }

        //Constructor para agregar Roles
        public TipoUsuario (string descripcion)
        {
            desc_TipoUsuario = descripcion;
        }

        //Constructor para modificar Roles
        public TipoUsuario (int ID, string descripcion)
        {
            id_TipoUsuario = ID;
            desc_TipoUsuario = descripcion;
        }

        //Constructor para eliminar Roles
        public TipoUsuario (int ID)
        {
            id_TipoUsuario = ID;
        }
    }

    public class Gestion_TipoUsuario
    {
        public static DataTable Traer_Roles()
        {
            string query = "SELECT [ID_Usuario_Tipo], [Usuario_Desc] FROM[dbo].[Usuario_Tipo]";
            DataTable tabla_Roles = new DataTable();
            tabla_Roles.Load(ConexionBD.LecturaBD(query));
            return tabla_Roles;
        }

        public static string Genera_Insert_Roles(TipoUsuario X)
        {
            return "INSERT INTO [dbo].[Usuario_Tipo] ([Usuario_Desc]) VALUES ('" + X.desc_TipoUsuario + "')";
        }

        public static string Genera_Update_Roles(TipoUsuario X)
        {
            return "UPDATE[dbo].[Usuario_Tipo] SET [Usuario_Desc] = '" + X.desc_TipoUsuario + "' where [ID_Usuario_Tipo] = " + X.id_TipoUsuario;
        }

        public static string Genera_Delete_Roles(TipoUsuario X)
        {
            return "DELETE FROM [dbo].[Usuario_Tipo] WHERE [ID_Usuario_Tipo] = " + X.id_TipoUsuario;
        }
    }
}
