using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloMediaVotiEsami
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c = false;
            int numeroEsami = 0;

            if (args != null && args.Length == 1)
            {
                c = int.TryParse(args[0], out numeroEsami);

                if (c == true)
                {
                    string voto = string.Empty;
                    int totale = 0;

                    int contatore = 0;

                    // O = 10
                    // B = 8
                    // S = 6
                    // I = 4

                    while (contatore < numeroEsami)
                    {
                        Console.WriteLine("Inserisci voto: ");
                        voto = Console.ReadLine();

                        switch (voto.ToUpper())
                        {
                            case "O":
                                totale += 10;
                                contatore++;
                                break;

                            case "B":
                                totale += 8;
                                contatore++;
                                break;

                            case "S":
                                totale += 6;
                                contatore++;
                                break;

                            case "I":
                                totale += 4;
                                contatore++;
                                break;

                            default:
                                Console.WriteLine("Inserisci valore corretto: ");
                                break;
                        }
                    }
                    Console.WriteLine("La media è: " + totale / numeroEsami);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Non ci sono argomenti");
                Console.ReadLine();
                return;
            }
        }
    }
}
