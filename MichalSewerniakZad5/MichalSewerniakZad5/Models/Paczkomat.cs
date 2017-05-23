using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSewerniakZad5.Models
{
    public class Paczkomat :ModelBase
    {
        public string Kod { get; set; }
        public virtual Adres Adres { get; set; }
    }
}