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
using UsuarioNegocio;
using Validaciones;

namespace ABM_POO
{
    public partial class formUsuarios : Form
    {
        public formUsuarios()
        {
            InitializeComponent();
        }
        formTipo_Usuario ventanaRol;
        Validacion validaciones = new Validacion();

        private void btn_AgregarRol_Click(object sender, EventArgs e)
        {
            if (ventanaRol == null || ventanaRol.IsDisposed)
            {
                ventanaRol = new formTipo_Usuario();
                ventanaRol.ShowDialog();

            }
            else
            {
                ventanaRol.BringToFront();
                ventanaRol.ShowDialog();
            }
            CargarRoles();
        }

        private void formUsuarios_Load(object sender, EventArgs e)
        {
            txt_CuitUsuario.Focus();
            dgv_Usuarios.EnableHeadersVisualStyles = false;
            dgv_Usuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv_Usuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Usuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ConexionBD.ConectarBD();
            dgv_Usuarios.DataSource = Gestion_Usuario.Traer_Usuarios();
            cmbx_TipoUsuario.DataSource = Gestion_Usuario.Traer_Roles();
            cmbx_TipoUsuario.ValueMember = "ID_Usuario_Tipo";
            cmbx_TipoUsuario.DisplayMember = "Usuario_Desc";
            ConexionBD.CierraBD();
            CambiaNombresHeader();
            btn_EliminarUsuario.Enabled = false;
            btn_ModificarUsuario.Enabled = false;
            dgv_Usuarios.Columns["Contrasenia_Usuario"].Visible = false;
        }
        private void CambiaNombresHeader()
        {
            dgv_Usuarios.Columns["ID_Usuario"].HeaderText = "ID";
            dgv_Usuarios.Columns["Dni_Usuario"].HeaderText = "DNI";
            dgv_Usuarios.Columns["Nombre_Usuario"].HeaderText = "Nombre";
            dgv_Usuarios.Columns["Apellido_Usuario"].HeaderText = "Apellido";
            dgv_Usuarios.Columns["Telf_Usuario"].HeaderText = "Teléfono";
            dgv_Usuarios.Columns["Mail_Usuario"].HeaderText = "Email";
            dgv_Usuarios.Columns["Direccion_Usuario"].HeaderText = "Dirección";
            dgv_Usuarios.Columns["User_Usuario"].HeaderText = "Usuario";
            dgv_Usuarios.Columns["Usuario_Desc"].HeaderText = "Rol";

        }

        private void LimpiarCampos()
        {
            txt_CuitUsuario.Text = "";
            cmbx_TipoUsuario.Text = "";
            txt_ApellidoUsuario.Text = "";
            txt_NombreUsuario.Text = "";
            txt_EmailUsuario.Text = "";
            txt_TelfUsuario.Text = "";
            txt_UserUsuario.Text = "";
            txt_PasswordUsuario.Text = "";
            txt_DirecUsuario.Text = "";
        }

        private void CargarRoles()
        {
            ConexionBD.ConectarBD();
            cmbx_TipoUsuario.DataSource = Gestion_Usuario.Traer_Roles();
            cmbx_TipoUsuario.ValueMember = "ID_Usuario_Tipo";
            cmbx_TipoUsuario.DisplayMember = "Usuario_Desc";
            ConexionBD.CierraBD();
        }

        private void btn_verPassword_Click(object sender, EventArgs e)
        {
            txt_PasswordUsuario.UseSystemPasswordChar = !txt_PasswordUsuario.UseSystemPasswordChar;
        }



