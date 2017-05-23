using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MichalSewerniakZad5.Models
{
    public class PostContext: DbContext
    {
        public PostContext() : base("Paczkomaty")
        {

        }

        public IDbSet<Adres> Adresy { get; set; }
        public IDbSet<Nadawca> Nadawcy { get; set; }
        public IDbSet<Odbiorca> Odbiorcy { get; set; }
        public IDbSet<Paczkomat> Paczkomaty { get; set; }
        public IDbSet<Przesylka> Przesylki { get; set; }
    }
}