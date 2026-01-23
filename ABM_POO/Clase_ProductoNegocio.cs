using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConexionSQL;

namespace ProductoNegocio
{
    //Carga de atributos para la carga de productos
    public class Producto
    {
        public int id_Art { get; set; }
        public string CodArt { get; set; }
        public string DescripArt { get; set; }
        public int CodCat { get; set; }
        public int CodSubCat { get; set; }
        public int ID_Proovedor { get; set; }
        public int cantidadArt { get; set; }
        public string costoArt { get; set; }
        public int precioVentaArt { get; set; }

        //Constructor para los datos del artículo
        public Producto (string ArtCod, string ArtDescr, int CatCod, int SubCatCod, int ArtCantidad, string ArtCosto, int ArtVenta, int IDProov)
        {
            CodArt = ArtCod;
            DescripArt = ArtDescr;
            CodCat = CatCod;
            CodSubCat = SubCatCod;
            cantidadArt = ArtCantidad;
            costoArt = ArtCosto;
            precioVentaArt = ArtVenta;
            ID_Proovedor = IDProov;
           
        }
        //Constructor para modificar objetos
        public Producto(int IDArt, string ArtCod, string ArtDescr, int CatCod, int SubCatCod, int ArtCantidad, string ArtCosto, int ArtVenta, int IDProov)
        {
            id_Art = IDArt;
            CodArt = ArtCod;
            DescripArt = ArtDescr;
            CodCat = CatCod;
            CodSubCat = SubCatCod;
            cantidadArt = ArtCantidad;
            costoArt = ArtCosto;
            precioVentaArt = ArtVenta;
            ID_Proovedor = IDProov;
        }

        //Constructor para eliminar productos
        public Producto (int IDArt)
        {
            id_Art = IDArt;
        }
    }

    public class Gestion_Productos
    {
        public static DataTable TraerProductos()
        {
            string query = "SELECT [ID_Articulo], [Cod_Articulo], [Art_Descrip], [Stock_Articulo], [Costo_Articulo], [PrecioVenta], [dbo].[Categoria].[categoria], [dbo].[SubCategorias].[Subcategoria], [dbo].[Proovedores].[Nombre_Proovedor] FROM [dbo].[Articulos] inner join [dbo].[Proovedores] on [dbo].[Articulos].[ID_Proovedor] = [dbo].[Proovedores].[ID_Proovedor] inner join [dbo].[Categoria] on [dbo].[Articulos].[Cod_Categorias] = [dbo].[Categoria].[ID_Categoria] inner join [dbo].[SubCategorias] on [dbo].[Articulos].[Cod_SubCateg] = [dbo].[SubCategorias].[ID_SubCateg]";
            DataTable tabla_Productos = new DataTable();
            tabla_Productos.Load(ConexionBD.LecturaBD(query));
            return tabla_Productos;
        }

        public static DataTable Traer_Proovedores()
        {
            string query = "SELECT [ID_Proovedor], [Nombre_Proovedor] FROM[dbo].[Proovedores]";
            DataTable tabla_Proovedores = new DataTable();
            tabla_Proovedores.Load(ConexionBD.LecturaBD(query));
            return tabla_Proovedores;
        }

        public static DataTable Traer_Categorias()
        {
            string query = "SELECT[ID_Categoria], [categoria] FROM[dbo].[Categoria]";
            DataTable tabla_Categorias = new DataTable();
            tabla_Categorias.Load(ConexionBD.LecturaBD(query));
            return tabla_Categorias;
        }
        public static DataTable Traer_Subcategorias()
        {
            string query = "SELECT [ID_SubCateg], [Subcategoria] FROM [dbo].[SubCategorias]";
            DataTable tabla_Subcategoria = new DataTable();
            tabla_Subcategoria.Load(ConexionBD.LecturaBD(query));
            return tabla_Subcategoria;
        }

        public static string Genera_Insert_Productos(Producto X)
        {
            return "INSERT INTO [dbo].[Articulos] ([Cod_Articulo], [Art_Descrip], [Stock_Articulo], [Costo_Articulo],[PrecioVenta], [Cod_Categorias], [Cod_SubCateg], [ID_Proovedor]) values ('" + X.CodArt + "', '" + X.DescripArt + "', " + X.cantidadArt + ", " + X.costoArt + ", " + X.precioVentaArt + ", " + X.CodCat + ", " + X.CodSubCat + ", " + X.ID_Proovedor + ")";
        }


        public static string Genera_Update_Productos(Producto X)
        {
            return "UPDATE [dbo].[Articulos] SET [Cod_Articulo] = " + X.CodArt + ", [Art_Descrip] = '" + X.DescripArt + "', [Stock_Articulo] = " + X.cantidadArt + ", [Costo_Articulo] = " + X.costoArt + ", [PrecioVenta] = " + X.precioVentaArt + ", [Cod_Categorias] = " + X.CodCat + ", [Cod_SubCateg] = " + X.CodSubCat + ", [ID_Proovedor] = " + X.ID_Proovedor + " where [ID_Articulo] = " + X.id_Art;
        }

        public static string Genera_Delete_Productos (Producto X)
        {
            return "Delete from [dbo].[Articulos] where [ID_Articulo] = " + X.id_Art; 
        }

    }
}
