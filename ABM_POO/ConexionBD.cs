using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ConexionSQL
{
    public static class ConexionBD
    {
        static string connectionstring;
        public static SqlConnection ConexionSQL;
        static string datasource = "joaqu\\SQLEXPRESS";
        static string basededatos = "SowDevPrime";
        static SqlCommand Orden;
        static SqlDataReader Lector;

        public static void ConectarBD()
        {
            connectionstring = @"Data Source=" + datasource + ";Initial Catalog=" + basededatos + ";Trusted_Connection=True;";
            if (ConexionSQL == null)
            {
                ConexionSQL = new SqlConnection(connectionstring);
                try
                {
                    ConexionSQL.Open();
                    //MessageBox.Show("Servidor: " + datasource + "\nBase de datos: " + basededatos + "\nConexion a Base de datos exitosa", "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error al intentar abrir base de datos", "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al intentar abrir base de datos:\nla conexion a BD ya está abierta", "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CierraBD()
        {
            if (ConexionSQL != null && ConexionSQL.State == System.Data.ConnectionState.Open)
            {
                ConexionSQL.Close();
                ConexionSQL = null;
              // MessageBox.Show("La conexion a la base de datos se cerró", "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("La conexion a la base de datos ya estaba cerrada", "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static SqlDataReader LecturaBD(string consulta)
        {
            Orden = new SqlCommand(consulta, ConexionSQL);
            Lector = Orden.ExecuteReader();
            return Lector;
        }

        public static void EjecutaQuery(string dame_query)
        {
            //este metodo usa una conexion abierta y alojada en "ConexionSQL" para ejecutar una query
            try
            {
                SqlCommand ejecuta = new SqlCommand(dame_query, ConexionSQL);
                ejecuta.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void EjecutaQueryPRO(string dame_query)
        {
            ConexionSQL = new SqlConnection(connectionstring);
            ConexionSQL.Open();
            using (ConexionSQL)
            {
                try
                {
                    SqlCommand ejecuta = new SqlCommand(dame_query, ConexionSQL);
                    ejecuta.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            //este metodo, al usar using, cierra la conexion una vez que termina. para volver a conectarnos debemos volver a abrir la conexion a bd

        }
        
        public static void EjecutaQueryParam(string dame_query, List<SqlParameter> param)
        {
            using (ConexionSQL)
            {
                try
                {
                    SqlCommand ejecuta = new SqlCommand(dame_query, ConexionSQL);
                    ejecuta.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            //este metodo, al usar using, cierra la conexion una vez que termina. para volver a conectarnos debemos volver a abrir la conexion a bd
            ConexionSQL = new SqlConnection(connectionstring);
            ConexionSQL.Open();
        }
    }
}
