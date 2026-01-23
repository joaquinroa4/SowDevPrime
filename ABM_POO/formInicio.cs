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
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
        }

        private void lbl_Hora_Click(object sender, EventArgs e)
        {

        }
    }
}
