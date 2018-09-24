using System;
namespace EsercitazionePomeriggio
{
    public static class FunzioniUtili
    {
        public static double areacerchio(double raggio)
        {
            return Math.PI * raggio * raggio;

        }

        public static double areatriangolo(int basetriangolo, double altezzatriangolo)
        {
            var area = (basetriangolo * altezzatriangolo) / 2;
            Console.WriteLine(area);
            return area;
            //var generatore = new Random();
            //return generatore.NextDouble();
        }

        public static void stampaareatriangolo(int basetriangolo, double altezzatriangolo)
        {
            var area = (basetriangolo * altezzatriangolo) / 2;
            Console.WriteLine(area);
        }
    }
}