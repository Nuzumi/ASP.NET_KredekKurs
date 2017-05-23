using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSewerniakZad5.Models
{
    public class Przesylka : ModelBase
    {
        public float Waga { get; set; }
        public virtual Paczkomat Paczkomat { get; set; }
        public virtual Odbiorca Odbiorca { get; set; }
        public virtual Nadawca Nadawca { get; set; }
    }
}