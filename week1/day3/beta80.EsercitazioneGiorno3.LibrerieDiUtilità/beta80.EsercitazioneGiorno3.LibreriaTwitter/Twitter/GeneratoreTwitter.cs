using System;
using beta80.EsercitazioneGiorno3.LibreriaTwitter.Modelli;
using beta80.EsercitazioneGiorno3.LibrerieDiUtilità;

namespace beta80.EsercitazioneGiorno3.LibreriaTwitter.Twitter
{
    public class GeneratoreTwitter
    {
        private Generatore generatore = new Generatore();
        public UtenteTwitter Utente()
        {
            var utente = new UtenteTwitter();
            utente.Descrizione = generatore.GeneraParola(200);
            utente.Id = generatore.GeneraNumeroIntero(1, 10000);
            utente.Località = generatore.GeneraParola(100);
            utente.Nome = generatore.GeneraParola(10);
            utente.NomeSchermo = generatore.GeneraParola(10);
            utente.UrlSitoWeb = "http://" + generatore.GeneraParola(30);
            return utente;
        }

        public Tweet Tweet()
        {
            return Tweet(Utente());
        }

        public Tweet Tweet(UtenteTwitter Utente)
        {
            var tweet = Tweet();
            tweet.DataCreazione = DateTime.Now;
            tweet.Id = generatore.GeneraNumeroIntero(1, 10000);
            tweet.Testo = generatore.GeneraParola(140);
            tweet.Utente = Utente;
  
            return tweet;
        }

    }
}
