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
using System.Data.SqlClient;
using CompraNegocio;

namespace ABM_POO
{
    public partial class formCompras : Form
    {
        public formCompras()
        {
            InitializeComponent();
        }

        int idProovedor = 0;

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lbl_FechaHora.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void InhabilitaTextbox()
        {
            gpbx_DatosProov.Enabled = false;
            txt_CuitBuscar.Enabled = false;
        }

        private void cmbx_TipoProov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_TipoProov.SelectedItem.ToString() == "Proovedor Existente")
            {
                lbl_CuitBuscar.Visible = true;
                txt_CuitBuscar.Visible = true;
                btn_Buscar.Visible = true;
                panelBtnBuscar.Visible = true;
                gpbx_DatosProov.Enabled = false;
            }
            else
            {
                lbl_CuitBuscar.Visible = false;
                txt_CuitBuscar.Visible = false;
                btn_Buscar.Visible = false;
                panelBtnBuscar.Visible = false;
                gpbx_DatosProov.Enabled = true;
                LimpiaTextboxProovedor();
            }
        }

        private void LimpiaTextboxProovedor()
        {
            txt_CuitProov.Text = "";
            txt_DirecProov.Text = "";
            txt_EmailProov.Text = "";
            txt_NombreProov.Text = "";
            txt_TelfProov.Text = "";
        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            panelBtnBuscar.Visible = false;
            lbl_CuitBuscar.Visible = false;
            txt_CuitBuscar.Visible = false;
            btn_Buscar.Visible = false;
            gpbx_DatosProov.Enabled = false;
            gpbx_DatosCompra.Enabled = false;
            propiedadesDGV();
            cmbx_Compradores.DataSource = Gestion_H_Compra.Traer_Compradores();
            cmbx_Compradores.ValueMember = "ID_Usuario";
            cmbx_Compradores.DisplayMember = "Nombre_Usuario";
            ConexionBD.CierraBD();
        }

        private void propiedadesDGV()
        {
            dgv_Arts.DefaultCellStyle.Font = new Font("Arial", 12);
            dgv_Arts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_Arts.ColumnHeadersHeight = 15;
            dgv_Arts.RowTemplate.Height = 15;
            dgv_Arts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Arts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Arts.DefaultCellStyle.ForeColor = Color.Black;
            dgv_Arts.DefaultCellStyle.BackColor = Color.White;

        }

        private void btn_CancelarRemito_Click(object sender, EventArgs e)
        {
            LimpiaTextboxProovedor();
        }

        private void btn_GuardarRemito_Click(object sender, EventArgs e)
        {
            gpbx_DatosProov.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            ConexionBD.ConectarBD();
            BuscaProovedores(Convert.ToInt32(txt_CuitBuscar.Text));
            InhabilitaTextbox();
            ConexionBD.CierraBD();
            gpbx_DatosCompra.Enabled = true;
            btn_Cancelar.Enabled = true;
        }

        private void BuscaProovedores(int CUIT)
        {
            string query = " SELECT[ID_Proovedor], [Cuit_Proovedor], [Nombre_Proovedor], [Telf_Proovedor],[Email_Proovedor], [Direc_Proovedor] FROM [dbo].[Proovedores] where [Cuit_Proovedor] = " + CUIT;

            SqlDataReader Lector = ConexionBD.LecturaBD(query);
            if (Lector.Read())
            {
                idProovedor = Convert.ToInt32(Lector["ID_Proovedor"].ToString());
                txt_CuitProov.Text = Lector["Cuit_Proovedor"].ToString();
                txt_NombreProov.Text = Lector["Nombre_Proovedor"].ToString();
                txt_TelfProov.Text = Lector["Telf_Proovedor"].ToString();
                txt_EmailProov.Text = Lector["Email_Proovedor"].ToString();
                txt_DirecProov.Text = Lector["Direc_Proovedor"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró al proovedor indicado. Se procederá con la compra");
                txt_CuitProov.Text = txt_CuitBuscar.Text;
                txt_DirecProov.Text = "";
                txt_EmailProov.Text = "";
                txt_NombreProov.Text = "";
                txt_TelfProov.Text = "";
            }
            Lector.Close();

        }

        private void Proovedor_Nuevo()
        {
            int cuit = Convert.ToInt32(txt_CuitProov.Text);
            string nombre = txt_NombreProov.Text;
            string telefono = txt_TelfProov.Text;
            string email = txt_EmailProov.Text;
            string direccion = txt_DirecProov.Text;

            ConexionBD.ConectarBD();
            Proovedor proovedorNuevo = new Proovedor(cuit, nombre, telefono, email, direccion);
            try
            {
                ConexionBD.EjecutaQuery(Gestion_H_Compra.Proovedor_Nuevo(proovedorNuevo));

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el proovedor:" + ex.Message);

            }

        }
    }
}
