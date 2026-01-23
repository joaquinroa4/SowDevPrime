using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProovedorNegocio;
using ConexionSQL;
using Validaciones;

namespace ABM_POO
{
    public partial class formProovedores : Form
    {
        public formProovedores()
        {
            InitializeComponent();
        }

        Validacion validaciones = new Validacion();

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarCampos()
        {
            txt_CuitProov.Text = "";
            txt_NombreProov.Text = "";
            txt_EmailProov.Text = "";
            txt_TelfProov.Text = "";
            rdbtn_Si.Checked = false;
            rdbtn_No.Checked = false;
        }

        private void formProovedores_Load(object sender, EventArgs e)
        {
            txt_CuitProov.Focus();
            dgv_Proovedores.EnableHeadersVisualStyles = false;
            dgv_Proovedores.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv_Proovedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Proovedores.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ConexionBD.ConectarBD();
            dgv_Proovedores.DataSource = Gestion_Proovedor.Trae_Proovedores();
            ConexionBD.CierraBD();
            CambiaNombresHeader();
            btn_EliminarProov.Enabled = false;
            btn_ModificarProov.Enabled = false;

        }

        private void CambiaNombresHeader()
        {
            dgv_Proovedores.Columns["ID_Proovedor"].HeaderText = "ID";
            dgv_Proovedores.Columns["Cuit_Proovedor"].HeaderText = "CUIT";
            dgv_Proovedores.Columns["Nombre_Proovedor"].HeaderText = "Nombre";
            dgv_Proovedores.Columns["Telf_Proovedor"].HeaderText = "Teléfono";
            dgv_Proovedores.Columns["Email_Proovedor"].HeaderText = "Email";
            dgv_Proovedores.Columns["Direc_Proovedor"].HeaderText = "Dirección";
            dgv_Proovedores.Columns["Estado_Proovedor"].HeaderText = "Activo?";
        }

        private void btn_AgregarProov_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            string estado = "";
            if (rdbtn_Si.Checked)
                estado = "Sí";
            else if (rdbtn_No.Checked)
                estado = "No";
            Proovedor proovAgregar = new Proovedor(Convert.ToInt32(txt_CuitProov.Text), txt_NombreProov.Text, Convert.ToInt32(txt_TelfProov.Text), txt_EmailProov.Text, txt_Direc.Text, estado);
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Proovedor.Genera_Insert_Proov(proovAgregar));
                MessageBox.Show("Proovedor Agregado con éxito!");
                ActualizaGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Proovedor: " + ex.Message);
            }
            ConexionBD.CierraBD();
        }

        private void ActualizaGrilla()
        {
            dgv_Proovedores.DataSource = Gestion_Proovedor.Trae_Proovedores();
        }

        private void btn_ModificarProov_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();

            Proovedor proovModificar = new Proovedor(Convert.ToInt32(lbl_IDProov.Text), Convert.ToInt32(txt_CuitProov.Text), txt_NombreProov.Text, Convert.ToInt32(txt_TelfProov.Text), txt_EmailProov.Text, txt_Direc.Text, rdbtn_Si.Checked ? "Sí" : "No");
            try
            {

                ConexionBD.EjecutaQuery(Gestion_Proovedor.Genera_Update_Proov(proovModificar));
                MessageBox.Show("Proovedor modificado con éxito!");
                ActualizaGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Proovedor: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_AgregarProov.Enabled = true;
            btn_EliminarProov.Enabled = false;
            btn_ModificarProov.Enabled = false;
        }



        private void btn_EliminarProov_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Proovedor artModificar = new Proovedor(Convert.ToInt32(lbl_IDProov.Text));
            Proovedor proovEliminar = new Proovedor(Convert.ToInt32(lbl_IDProov.Text));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Proovedor.Genera_Update_Art(artModificar));
                ConexionBD.EjecutaQuery(Gestion_Proovedor.Genera_Delete_Proov(proovEliminar));
                MessageBox.Show("Proovedor eliminado con éxito!");
                ActualizaGrilla();
                LimpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar el Proovedor: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_AgregarProov.Enabled = true;
            btn_EliminarProov.Enabled = false;
            btn_ModificarProov.Enabled = false;
        }

        private void dgv_Proovedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila = dgv_Proovedores.Rows[e.RowIndex];

                lbl_IDProov.Text = fila.Cells["ID_Proovedor"].Value.ToString();
                txt_CuitProov.Text = fila.Cells["Cuit_Proovedor"].Value.ToString();
                txt_NombreProov.Text = fila.Cells["Nombre_Proovedor"].Value.ToString();
                txt_EmailProov.Text = fila.Cells["Email_Proovedor"].Value.ToString();
                txt_TelfProov.Text = fila.Cells["Telf_Proovedor"].Value.ToString();
                if (fila.Cells["Estado_Proovedor"].Value.ToString() == "Sí")
                    rdbtn_Si.Checked = true;
                else if (fila.Cells["Estado_Proovedor"].Value.ToString() == "No")
                    rdbtn_No.Checked = true;

                btn_AgregarProov.Enabled = false;
                btn_EliminarProov.Enabled = true;
                btn_ModificarProov.Enabled = true;
            }
        }

        private void txt_CuitProov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) == true || e.KeyChar == 08))
            {
                e.Handled = true;
            }
        }

        private void txt_EmailProov_Validating(object sender, CancelEventArgs e)
        {
            if (!validaciones.validaCorreo(txt_EmailProov.Text) == true)
            {
                MessageBox.Show("El email ingresado no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_EmailProov.Focus();
            }
        }

        private void txt_TelfProov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) == true || e.KeyChar == 08))
            {
                e.Handled = true;
            }

        }

        private void txt_NombreProov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
