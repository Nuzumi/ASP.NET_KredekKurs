using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSewerniakZad5.Models
{
    public class Nadawca : ModelBase
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public virtual Adres Adres { get; set; }
    }
}