using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazionePomeriggio
{
    public class Program
    {   

        //static double areacerchio (double raggio)
        //{

        //    return Math.PI * raggio * raggio;
            
        //}



        //static double areatriangolo (int basetriangolo, double altezzatriangolo)
        //{
        //    var area = (basetriangolo * altezzatriangolo) / 2;
        //    Console.WriteLine(area);
        //    return area;
        //    //var generatore = new Random();
        //    //return generatore.NextDouble();
        //}

        //static void stampaareatriangolo(int basetriangolo, double altezzatriangolo)
        //{
        //    var area = (basetriangolo * altezzatriangolo) / 2;
        //    Console.WriteLine(area);
        //}

        static void Main(string[] args)
        {
            var raggio = 4.5;
            var basetriangolo = 5;
            var altezzatriangolo = 2.7;
            Console.WriteLine(FunzioniUtili.areacerchio(raggio));
            var area = FunzioniUtili.areatriangolo(basetriangolo, altezzatriangolo);
            //Console.WriteLine(area);
            FunzioniUtili.stampaareatriangolo(basetriangolo,altezzatriangolo);
            Console.ReadLine();
            //var areatrinagolo = (basetriangolo * altezzatriangolo) / 2;
            //Console.WriteLine(areatrinagolo);
        
            //int primonumero = 10;
            //int secondonumero = 20;
            //double terzonumero = 3.14;
            //char quartonumero = '2';
            //bool primobooleano = true;
            //int sestonumero = 3;
            //string primastringa = "CorsoC#";
            //string secondastringa = "Beta80";
            ////int somma = primonumero + secondonumero;
            ////var somma = primonumero + secondonumero + terzonumero + quartonumero + quintonumero;
            //var somma = primonumero + secondonumero + terzonumero + quartonumero;
            //double divisione = (double)secondonumero / sestonumero;
            //string sommastringa = primastringa + " " + secondastringa;
            //var sommastringaincsharp6 = $"{primastringa} {secondastringa} {primonumero}"; //Concatenazione Stringa
            //Console.WriteLine(sommastringaincsharp6);
            //Console.WriteLine(!primobooleano);
            ////Console.WriteLine(sommastringa);
            ////Console.WriteLine(secondonumero%sestonumero);   //Resto
            ////Console.WriteLine(somma);
            ////Console.WriteLine(divisione);
           
        }
    }
}