        private void dgv_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila = dgv_Usuarios.Rows[e.RowIndex];
                lbl_IDUsuario.Text = fila.Cells["ID_Usuario"].Value.ToString();
                txt_CuitUsuario.Text = fila.Cells["Dni_Usuario"].Value.ToString();
                cmbx_TipoUsuario.SelectedItem = fila.Cells["Usuario_Desc"].Value.ToString();
                txt_ApellidoUsuario.Text = fila.Cells["Apellido_Usuario"].Value.ToString();
                txt_NombreUsuario.Text = fila.Cells["Nombre_Usuario"].Value.ToString();
                txt_EmailUsuario.Text = fila.Cells["Mail_Usuario"].Value.ToString();
                txt_TelfUsuario.Text = fila.Cells["Telf_Usuario"].Value.ToString();
                txt_DirecUsuario.Text = fila.Cells["Direccion_Usuario"].Value.ToString();
                txt_UserUsuario.Text = fila.Cells["User_Usuario"].Value.ToString();
                txt_PasswordUsuario.Text = fila.Cells["Contrasenia_Usuario"].Value.ToString();

                btn_AgregarUsuario.Enabled = false;
                btn_BorrarCampos.Enabled = false;
                btn_ModificarUsuario.Enabled = true;
                btn_EliminarUsuario.Enabled = true;
            }
        }

        private void btn_AgregarUsuario_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Usuario usuarioAgregar = new Usuario(Convert.ToInt32(txt_CuitUsuario.Text), Convert.ToInt32(cmbx_TipoUsuario.SelectedValue.ToString()), txt_ApellidoUsuario.Text, txt_NombreUsuario.Text, txt_EmailUsuario.Text, txt_DirecUsuario.Text, Convert.ToInt32(txt_TelfUsuario.Text), txt_UserUsuario.Text, txt_PasswordUsuario.Text);
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Usuario.Genera_Insert_Usuarios(usuarioAgregar));
                MessageBox.Show("Usuario agregado correctamente!");
                ActualizaGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Usuario" + ex.Message);
            }
            ConexionBD.CierraBD();
        }

        private void ActualizaGrilla()
        {
            dgv_Usuarios.DataSource = Gestion_Usuario.Traer_Usuarios();
        }

        private void btn_ModificarUsuario_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Usuario usuarioModificar = new Usuario(Convert.ToInt32(lbl_IDUsuario.Text), Convert.ToInt32(txt_CuitUsuario.Text), Convert.ToInt32(cmbx_TipoUsuario.SelectedValue.ToString()), txt_ApellidoUsuario.Text, txt_NombreUsuario.Text, txt_EmailUsuario.Text, txt_DirecUsuario.Text, Convert.ToInt32(txt_TelfUsuario.Text), txt_UserUsuario.Text, txt_PasswordUsuario.Text);

            try
            {
                ConexionBD.EjecutaQuery(Gestion_Usuario.Genera_Update_Usuarios(usuarioModificar));
                MessageBox.Show("Usuario modificado exitosamente!");
                ActualizaGrilla();
                LimpiarCampos();
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_AgregarUsuario.Enabled = true;
            btn_BorrarCampos.Enabled = true;
            btn_ModificarUsuario.Enabled = false;
            btn_EliminarUsuario.Enabled = false;
        }

        private void btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Usuario usuarioEliminar = new Usuario(Convert.ToInt32(lbl_IDUsuario.Text));
            try
            {
                ConexionBD.EjecutaQuery(Gestion_Usuario.Genera_Delete_Usuarios(usuarioEliminar));
                MessageBox.Show("Usuario eliminado con éxito!");
                ActualizaGrilla();
                LimpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_AgregarUsuario.Enabled = true;
            btn_BorrarCampos.Enabled = true;
            btn_ModificarUsuario.Enabled = false;
            btn_EliminarUsuario.Enabled = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_CuitUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) == true || e.KeyChar == 08))
            {
                e.Handled = true;
            }
        }

        private void txt_ApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txt_NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txt_EmailUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (!validaciones.validaCorreo(txt_EmailUsuario.Text) == true)
            {
                MessageBox.Show("El email ingresado no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_EmailUsuario.Focus();
            }
        }

        private void txt_TelfUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) == true || e.KeyChar == 08))
            {
                e.Handled = true;
            }
        }

        private void txt_DirecUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) == true) && (e.KeyChar == 32) && (char.IsNumber(e.KeyChar) == true))
            {
                e.Handled = true;
            }
        }
    }
}
