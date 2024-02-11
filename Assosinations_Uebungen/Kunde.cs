using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosinations_Uebungen
{
    internal class Kunde
    {
        private List<Buch> buecher = new List<Buch>();

        public void Leiht(Buch buch)
        {
            if( ! buch.IstAusgeliehen)
            {
                buecher.Add(buch);
                buch.IstAusgeliehen = true;
            }
            
        }

        public void Retourniert(Buch buch)
        {
            if (buecher.Contains(buch))
            {
                buecher.Remove(buch);
                buch.IstAusgeliehen=false;

            }
        }
    }
}
