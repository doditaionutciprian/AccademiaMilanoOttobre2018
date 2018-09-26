using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beta80.EsercitazioneGiorno3.LibreriaTwitter.Modelli
{
    public class Like
    {
        public UtenteTwitter Mittente{ get; set; }
        public Tweet Tweet{ get; set; }
        public DateTime OrarioLike { get; set; }


    }
}
