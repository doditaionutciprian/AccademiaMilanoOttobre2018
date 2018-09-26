using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazionePomeriggio
{
    public class Autenticazione
    {
        
        private int UsernameCorretto = 1234;
        private string PasswordCorretta = "Ciao";
        public bool Login(int Username, string Password)
        {
            if (UsernameCorretto == Username && PasswordCorretta == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
