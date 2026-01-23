using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CategoriaNegocio;
using ConexionSQL;

namespace ABM_POO
{
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
        }

        private void btn_CancelarCat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void formCategoria_Load(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            cmbx_Categorias.DataSource = Gestion_Categoria.Traer_Categorias();
            cmbx_Categorias.DisplayMember = "categoria";
            cmbx_Categorias.ValueMember = "ID_Categoria";
            ConexionBD.CierraBD();
            btn_EliminarCat.Enabled = false;
            btn_ModificarCat.Enabled = false;
            txt_DescCat.Text = "";
        }

        private void ActualizaCombo()
        {
            cmbx_Categorias.DataSource = Gestion_Categoria.Traer_Categorias();
        }

        private void LimpiaCampos()
        {
            txt_DescCat.Text = "";
        }

        private void btn_AgregarCat_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            if (!(txt_DescCat.Text == ""))
            {
                Categoria catAgregar = new Categoria(txt_DescCat.Text);
                try
                {
                    ConexionBD.EjecutaQuery(Gestion_Categoria.Genera_Insert_Categoria(catAgregar));
                    MessageBox.Show("Categoría añadida exitosamente!");
                    LimpiaCampos();
                    ActualizaCombo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al añadir la categoría: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se pueden agregar Categorías vacías!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            ConexionBD.CierraBD();
        }

        private void btn_ModificarCat_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Categoria catModificar = new Categoria(Convert.ToInt32(cmbx_Categorias.SelectedValue.ToString()), txt_DescCat.Text);
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Categoria.Genera_Update_Categoria(catModificar));
                MessageBox.Show("Categoría modificada exitosamente!");
                LimpiaCampos();
                ActualizaCombo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la categoría: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_ModificarCat.Enabled = false;
            btn_EliminarCat.Enabled = false;
            btn_AgregarCat.Enabled = true;

        }

        private void btn_EliminarCat_Click(object sender, EventArgs e)
        {

            ConexionBD.ConectarBD();
            Categoria subcategModifica = new Categoria(Convert.ToInt32(cmbx_Categorias.SelectedValue.ToString())); Categoria artModificar = new Categoria(Convert.ToInt32(cmbx_Categorias.SelectedValue.ToString()));
            Categoria catEliminar = new Categoria(Convert.ToInt32(cmbx_Categorias.SelectedValue.ToString()));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Categoria.Genera_Update_Art(artModificar));
                ConexionBD.EjecutaQuery(Gestion_Categoria.Genera_Update_SubCat(subcategModifica));
                ConexionBD.EjecutaQuery(Gestion_Categoria.Genera_Delete_Categoria(catEliminar));
                MessageBox.Show("Categoría eliminada exitosamente!");
                ActualizaCombo();
                LimpiaCampos();
                btn_ModificarCat.Enabled = false;
                btn_EliminarCat.Enabled = false;
                btn_AgregarCat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                btn_ModificarCat.Enabled = false;
                btn_EliminarCat.Enabled = false;
                btn_AgregarCat.Enabled = true;
            }
            ConexionBD.CierraBD();
        }
           
        private void cmbx_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_DescCat.Text = cmbx_Categorias.Text;
            if (!(txt_DescCat.Text == "Sin Categoría"))
            {
                txt_DescCat.Enabled = true;
                btn_ModificarCat.Enabled = true;
                btn_EliminarCat.Enabled = true;
                btn_AgregarCat.Enabled = false;
            }
            else
            {
                txt_DescCat.Enabled = false;
                btn_ModificarCat.Enabled = false;
                btn_EliminarCat.Enabled = false;
                btn_AgregarCat.Enabled = false;
            }
        }

        private void txt_DescCat_TextChanged(object sender, EventArgs e)
        {
            if (txt_DescCat.Text == "")
            {
                btn_ModificarCat.Enabled = false;
                btn_EliminarCat.Enabled = false;
                btn_AgregarCat.Enabled = true;

            }
        }
    }
}
