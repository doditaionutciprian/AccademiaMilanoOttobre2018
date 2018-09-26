using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta80.EsercitazioneGiorno3.LibreriaTwitter.Modelli
{
    public class UtenteTwitter
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeSchermo { get; set; }
        public string Località { get; set; }
        public string UrlSitoWeb { get; set; }
        public string Descrizione { get; set; }

        public long MiPiace(Tweet Tweet)
        {
            return Tweet.Id;
        }

        public Like MiPiace2(Tweet Tweet)
        {
            var like = new Like();
            like.Tweet = Tweet;
            like.Mittente = this;
            like.OrarioLike = DateTime.Now;
            return like;

        }

        public Retweet Retweet(Tweet TweetOriginale)
        {
            var retweet = new Retweet();
            retweet.TweetOriginale = TweetOriginale;
            var TweetCopia = new Tweet();
            TweetCopia.DataCreazione = DateTime.Now;
            TweetCopia.Id = 1;
            TweetCopia.Testo = TweetOriginale.Testo;
            TweetCopia.Utente = this;
            retweet.TweetCopia = TweetCopia;
            return retweet;
        }
    }
}
