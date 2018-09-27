using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneCollezioni
{
    public class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return "Matricola: " + Id + " Nome: " + Nome;
        }

        public void FaiQualcosa() {
            Console.WriteLine("qualcosa");
        }
    }
}
