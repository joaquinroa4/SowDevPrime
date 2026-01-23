using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;

namespace SubCategoriaNegocio
{
    public class SubCategoria
    {
        public int id_SubCat { get; set; }
        public string desc_SubCat { get; set; }
        public int id_Cat { get; set; }


        //Método para agregar Subcategorías
        public SubCategoria(string descripcion, int ID_cat)
        {
            desc_SubCat = descripcion;
            id_Cat = ID_cat;
        }

        //Método para modificar SubCategorías
        public SubCategoria(int ID_SubCat, string descripcion, int ID_cat)
        {
            id_SubCat = ID_SubCat;
            desc_SubCat = descripcion;
            id_Cat = ID_cat;
        }

        //Método para eliminar SubCategorías
        public SubCategoria(int ID_SubCat)
        {
            id_SubCat = ID_SubCat;
 
        }
    }

         //Traigo los id de categorías
         public class Categoria
          {
             public int id_Cat { get; set; }
             public string categoria { get; set; }

             public Categoria (int ID)
                {
                  id_Cat = ID;
                }
    }

    public class Gestion_Subcategoria
    {
        public static DataTable Traer_Categorias()
        {
            string query = "SELECT [ID_Categoria], [categoria] FROM [dbo].[Categoria]";
            DataTable tabla_Categorias = new DataTable();
            tabla_Categorias.Load(ConexionBD.LecturaBD(query));
            return tabla_Categorias;
        }

        public static DataTable Traer_Subcategorias()
        {
            string query = "SELECT [ID_SubCateg], [Subcategoria],[ID_Categorias] FROM [dbo].[SubCategorias] inner join [dbo].[Categoria] on [dbo].[SubCategorias].[ID_Categorias] = [dbo].[Categoria].[ID_Categoria]";
            DataTable tabla_Subcategoria = new DataTable();
            tabla_Subcategoria.Load(ConexionBD.LecturaBD(query));
            return tabla_Subcategoria;
        }

        //public static DataTable Traer_SubcategoriasXCategoria(Categoria X)
        //{
        //    string query = "Select [ID_SubCateg], [Subcategoria] FROM [dbo].[SubCategorias] inner join [dbo].[Categoria] on [dbo].[SubCategorias].[ID_Categorias] = [dbo].[Categoria].[ID_Categoria] where [dbo].[Categoria].[ID_Categoria] = " + X.id_Cat;
        //    DataTable tabla_SubCateg = new DataTable();
        //    tabla_SubCateg.Load(ConexionBD.LecturaBD(query));
        //    return tabla_SubCateg;
        //}

        public static string Genera_Insert_Subcategoria(SubCategoria X)
        {
            return " INSERT INTO[dbo].[SubCategorias] ([Subcategoria], [ID_Categorias]) VALUES ('" + X.desc_SubCat + "', " + X.id_Cat + ")";
        }

        public static string Genera_Update_Subcategoria(SubCategoria X)
        {
            return "UPDATE [dbo].[SubCategorias] SET[Subcategoria] = '" + X.desc_SubCat + "', [ID_Categorias] = " + X.id_Cat + " WHERE [ID_SubCateg] = " + X.id_SubCat;
        }

        public static string Genera_Update_Art(SubCategoria X)
        {
            return "Update [dbo].[Articulos] SET [Cod_SubCateg] = 5 where [Cod_SubCateg] = " + X.id_SubCat;
        }

        public static string Genera_Delete_Subcategoria(SubCategoria X)
        {
            return "DELETE FROM [dbo].[SubCategorias] WHERE [ID_SubCateg] = " + X.id_SubCat;
        }
    }
        


}
