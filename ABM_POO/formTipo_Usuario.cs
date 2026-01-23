using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TipoUsuarioNegocio;
using ConexionSQL;

namespace ABM_POO
{
    public partial class formTipo_Usuario : Form
    {
        public formTipo_Usuario()
        {
            InitializeComponent();
        }

        private void formTipo_Usuario_Load(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            cmbx_Roles.DataSource = Gestion_TipoUsuario.Traer_Roles();
            cmbx_Roles.ValueMember = "ID_Usuario_Tipo";
            cmbx_Roles.DisplayMember = "Usuario_Desc";
            ConexionBD.CierraBD();
            btn_AgregarRol.Enabled = true;
            btn_EliminarRol.Enabled = false;
            btn_ModificarRol.Enabled = false;
        }

        private void ActualizaCombo()
        {
            cmbx_Roles.DataSource = Gestion_TipoUsuario.Traer_Roles();
        }

        private void btn_AgregarRol_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            TipoUsuario RolAgregar = new TipoUsuario(txt_AgregaEditaRol.Text);
            try
            {
                ConexionBD.EjecutaQuery(Gestion_TipoUsuario.Genera_Insert_Roles(RolAgregar));
                MessageBox.Show("Rol agregado exitosamente!");
                ActualizaCombo();
                txt_AgregaEditaRol.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Rol" + ex.Message);
            }
            ConexionBD.CierraBD();
        }

        private void btn_ModificarRol_Click(object sender, EventArgs e)
        {
            
            ConexionBD.ConectarBD();
            TipoUsuario RolModificar = new TipoUsuario(Convert.ToInt32(cmbx_Roles.SelectedValue.ToString()), txt_AgregaEditaRol.Text);
            try
            {
                ConexionBD.EjecutaQuery(Gestion_TipoUsuario.Genera_Update_Roles(RolModificar));
                MessageBox.Show("Rol modificado exitosamente!");
                ActualizaCombo();
                txt_AgregaEditaRol.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Rol" + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_EliminarRol.Enabled = false;
            btn_ModificarRol.Enabled = false;
            btn_AgregarRol.Enabled = true;
        }

        private void cmbx_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_AgregaEditaRol.Text = cmbx_Roles.Text;
            btn_ModificarRol.Enabled = true;
            btn_EliminarRol.Enabled = true;
            btn_AgregarRol.Enabled = false;
        }

        private void btn_EliminarRol_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            TipoUsuario RolEliminar = new TipoUsuario(Convert.ToInt32(cmbx_Roles.SelectedValue.ToString()));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_TipoUsuario.Genera_Delete_Roles(RolEliminar));
                MessageBox.Show("Rol eliminado con éxito!");
                ActualizaCombo();
                txt_AgregaEditaRol.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar el Rol" + ex.Message);
            }
            ConexionBD.CierraBD();

            btn_EliminarRol.Enabled = false;
            btn_ModificarRol.Enabled = false;
            btn_AgregarRol.Enabled = true;
        }

        private void btn_SalirRol_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void txt_AgregaEditaRol_TextChanged(object sender, EventArgs e)
        {
            if(txt_AgregaEditaRol.Text == "")
            {
                btn_EliminarRol.Enabled = false;
                btn_ModificarRol.Enabled = false;
                btn_AgregarRol.Enabled = true;
            }
            
        }
    }
}
