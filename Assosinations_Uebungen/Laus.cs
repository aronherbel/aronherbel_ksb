using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosinations_Uebungen
{
    internal class Laus
    {
        private Hund hund;

        public Laus(Hund hund)
        {
            this.hund = hund;
            this.hund.AddLaus(this);
        }
    }
}
