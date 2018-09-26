using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazionePomeriggio
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Numero = "Ciao";
            //Metodo1(Numero);
            //Console.WriteLine(Numero);
            //var Classe = new Class1();
            //Classe.Numero1 = 42;
            //Classe.Nome1 = "Simone";
            //var Classe2 = Classe.Clona();
            //Metodo2(Classe);
            //Console.WriteLine(Classe.Numero1);
            var A = "42,5";
            double B; 
            bool C;
            //var C = false;
            C = double.TryParse(A, out B);
            Console.WriteLine(B);




            Console.ReadLine();
        }
        static void Metodo1(string A)
        {
            A = A + "2";
            Console.WriteLine("il valore di A è "+A);
        }
        static void Metodo2(Class1 B)
        {
            B.Numero1 = B.Numero1 * 2;
            B.Nome1 = "Alessio";
            Console.WriteLine(B.Numero1);
        }
    }
}
