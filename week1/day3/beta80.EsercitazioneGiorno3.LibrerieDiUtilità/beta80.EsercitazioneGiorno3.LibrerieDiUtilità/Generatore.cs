using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta80.EsercitazioneGiorno3.LibrerieDiUtilità
{
    public class Generatore
    {
        private Random random = new Random();
        public int GeneraNumeroIntero(int Minimo, int Massimo)
        {
            return random.Next(Minimo, Massimo+1);
        }

        public decimal GeneraNumeroDecimale(decimal Minimo, decimal Massimo)
        {
            var numero = random.NextDouble();
            return (Minimo + (Massimo - Minimo) * (decimal)numero);
        }

        public string GeneraLetteraDellAlfabeto()
        {
            string Lettere = "abcdefghijklmnopqrstuvwxyz";
            Lettere = Lettere + Lettere.ToUpper();
            var Numero = GeneraNumeroIntero(1, Lettere.Length);
            return Lettere.ElementAt(Numero - 1).ToString();
        }

        public string GeneraParola(int Lunghezza)
        {
            string Parola = "";
            for (int i = 0; i < Lunghezza; i++)
            {
                Parola += GeneraLetteraDellAlfabeto();
            }
            return Parola;
        }

        public bool GeneraBooleano()
        {
            return GeneraNumeroIntero(0, 1) == 0;
        }

        public DateTime GeneraDataCasuale(int AnnoMinimo, int AnnoMassimo)
        {
            int Anno = GeneraNumeroIntero(AnnoMinimo, AnnoMassimo);
            int Mese = GeneraNumeroIntero(1, 12);
            int NumeroGiorniNelMese = DateTime.DaysInMonth(Anno, Mese);
            int Giorno = GeneraNumeroIntero(1, NumeroGiorniNelMese);
            return new DateTime(Anno, Mese, Giorno);
        }
    }


}
