using LibreriaFunzioniUtili;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FunzioniUtili.areacerchio(5));
            //Console.WriteLine(FunzioniUtili.iseven(73));
            var minimo = 1;
            var massimo = 100;
            //var acc = 0;
            int? acc = FunzioniUtilissime.RitornaNullable(); 

            if (acc.HasValue)
            {
                Console.WriteLine(FunzioniUtilissime.SommaNumeritraMineMax(minimo, massimo, acc.Value));
            }
            ;
            Console.ReadLine();

        }
    }
}
