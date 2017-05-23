using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSewerniakZad5.Models
{
    public class Adres :ModelBase
    {
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
    }
}