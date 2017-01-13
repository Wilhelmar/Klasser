using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class NamnHanterare
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }

        public string Person { get { return "En person heter " + Förnamn + Efternamn; } }
    }
}
