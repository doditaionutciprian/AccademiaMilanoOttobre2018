using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFunzioniUtili
{
    public static class FunzioniUtilissime
    {
      public static double MassimotradueNumeri (double numero1, double numero2)
        {
            //if (numero1 > numero2)
            //{
            //    return numero1;
            //} else
            //{
            //    return numero2;
            //}

            return numero1 > numero2 ? numero1 : numero2 ;
        } 
        
        public static double ConfrontoTreNumeri (double primonumero,
            double secondonumero, 
            double terzonumero)
        {
            return MassimotradueNumeri(MassimotradueNumeri(primonumero, secondonumero),
                terzonumero);
            
 
        }

        public static int SommaNumeritraMineMax (int minimo, int massimo, int? acc = 0)
        {
           

            for (int i = minimo; i <= massimo; i++)
            {
                acc += i;
            }

            return acc.Value;
        }

        public static int? RitornaNullable()
        {
            return new Nullable<int>();
        }
        

    }
}
