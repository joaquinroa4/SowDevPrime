using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionSQL;
using ProductoNegocio;
using System.Data.SqlClient;

namespace ABM_POO
{
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();
        }

        formCategoria ventanaCat;
        formProovedores ventanaProov;
        formSubCategoria ventanaSubCat;



        private void btn_AgregarCat_Click(object sender, EventArgs e)
        {
            if (ventanaCat == null || ventanaCat.IsDisposed)
            {
                ventanaCat = new formCategoria();
                ventanaCat.ShowDialog();
            }
            else
            {
                ventanaCat.BringToFront();
                ventanaCat.ShowDialog();
            }
            ConexionBD.ConectarBD();
            ActualizaGrilla();
            ConexionBD.CierraBD();
            CambiaCategorias();
        }

        private void btn_AgregarProov_Click(object sender, EventArgs e)
        {
            if (ventanaProov == null || ventanaProov.IsDisposed)
            {
                ventanaProov = new formProovedores();
                ventanaProov.ShowDialog();
            }
            else
            {
                ventanaProov.BringToFront();
                ventanaProov.ShowDialog();
            }
            ConexionBD.ConectarBD();
            ActualizaGrilla();
            ConexionBD.CierraBD();
            CambiaProovedores();
        }

        private void btn_AgregarSubCat_Click(object sender, EventArgs e)
        {
            if (ventanaSubCat == null || ventanaSubCat.IsDisposed)
            {
                ventanaSubCat = new formSubCategoria();
                ventanaSubCat.ShowDialog();
            }
            else
            {
                ventanaSubCat.BringToFront();
                ventanaSubCat.ShowDialog();
            }
            ConexionBD.ConectarBD();
            ActualizaGrilla();
            ConexionBD.CierraBD();
            CambiaSubcategoria();
        }

        private void formProductos_Load(object sender, EventArgs e)
        {
            txt_DescrProd.Focus();
            dgv_Productos.EnableHeadersVisualStyles = false;
            dgv_Productos.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv_Productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Productos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ConexionBD.ConectarBD();
            dgv_Productos.DataSource = Gestion_Productos.TraerProductos();
            ConexionBD.CierraBD();
            CambiaHeader();
            CambiaCategorias();
            CambiaProovedores();
            CambiaSubcategoria();
            LimpiaCombo();
            btn_EliminarProd.Enabled = false;
            btn_ModificarProd.Enabled = false;
        }

        private void ActualizaGrilla()
        {
            dgv_Productos.DataSource = Gestion_Productos.TraerProductos();
        }

        private void LimpiaTextbox()
        {
            txt_CantProd.Text = "";
            txt_CodProducto.Text = "";
            txt_DescrProd.Text = "";
            txt_PrecioVentaProd.Text = "";
            txt_PrecioUnitProd.Text = "";
            cmbx_Categorias.Text = "";
            cmbx_ProovProd.Text = "";
            cmbx_ProovProd.Text = "";
        }
        private void CambiaHeader()
        {
            dgv_Productos.Columns["ID_Articulo"].HeaderText = "ID Artículo";
            dgv_Productos.Columns["Cod_Articulo"].HeaderText = "Código";
            dgv_Productos.Columns["Art_Descrip"].HeaderText = "Descripción";
            dgv_Productos.Columns["categoria"].HeaderText = "Categoría";
            dgv_Productos.Columns["Subcategoria"].HeaderText = "Subcategoría";
            dgv_Productos.Columns["Stock_Articulo"].HeaderText = "Stock";
            dgv_Productos.Columns["Costo_Articulo"].HeaderText = "Costo";
            dgv_Productos.Columns["PrecioVenta"].HeaderText = "Precio de Venta";
            dgv_Productos.Columns["Nombre_Proovedor"].HeaderText = "Proovedor";

        }

        private void CambiaProovedores()
        {
            ConexionBD.ConectarBD();
            cmbx_ProovProd.DataSource = Gestion_Productos.Traer_Proovedores();
            cmbx_ProovProd.DisplayMember = "Nombre_Proovedor";
            cmbx_ProovProd.ValueMember = "ID_Proovedor";
            ConexionBD.CierraBD();
            cmbx_ProovProd.SelectedText = "Sin Proovedor";
        }
        private void CambiaCategorias()
        {
            ConexionBD.ConectarBD();
            cmbx_Categorias.DataSource = Gestion_Productos.Traer_Categorias();
            cmbx_Categorias.DisplayMember = "categoria";
            cmbx_Categorias.ValueMember = "ID_Categoria";
            ConexionBD.CierraBD();
            cmbx_Categorias.SelectedText = "Sin Categoría";
        }
        private void CambiaSubcategoria()
        {
            ConexionBD.ConectarBD();
            cmbx_SubCategorias.DataSource = Gestion_Productos.Traer_Subcategorias();
            cmbx_SubCategorias.DisplayMember = "Subcategoria";
            cmbx_SubCategorias.ValueMember = "ID_SubCateg";
            ConexionBD.CierraBD();
            cmbx_SubCategorias.SelectedText = "Sin Subcategoría";
        }

        private void btn_AgregarProd_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();

            int codCat = Convert.ToInt32(cmbx_Categorias.SelectedValue.ToString());
            int codSubCat = Convert.ToInt32(cmbx_SubCategorias.SelectedValue.ToString());
            int codProov = Convert.ToInt32(cmbx_ProovProd.SelectedValue.ToString());

            Producto productoAgregar = new Producto(txt_CodProducto.Text, txt_DescrProd.Text, codCat, codSubCat, Convert.ToInt32(txt_CantProd.Text), txt_PrecioUnitProd.Text, Convert.ToInt32(txt_PrecioVentaProd.Text), codProov);

            try
            {
                ConexionBD.EjecutaQuery(Gestion_Productos.Genera_Insert_Productos(productoAgregar));
                MessageBox.Show("Producto agregado con éxito!");
                LimpiaTextbox();
                ActualizaGrilla();
                LimpiaCombo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir el producto: " + ex.Message);
            }
            
            ConexionBD.CierraBD();

        }

        private void btn_EliminarProd_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Producto productoEliminar = new Producto(Convert.ToInt32(lbl_IDArt.Text));

            try
            {
                ConexionBD.EjecutaQuery(Gestion_Productos.Genera_Delete_Productos(productoEliminar));
                MessageBox.Show("Producto eliminado con éxito!");
                LimpiaTextbox();
                ActualizaGrilla();
                LimpiaCombo();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_ModificarProd.Enabled = false;
            btn_EliminarProd.Enabled = false;
            btn_AgregarProd.Enabled = true;
        }

        private void btn_ModificarProd_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Producto productoModificar = new Producto(Convert.ToInt32(lbl_IDArt.Text), txt_CodProducto.Text, txt_DescrProd.Text, Convert.ToInt32(cmbx_Categorias.SelectedValue.ToString()), Convert.ToInt32(cmbx_SubCategorias.SelectedValue.ToString()), Convert.ToInt32(txt_CantProd.Text), txt_PrecioUnitProd.Text, Convert.ToInt32(txt_PrecioVentaProd.Text), Convert.ToInt32(cmbx_ProovProd.SelectedValue.ToString()));

            try
            {
                ConexionBD.EjecutaQuery(Gestion_Productos.Genera_Update_Productos(productoModificar));
                MessageBox.Show("Producto modificado con éxito!");
                LimpiaTextbox();
                ActualizaGrilla();
                LimpiaCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
            }
            ConexionBD.CierraBD();

            btn_ModificarProd.Enabled = false;
            btn_EliminarProd.Enabled = false;
            btn_AgregarProd.Enabled = true;
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila = dgv_Productos.Rows[e.RowIndex];
                lbl_IDArt.Text = fila.Cells["ID_Articulo"].Value.ToString();
                txt_CodProducto.Text = fila.Cells["Cod_Articulo"].Value.ToString();
                txt_DescrProd.Text = fila.Cells["Art_Descrip"].Value.ToString();
                txt_CantProd.Text = fila.Cells["Stock_Articulo"].Value.ToString();
                txt_PrecioUnitProd.Text = fila.Cells["Costo_Articulo"].Value.ToString();
                txt_PrecioVentaProd.Text = fila.Cells["PrecioVenta"].Value.ToString();
                cmbx_Categorias.Text = fila.Cells["categoria"].Value.ToString();
                cmbx_ProovProd.Text = fila.Cells["Nombre_Proovedor"].Value.ToString();
                cmbx_SubCategorias.Text = fila.Cells["Subcategoria"].Value.ToString();

                btn_AgregarProd.Enabled = false;
                btn_EliminarProd.Enabled = true;
                btn_ModificarProd.Enabled = true;


            }
        }
        private void LimpiaCombo()
        {
            cmbx_Categorias.Text = "";
            cmbx_ProovProd.Text = "";
            cmbx_SubCategorias.Text = "";
        }
    }
}
