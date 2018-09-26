using beta80.EsercitazioneGiorno3.LibreriaTwitter.Twitter;
using beta80.EsercitazioneGiorno3.LibrerieDiUtilità;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta80.EsercitazioneGiorno3.TestLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatore = new Generatore();
            Console.WriteLine(generatore.GeneraNumeroIntero(1, 10));
            var Test = generatore.GeneraNumeroIntero(0, 3);
            Console.WriteLine(Test);
            if (Test == 0 || Test == 1)
            {
                Console.WriteLine("Test1 ok");
            }

            else
            {
                Console.WriteLine("Test1 fallito ");
            }

            var Test2 = generatore.GeneraNumeroIntero(1, 100);
            if(Test2<=100)
            {
                Console.WriteLine("Test2 ok");  
            }
            else
            {
                Console.WriteLine("Test2 fallito");
            }

            Console.WriteLine(generatore.GeneraBooleano());
            Console.WriteLine(generatore.GeneraParola(10));
            Console.WriteLine(generatore.GeneraNumeroDecimale(1.2M,2.3M));
            Console.WriteLine(generatore.GeneraDataCasuale(2002,2015));
            int ContatoreTrue = 0;
            int ContatoreFalse = 0;
            for(int i=0;i<100;i++)
            {

                var Generato=generatore.GeneraBooleano();
                Console.WriteLine(Generato);
                if (Generato == true)
                { ContatoreTrue++; }
                else
                {
                    ContatoreFalse++;
                }              
            }
            Console.WriteLine(ContatoreTrue);
            Console.WriteLine(ContatoreFalse);
            Console.ReadLine();
        }

        static void TestTwitter()
        {
            var generatoretwitter = new GeneratoreTwitter();
            var utente1 = generatoretwitter.Utente();
            var utente2= generatoretwitter.Utente();
            var tweet1 = generatoretwitter.Tweet(utente2);
            var like1 = utente1.MiPiace2(tweet1);
            tweet1.AggiungiLike(like1);
        }

        
    }
}
