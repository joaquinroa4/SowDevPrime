using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;

namespace CategoriaNegocio
{
    public class Categoria
    {
        public int id_Categoria { get; set; }
        public string desc_Categoria { get; set; }

        //Constructor para agregar categorías

        public Categoria(string descripcion)
        {
            desc_Categoria = descripcion;
        }

        //Constructor para modificar categorías
        public Categoria(int ID, string descripcion)
        {
            id_Categoria = ID;
            desc_Categoria = descripcion;
        }
        //Constructor para eliminar categorías
        public Categoria(int ID)
        {
            id_Categoria = ID;
        }
    }

    public class Gestion_Categoria
    {
        public static DataTable Traer_Categorias()
        {
            string query = "SELECT [ID_Categoria], [categoria] FROM [dbo].[Categoria]";
            DataTable tabla_Categorias = new DataTable();
            tabla_Categorias.Load(ConexionBD.LecturaBD(query));
            return tabla_Categorias;
        }

        public static string Genera_Insert_Categoria(Categoria X)
        {
            return "INSERT INTO [dbo].[Categoria] ([categoria]) VALUES ('" + X.desc_Categoria + "')";
        }

        public static string Genera_Update_Categoria(Categoria X)
        {
            return "UPDATE [dbo].[Categoria] SET [categoria] = '" + X.desc_Categoria + "' WHERE [ID_Categoria] = " + X.id_Categoria;
        }

        public static string Genera_Update_Art(Categoria X)
        {
            return "UPDATE [dbo].[Articulos] SET [Cod_Categorias] = 6 from [dbo].[Articulos] inner join [dbo].[Categoria] on [dbo].[Articulos].[Cod_Categorias] = [dbo].[Categoria].[ID_Categoria] WHERE [dbo].[Categoria].[ID_Categoria] = " + X.id_Categoria;
        }

        public static string Genera_Update_SubCat (Categoria X)
        {
            return "UPDATE [dbo].[SubCategorias] SET [ID_Categorias] = 6 from [dbo].[SubCategorias] inner join [dbo].[Categoria] on [dbo].[SubCategorias].[ID_Categorias] = [dbo].[Categoria].[ID_Categoria]  WHERE [dbo].[Categoria].[ID_Categoria] = " + X.id_Categoria; 
        }

        public static string Genera_Delete_Categoria(Categoria X)
        {
            return "DELETE FROM [dbo].[Categoria] WHERE [ID_Categoria] = " + X.id_Categoria;
        }
     
        
    }
}
