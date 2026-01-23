using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;

namespace UsuarioNegocio
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public int usuarioDNI { get; set; }
        public int usuarioRol { get; set; }
        public string usuarioApellido { get; set; }
        public string usuarioNombre { get; set; }
        public string usuarioEmail { get; set; }
        public int usuarioTelf { get; set; }
        public string usuarioDirec { get; set; }
        public string usuarioUser { get; set; }
        public string usuarioPass { get; set; }


        //Constructor para eliminar Usuarios
        public Usuario(int ID)
        {
            usuarioID = ID;
                
        }
        //Constructor para agregar Usuarios
        public Usuario (int DNI, int Rol, string Apellido, string Nombre, string Email, string Direc, int Telefono, string User, string Password)
        {
            usuarioDNI = DNI;
            usuarioRol = Rol;
            usuarioApellido = Apellido;
            usuarioNombre = Nombre;
            usuarioEmail = Email;
            usuarioTelf = Telefono;
            usuarioUser = User;
            usuarioPass = Password;
            usuarioDirec = Direc;
        }

        //Constructor para modificar usuarios
        public Usuario(int ID, int DNI, int Rol, string Apellido, string Nombre, string Email, string Direc, int Telefono, string User, string Password)
        {
            usuarioID = ID;
            usuarioDNI = DNI;
            usuarioRol = Rol;
            usuarioApellido = Apellido;
            usuarioNombre = Nombre;
            usuarioEmail = Email;
            usuarioTelf = Telefono;
            usuarioUser = User;
            usuarioPass = Password;
            usuarioDirec = Direc;
        }


    }

    public class Gestion_Usuario
    {
        public static DataTable Traer_Usuarios()
        {
            string query = "SELECT [ID_Usuario], [Dni_Usuario], [Nombre_Usuario], [Apellido_Usuario], [Telf_Usuario], [Mail_Usuario], [User_Usuario], [Contrasenia_Usuario], [Direccion_Usuario], [Usuario_Desc] FROM[dbo].[Usuarios] inner join [dbo].[Usuario_Tipo] on [ID_Tipo] = [ID_Usuario_Tipo] ";
            DataTable tabla_Usuarios = new DataTable();
            tabla_Usuarios.Load(ConexionBD.LecturaBD(query));
            return tabla_Usuarios;
        }

        public static DataTable Traer_Roles()
        {
            string query = "SELECT [ID_Usuario_Tipo], [Usuario_Desc] FROM[dbo].[Usuario_Tipo]";
            DataTable tabla_Roles = new DataTable();
            tabla_Roles.Load(ConexionBD.LecturaBD(query));
            return tabla_Roles;

        }

        public static string Genera_Insert_Usuarios(Usuario X)
        {
            return "INSERT INTO [dbo].[Usuarios] ([Dni_Usuario], [ID_Tipo], [Apellido_Usuario], [Nombre_Usuario], [Mail_Usuario], [Telf_Usuario],  [Direccion_Usuario], [User_Usuario], [Contrasenia_Usuario]) VALUES (" + X.usuarioDNI + ", " + X.usuarioRol + ", '" + X.usuarioApellido + "', '" + X.usuarioNombre + "', '" + X.usuarioEmail + "', " + X.usuarioTelf + ", '" + X.usuarioDirec + "', '" + X.usuarioUser + "', '" + X.usuarioPass + "')";
        }

        public static string Genera_Update_Usuarios(Usuario X)
        {
            return "UPDATE [dbo].[Usuarios] SET[Nombre_Usuario] = '" + X.usuarioNombre + "', [Apellido_Usuario] = '" + X.usuarioApellido + "', [Telf_Usuario] = '" + X.usuarioTelf + "', [Mail_Usuario] = '" + X.usuarioEmail + "', [Direccion_Usuario] = '" + X.usuarioDirec + "', [ID_Tipo] = " + X.usuarioRol + ", [Dni_Usuario] = " + X.usuarioDNI + ", [User_Usuario] = '" + X.usuarioUser + "', [Contrasenia_Usuario] = '" + X.usuarioPass + "' WHERE [ID_Usuario] = " + X.usuarioID;
        }

        public static string Genera_Delete_Usuarios (Usuario X)
        {
            return "DELETE FROM [dbo].[Usuarios] WHERE [ID_Usuario] = " + X.usuarioID;
        }
    }

    
}
