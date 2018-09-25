using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneClassi.Models
{
    public class Lampadina
    {
        public int Watt { get; set; }
        public double Watt_Ora { get; set; }


        //private int watt;
        //public int Watt
        //{
        //    get {
        //        return this.watt;
        //    }

        //    set {
        //        this.watt = value; }
        ////}

        // var lampadina00 = new Lampadina();
        // Lampadina lampadina00 = new Lampadina();
        public Lampadina()
        {

        }

        // var lampadina01 = new Lampadina(100);
     
        public Lampadina(int Watt)
        {
            this.Watt = Watt;
        }

        public void Accendi()
        {

        }

        public void Spegni()
        {

        }

        public void AumentaLuminosita(int aumentoWatt)
        {
            this.Watt += aumentoWatt;
        }


    }
}
