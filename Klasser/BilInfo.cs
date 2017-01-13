using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class BilInfo
    {
        public string Märke { get; set; }
        public string Model { get; set; }
        public string Färg { get; set; }
        public int Bränsleförbrukning { get; set; }
        public int Hästar { get; set; }

        public string Bilen { get { return  Märke + " " + Model + " i " + Färg + " med " + Hästar + " BHP. " + "Den kör " + Bränsleförbrukning + "Km per Liter"; } }
    }
}
