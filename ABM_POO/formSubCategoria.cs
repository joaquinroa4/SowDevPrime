using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubCategoriaNegocio;
using ConexionSQL;

namespace ABM_POO
{
    public partial class formSubCategoria : Form
    {
        public formSubCategoria()
        {
            InitializeComponent();
        }

        private void btn_CancelarCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formSubCategoria_Load(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            cmbx_Cat.DataSource = Gestion_Subcategoria.Traer_Categorias();
            cmbx_Cat.ValueMember = "ID_Categoria";
            cmbx_Cat.DisplayMember = "categoria";
            cmbx_SubCat.DataSource = Gestion_Subcategoria.Traer_Subcategorias();
            cmbx_SubCat.ValueMember = "ID_SubCateg";
            cmbx_SubCat.DisplayMember = "Subcategoria";
            ConexionBD.CierraBD();
            txt_SubcatDesc.Text = "";
            btn_AgregarSubcat.Enabled = true;
            btn_ModificarSubcat.Enabled = false;
            btn_EliminarSubcat.Enabled = false;
        }

        private void ActualizaCombo()
        {
            cmbx_SubCat.DataSource = Gestion_Subcategoria.Traer_Subcategorias();
        }

        private void btn_AgregarSubcat_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            SubCategoria subcatAgregar = new SubCategoria(txt_SubcatDesc.Text, Convert.ToInt32(cmbx_Cat.SelectedValue.ToString()));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Subcategoria.Genera_Insert_Subcategoria(subcatAgregar));
                MessageBox.Show("Subcategoría añadida exitosamente!");
                ActualizaCombo();
                txt_SubcatDesc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir Subcategoría: " + ex.Message);
            }
            ConexionBD.CierraBD();
        }

        private void btn_ModificarSubcat_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            SubCategoria subcatModificar = new SubCategoria(Convert.ToInt32(cmbx_SubCat.SelectedValue.ToString()), txt_SubcatDesc.Text, Convert.ToInt32(cmbx_Cat.SelectedValue.ToString()));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Subcategoria.Genera_Update_Subcategoria(subcatModificar));
                MessageBox.Show("Subcategoría modificada exitosamente!");
                ActualizaCombo();
                txt_SubcatDesc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Subcategoría: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_AgregarSubcat.Enabled = true;
            btn_EliminarSubcat.Enabled = false;
            btn_ModificarSubcat.Enabled = false;
        }

        private void btn_EliminarSubcat_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            SubCategoria artModificar = new SubCategoria(Convert.ToInt32(cmbx_SubCat.SelectedValue.ToString()));
            SubCategoria subcatEliminar = new SubCategoria(Convert.ToInt32(cmbx_SubCat.SelectedValue.ToString()));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Subcategoria.Genera_Update_Art(artModificar));
                ConexionBD.EjecutaQuery(Gestion_Subcategoria.Genera_Delete_Subcategoria(subcatEliminar));
                MessageBox.Show("Subcategoría eliminada exitosamente!");
                ActualizaCombo();
                txt_SubcatDesc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Subcategoría: " + ex.Message);

            }
            ConexionBD.CierraBD();
            btn_AgregarSubcat.Enabled = true;
            btn_EliminarSubcat.Enabled = false;
            btn_ModificarSubcat.Enabled = false;
        }

        private void cmbx_SubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_SubcatDesc.Text = cmbx_SubCat.Text;
            if (!(txt_SubcatDesc.Text == "Sin Subcategoría" && lbl_CatDesc.Text == "Sin Categoría"))
            {
                txt_SubcatDesc.Enabled = true;
                btn_ModificarSubcat.Enabled = true;
                btn_EliminarSubcat.Enabled = true;
                btn_AgregarSubcat.Enabled = false;
            }
            else
            {
                btn_ModificarSubcat.Enabled = false;
                btn_EliminarSubcat.Enabled = false;
                btn_AgregarSubcat.Enabled = false;
            }
            
        }

        private void txt_SubcatDesc_TextChanged(object sender, EventArgs e)
        {
            if(txt_SubcatDesc.Text == "")
            {
                btn_AgregarSubcat.Enabled = true;
                btn_EliminarSubcat.Enabled = false;
                btn_ModificarSubcat.Enabled = false;
            }
        }

        private void cmbx_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_CatDesc.Text = cmbx_Cat.Text;
            /*cmbx_Cat.SelectedIndexChanged -= cmbx_Cat_TextChanged*/;

           // int catID;
            //catID = Convert.ToInt32(cmbx_Cat.SelectedValue.ToString());
            //ConexionBD.ConectarBD();
           // Categoria catCondicion = new Categoria(catID);
            //cmbx_SubCat.DataSource = Gestion_Subcategoria.Traer_SubcategoriasXCategoria(catCondicion);
            //if (lbl_CatDesc.Text == "Sin Categoría")
            //{
            //    btn_ModificarSubcat.Enabled = false;
            //    btn_EliminarSubcat.Enabled = false;
            //    btn_AgregarSubcat.Enabled = false;
            //}
        }
    }
}
