using System;
using System.Collections;


namespace EsercitazioneCollezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            var Array = new ArrayList();


            for (int i = 0; i < 3000; i++)
            {
                Array.Add(new Studente { Id = i, Nome = i.ToString() });
            }
            Array.Add("Stringa");

            foreach (var item in Array)
            {
                if (item.GetType().ToString() == "EsercitazioneCollezioni.Studente")
                {
                    var p1 = item as Studente;
                    p1.FaiQualcosa();
                }
            }

            Console.WriteLine(Array[0]);

            //---------------------------------------------------------------------
            //var Hash = new Hashtable();
            //for (int i = 0; i < 3000; i++)
            //{
            //    //Hash.Add(i, i*5);
            //    Hash.Add(i, new Studente { Id = i, Nome = i.ToString() });
            //}

            //Hash.Add("pippo", "topolino");
            ////Hash.Add("pippo","topolina");

            //var p = Hash[1000];
            //var c = Hash["pippo"];

            //if (p.GetType().ToString()=="EsercitazioneCollezioni.Studente")
            //{
            //    Console.WriteLine("Tipo giusto");
            //    var p1 = (Studente)p;
            //    p1.FaiQualcosa();
            //}

            //Console.WriteLine(p.GetType());
            //Console.WriteLine(Hash["pippo"]);

            //---------------------------------------------------------------------

            //var Coda = new Queue();
            //var Stack = new Stack();

            //for (int i = 0; i < 3000; i++)
            //{
            //    Coda.Enqueue(new Studente { Id = i, Nome = i.ToString() });
            //    Stack.Push(new Studente { Id = i, Nome = i.ToString() });
            //}

            //Coda.Dequeue();
            //Stack.Pop();

            Console.ReadLine();
        }
    }
}
