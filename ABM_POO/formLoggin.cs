using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM_POO
{
    public partial class formLoggin : Form
    {
        public bool loginCorrecto { get; set; } = false;

        public formLoggin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txt_Usuario.Text == "admin" && txt_Contrasenia.Text == "1234")
            {
                loginCorrecto = true;
                this.Close();
            }
            else
                MessageBox.Show("Usuario o contraseña incorrectos!");

        }

        private void txt_Contrasenia_TextChanged(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = true;
        }
    }
}
