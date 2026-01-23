using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validaciones
{
    public class Validacion
    {
        public bool confirmaNumero;
        public bool confirmaTexto;
        public bool confirmaCorreo;

        public bool ValidaNumero(string textoAValidar)
        {
            foreach (char x in textoAValidar)
            {
                if (char.IsDigit(x))
                {
                    confirmaNumero = true;
                    break;
                }
            }
            return confirmaNumero;
        }

        public bool ValidaTexto(string stock)
        {
            foreach (char x in stock)
            {
                if (!char.IsDigit(x))
                {
                    confirmaTexto = true;
                    break;
                }
            }
            return confirmaTexto;
        }

        
        public bool EmailValido(string email)
        {
        string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, patron);
        }

        public bool validaCorreo(string txtEmail)
        {
            if (!(txtEmail.Contains("@") == true))
                confirmaCorreo = false;
            else confirmaCorreo = true;
            if (!(txtEmail.Contains("gmail.com") == true) && !(txtEmail.Contains("hotmail.com") == true) && !(txtEmail.Contains("live.com") == true))
                confirmaCorreo = false;
            else confirmaCorreo = true;

            return confirmaCorreo;
        }



    }
}
