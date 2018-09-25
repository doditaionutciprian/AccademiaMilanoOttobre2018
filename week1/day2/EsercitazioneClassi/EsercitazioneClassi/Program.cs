using EsercitazioneClassi.Models;
using System;

namespace EsercitazioneClassi
{
    class Program
    {
        static void Main(string[] args)
        {
            var lampadina01 = new Lampadina(100);



            //var arrayLampadine = new Lampadina[10000000];
            //for (int i = 0; i < 1000; i++)
            //{
            //    arrayLampadine[i] = new Lampadina(1000);
            //}


            var lampadina02 = new Lampadina();

            var lampadina03 = new Lampadina() { Watt = 500, Watt_Ora = 15.3 };


            var data = new DateTime();

            var dataStringa = DateTime.Now.ToString();
            Console.WriteLine(dataStringa);

            var data2 = new DateTime(2018, 9, 25);
            data = data2.AddMonths(9);
            data = data.AddHours(4).AddMinutes(30).AddSeconds(35);
            Console.WriteLine(data);

            var differenzaDate = data - data2;
            Console.WriteLine(differenzaDate);

            var oggi = DateTime.Today;

            string saluto = "Ciao a tutto il mondo di studenti di c#";
            var parole = saluto.ToUpper().Split(' ');
            for (int i = 0; i < parole.Length; i++)
            {
                Console.WriteLine(parole[i]);
            }

            if(saluto.ToLower().StartsWith("ciao"))
            {
                Console.WriteLine("saluto corretto");
            }
            Console.WriteLine(saluto.Length);


            var lampadario = new Lampadario
            {
                Marca = "Cristallo di Boemia"
            };

            // Console.WriteLine(lampadario.Modello.ToUpper());



            //var lampadario = new Lampadario { Marca = "Cristallo di Boemia",
            //    Modello = "SuperLux", DataAcquisto = DateTime.Today,
            //  Lampadina = new Lampadina(100)};



            Console.ReadLine();
        }
    }
}
