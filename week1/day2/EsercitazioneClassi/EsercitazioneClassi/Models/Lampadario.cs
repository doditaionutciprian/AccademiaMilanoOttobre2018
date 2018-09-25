using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneClassi.Models
{
    public class Lampadario
    {
        public Lampadina Lampadina { get; set; } // = new Lampadina();
        public DateTime DataAcquisto { get; set; }
        public string Modello { get; set; }
        public string Marca { get; set; }

        public void AggiungiLampadina(Lampadina lampadina)
        {
            this.Lampadina = Lampadina;
        }

        public void Accendi()
        {
            if(this.Lampadina != null)
            {
                this.Lampadina.Accendi();
            }
        }
    }
}
