using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazionePomeriggio
{
    public class Class1
    {
        public int Numero1 { get; set; }
        public string Nome1 { get; set; }
        public Class1 Clona()
        {
            var Clone = new Class1();
            Clone.Numero1 = Numero1;
            Clone.Nome1 = Nome1;
            return Clone;
        }
    }
}
