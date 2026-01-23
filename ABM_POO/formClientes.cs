using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteNegocio;
using ConexionSQL;
using Validaciones;

namespace ABM_POO
{
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();
        }

        Validacion validaciones = new Validacion();

        private void formClientes_Load(object sender, EventArgs e)
        {
            txt_CuitCliente.Focus();
            dgv_Clientes.EnableHeadersVisualStyles = false;
            dgv_Clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgv_Clientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Clientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ConexionBD.ConectarBD();
            dgv_Clientes.DataSource = Gestion_Cliente.Traer_Clientes();
            ConexionBD.CierraBD();
            CambioNombreHeadersDGV();
            btn_ModificarCliente.Enabled = false;
            btn_EliminarCliente.Enabled = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            string estado = "";
            if (rdbtn_Si.Checked)
                estado = "Sí";
            else if (rdbtn_No.Checked)
                estado = "No";


            Cliente clienteAgregar = new Cliente(Convert.ToInt32(txt_CuitCliente.Text), txt_NombreCliente.Text, txt_EntidadCliente.Text, txt_MailCliente.Text, Convert.ToInt32(txt_TelfCliente.Text), txt_DirecCliente.Text, estado);
                try
                {
                ConexionBD.EjecutaQuery(Gestion_Cliente.Genera_insert_cliente(clienteAgregar));
                    MessageBox.Show("Cliente agregado exitosamente!");
                    ActualizaGrilla();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar al cliente" + ex.Message);
                   
                }
            ConexionBD.CierraBD();
        }

        private void ActualizaGrilla()
        {
            dgv_Clientes.DataSource = Gestion_Cliente.Traer_Clientes();
        }

        private void LimpiarCampos()
        {
            txt_CuitCliente.Text = "";
            txt_NombreCliente.Text = "";
            txt_EntidadCliente.Text = "";
            txt_MailCliente.Text = "";
            txt_TelfCliente.Text = "";
            txt_DirecCliente.Text = "";
            rdbtn_Si.Checked = false;
            rdbtn_No.Checked = false;
        }

        private void CambioNombreHeadersDGV()
        {
            dgv_Clientes.Columns["ID_Cliente"].HeaderText = "ID"; 
            dgv_Clientes.Columns["CUIT_Cliente"].HeaderText = "CUIT";
            dgv_Clientes.Columns["Nombre_Cliente"].HeaderText = "Nombre";
            dgv_Clientes.Columns["Entidad_Cliente"].HeaderText = "Entidad";
            dgv_Clientes.Columns["Telf_Cliente"].HeaderText = "Teléfono";
            dgv_Clientes.Columns["Mail_Cliente"].HeaderText = "Email";
            dgv_Clientes.Columns["Direc_Cliente"].HeaderText = "Dirección";
            dgv_Clientes.Columns["Estado_Cliente"].HeaderText = "Activo?";
        }

        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            {
                if (e.RowIndex >= 0)
                {
                   
                    DataGridViewRow fila = dgv_Clientes.Rows[e.RowIndex];

                    lbl_IDCliente.Text = fila.Cells["ID_Cliente"].Value.ToString();
                    txt_CuitCliente.Text = fila.Cells["CUIT_Cliente"].Value.ToString();
                    txt_NombreCliente.Text = fila.Cells["Nombre_Cliente"].Value.ToString();
                    txt_EntidadCliente.Text = fila.Cells["Entidad_Cliente"].Value.ToString();
                    txt_MailCliente.Text = fila.Cells["Mail_Cliente"].Value.ToString();
                    txt_TelfCliente.Text = fila.Cells["Telf_Cliente"].Value.ToString();
                    txt_DirecCliente.Text = fila.Cells["Direc_Cliente"].Value.ToString();

                    if (fila.Cells["Estado_Cliente"].Value.ToString() == "Sí")
                        rdbtn_Si.Checked = true;
                    else if (fila.Cells["Estado_Cliente"].Value.ToString() == "No")
                        rdbtn_No.Checked = true;

                    btn_AgregarCliente.Enabled = false;
                    btn_BorrarCampos.Enabled = false;
                    btn_ModificarCliente.Enabled = true;
                    btn_EliminarCliente.Enabled = true;

                    //Cliente clienteAModificar = new Cliente(Convert.ToInt32(fila.Cells["ID_Cliente"].Value.ToString()), 
                    //    Convert.ToInt32(txt_CuitCliente.Text),
                    //    txt_NombreCliente.Text,
                    //    txt_EntidadCliente.Text,
                    //    txt_MailCliente.Text,
                    //    Convert.ToInt32(txt_TelfCliente.Text),
                    //    txt_DirecCliente.Text,
                    //    estado);
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Cliente clienteModificar = new Cliente(Convert.ToInt32(lbl_IDCliente.Text), Convert.ToInt32(txt_CuitCliente.Text), txt_NombreCliente.Text, txt_EntidadCliente.Text, txt_MailCliente.Text, Convert.ToInt32(txt_TelfCliente.Text), txt_DirecCliente.Text, rdbtn_Si.Checked ? "Sí": "No");
                
            try
            {
                //MessageBox.Show("Cliente a modificar: " + txt_CuitCliente.Text);
                ConexionBD.EjecutaQuery(Gestion_Cliente.Genera_update_cliente(clienteModificar));
                MessageBox.Show("Cliente modificado!");
                ActualizaGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_AgregarCliente.Enabled = true;
            btn_ModificarCliente.Enabled = false;
            btn_EliminarCliente.Enabled = false;
            btn_BorrarCampos.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            Cliente clienteEliminar = new Cliente(Convert.ToInt32(lbl_IDCliente.Text));
            try
            {
                
                ConexionBD.EjecutaQuery(Gestion_Cliente.Genera_delete_cliente(clienteEliminar));
                MessageBox.Show("Cliente eliminado!");
                ActualizaGrilla();
                LimpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
            ConexionBD.CierraBD();
            btn_AgregarCliente.Enabled = true;
            btn_ModificarCliente.Enabled = false;
            btn_EliminarCliente.Enabled = false;
            btn_BorrarCampos.Enabled = true;

        }

        private void btn_BorrarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_CuitCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) == true || e.KeyChar == 08))
            {
                e.Handled = true;
            }
        }

        private void txt_NombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }


        private void txt_MailCliente_Validating(object sender, CancelEventArgs e)
        {
            if (!validaciones.validaCorreo(txt_MailCliente.Text) == true)
            {
                MessageBox.Show("El email ingresado no tiene un formato válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MailCliente.Focus();
            }
        }

        private void txt_TelfCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) == true || e.KeyChar == 08))
            {
                e.Handled = true;
            }
        }
    }
}
