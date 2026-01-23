using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM_POO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formLoggin Logueo = new formLoggin();
            Application.Run(Logueo);

            if (Logueo.loginCorrecto)
                Application.Run(new form_Principal());
        }
    }
}
