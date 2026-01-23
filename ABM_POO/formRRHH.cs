using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABM_POO;

namespace ABM_POO
{
    public partial class formRRHH : Form
    {
        public formRRHH()
        {
            InitializeComponent();
        }

        formUsuarios ventanaUsuarios;
        formClientes ventanaClientes;
        formProovedores ventanaProovedores;
        private void btn_ModuloUsuarios_Click(object sender, EventArgs e)
        {
            if (ventanaUsuarios == null || ventanaUsuarios.IsDisposed)
            {
                ventanaUsuarios = new formUsuarios();
                ventanaUsuarios.Show();
            }
            else
            {
                ventanaUsuarios.BringToFront();
                ventanaUsuarios.Show();
            }
        }

        private void btn_ModuloClientes_Click(object sender, EventArgs e)
        {
            if (ventanaClientes == null || ventanaClientes.IsDisposed)
            {
                ventanaClientes = new formClientes();
                ventanaClientes.Show();
            }
            else
            {
                ventanaClientes.BringToFront();
                ventanaClientes.Show();
            }
        }

        private void btn_ModuloProov_Click(object sender, EventArgs e)
        {
            if (ventanaProovedores == null || ventanaProovedores.IsDisposed)
            {
                ventanaProovedores = new formProovedores();
                ventanaProovedores.Show();
            }
            else
            {
                ventanaProovedores.BringToFront();
                ventanaProovedores.Show();
            }
        }
    }
}
