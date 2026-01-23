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
using System.Runtime.InteropServices;

namespace ABM_POO
{
    public partial class form_Principal : Form
    {
 
        
        public form_Principal()
        {
            InitializeComponent();
        }

        #region Método para poder invocar Forms Hijos
        private void AbrirFormHijo (object FormHijo)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
        }
        #endregion


        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Botones para maximizar y restaurar comentados
        //#region Botón Maximizar
        //private void btn_Maximizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //    btn_Maximizar.Visible = false;
        //    btn_Restaurar.Visible = true;
        //}
        //#endregion

        //#region Botón Agrandar
        //private void btn_Restaurar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    btn_Restaurar.Visible = false;
        //    btn_Maximizar.Visible = true;
        //}
        //#endregion

        #endregion

        private void form_Principal_Load(object sender, EventArgs e)
        {
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = false;
            AbrirFormHijo(new formInicio());
        }
        #region Botón Minimizar
        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new formProductos());
            //if (ventanaProductos == null || ventanaProductos.IsDisposed)
            //{
            //    ventanaProductos = new formProductos();
            //    ventanaProductos.Show();
            //}
            //else
            //{
            //    ventanaProductos.BringToFront();
            //    ventanaProductos.Show();
            //}
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new formVentas());
        }

        #region Código para poder mover el formulario desde la barra de título
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void panel_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion 

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new formClientes());
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new formUsuarios());
        }

        private void btn_Balance_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new formIngreso_Egreso());
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new formCompras());
        }

        private void btn_RRHH_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new formRRHH());
        }
    }
}
