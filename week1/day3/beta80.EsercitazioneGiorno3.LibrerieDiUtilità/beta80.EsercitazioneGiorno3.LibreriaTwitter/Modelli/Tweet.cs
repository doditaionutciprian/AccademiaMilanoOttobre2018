using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta80.EsercitazioneGiorno3.LibreriaTwitter.Modelli
{
    public class Tweet
    {
        private int ContatoreLike = 0;
        public DateTime DataCreazione { get; set; }
        public long Id { get; set; }
        public string Testo { get; set; }
        public UtenteTwitter  Utente{ get; set; }
        public Like[] ArrayDiLike { get; set; }
        public Tweet()
        {
            ArrayDiLike = new Like[1000];

        }

        

        public void AggiungiLike(Like like)
        {
            
            ArrayDiLike[ContatoreLike] = like;
            ContatoreLike++;
        }
    }
}
