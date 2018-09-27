using System;
using System.Collections;
using System.Collections.Generic;


namespace EsercitazioneCollezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Array = new ArrayList();


            //for (int i = 0; i < 3000; i++)
            //{
            //    Array.Add(new Studente { Id = i, Nome = i.ToString() });
            //}
            //Array.Add("Stringa");

            //foreach (var item in Array)
            //{
            //    if (item.GetType().ToString() == "EsercitazioneCollezioni.Studente")
            //    {
            //        var p1 = item as Studente;
            //        p1.FaiQualcosa();
            //    }
            //}

            //Console.WriteLine(Array[0]);

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

            var Array = new ArrayList();
            var ListaStudenti = new List<Studente>();
            var ListaStringhe = new List<string>();


            for (int i = 0; i < 3000; i++)
            {
                Array.Add(new Studente { Id = i, Nome = i.ToString() });
                ListaStudenti.Add(new Studente { Id = i, Nome = i.ToString() });
                //ListaStudenti.Add("Studente");
                
            }
            Array.Add("Stringa");
            ListaStringhe.Add("Stringa");

            foreach (var item in ListaStudenti)
            {
                item.FaiQualcosa();
            }

            var u = ListaStudenti[0];
            var Array2 = ListaStudenti.ToArray();

            var CodaInteri = new Queue<int>();

            for (int i = 0; i < 3000; i++)
            {
                CodaInteri.Enqueue(i);

            }

            var StackStringhe = new Stack<string>();
            StackStringhe.Push("1");
            //StackStringhe.Push(1); errore

            var Dizionario = new Dictionary<int, Studente>();
            Dizionario.Add(1, new Studente { MediaVoti = 10 });

            var pippo = Dizionario[1];
            pippo.FaiQualcosa();
            Console.WriteLine(Dizionario.ContainsKey(2));

            //var iq = new Nullable<int>();
            //iq = 10;
            //if (iq.HasValue)
            //{
            //    Console.WriteLine(iq.Value);
            //}

            if (pippo.MediaVoti.HasValue)
            {
                Console.WriteLine(pippo.MediaVoti.Value);
            }

            Console.ReadLine();
        }
    }
}
