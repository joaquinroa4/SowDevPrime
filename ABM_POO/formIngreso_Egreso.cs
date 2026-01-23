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
    public partial class formIngreso_Egreso : Form
    {
        public formIngreso_Egreso()
        {
            InitializeComponent();
        }

        formBalance ventanaBalance;

        private void btn_BalanceGeneral_Click(object sender, EventArgs e)
        {
            if (ventanaBalance == null || ventanaBalance.IsDisposed)
            {
                ventanaBalance = new formBalance();
                ventanaBalance.Show();
            }
            else
            {
                ventanaBalance.BringToFront();
                ventanaBalance.Show();
            }
        }
    }
}
