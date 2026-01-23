using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;
using System.Data.SqlClient;

namespace ClienteNegocio
{
    public class Cliente
    {
        //Genero los atributos para los constructores
        public int clienteDni { get; set; }
        public string clienteNombre { get; set; }
        public string clienteEntidad { get; set; }
        public string clienteEmail { get; set; }
        public int clienteTelefono { get; set; }
        public string clienteDirec { get; set; }
        public string clienteEstado { get; set; }
        public int ID_Cliente { get; set; }

        //Constructor para agregar clientes
        public Cliente(int DNI, string Nombre, string Entidad, string Email, int Telf, string direc, string Estado)
        {
            clienteDni = DNI;
            clienteNombre = Nombre;
            clienteEntidad = Entidad;
            clienteEmail = Email;
            clienteTelefono = Telf;
            clienteDirec = direc;
            clienteEstado = Estado;
        }
        //Constructor para modificar clientes
        public Cliente(int ID, int DNI, string Nombre, string Entidad, string Email, int Telf, string direc, string Estado)
        {
            ID_Cliente = ID;
            clienteDni = DNI;
            clienteNombre = Nombre;
            clienteEntidad = Entidad;
            clienteEmail = Email;
            clienteTelefono = Telf;
            clienteDirec = direc;
            clienteEstado = Estado;
        }
        //Constructor para borrar clientes
        public Cliente (int ID)
        {
            ID_Cliente = ID;
        }
    }
    public class Gestion_Cliente
    {
        //public int id;
       
        //public static int ObtenerIDCliente(int dni)
        //{
        //    string query = "Select [ID_Cliente] from [dbo].[Clientes] where CUIT_Cliente = " + dni;
        //    SqlDataReader lector = ConexionBD.LecturaBD(query);

        //    int id = -1;
        //    if (lector.Read())
        //        id = Convert.ToInt32(lector["ID_Cliente"]);
        //    lector.Close();
        //    return id;
        //}

        public static DataTable Traer_Clientes()
        {
            string query = "Select [ID_Cliente], [CUIT_Cliente], [Nombre_Cliente], [Entidad_Cliente], [Telf_Cliente], [Mail_Cliente], [Direc_Cliente], [Estado_Cliente] from [dbo].[Clientes]";
            DataTable tabla_Clientes = new DataTable();
            tabla_Clientes.Load(ConexionBD.LecturaBD(query));
            return tabla_Clientes;
        }
        public static string Genera_insert_cliente(Cliente X)
        {
            return "insert into [dbo].[Clientes] (CUIT_Cliente, Nombre_Cliente, Entidad_Cliente, Telf_Cliente, Mail_Cliente, Direc_Cliente, Estado_Cliente) values (" + X.clienteDni + ",'" + X.clienteNombre + "', '" + X.clienteEntidad + "', '" + X.clienteTelefono + "', '" + X.clienteEmail + "', '" + X.clienteDirec + "', '" + X.clienteEstado + "')";
        }
        public static string Genera_update_cliente(Cliente X)
        {
            return "UPDATE [dbo].[Clientes] SET [CUIT_Cliente] = " + X.clienteDni + ", [Nombre_Cliente] = '" + X.clienteNombre + "', [Entidad_Cliente] = '" + X.clienteEntidad + "', [Telf_Cliente] = '" + X.clienteTelefono + "', [Mail_Cliente] = '" + X.clienteEmail + "', [Direc_Cliente] = '" + X.clienteDirec + "', [Estado_Cliente] = '" + X.clienteEstado + "' WHERE [ID_Cliente]= " + X.ID_Cliente;
        }
        public static string Genera_delete_cliente(Cliente X)
        {
            return "DELETE FROM [dbo].[Clientes] WHERE ID_Cliente = " + X.ID_Cliente;
        }
    }
}