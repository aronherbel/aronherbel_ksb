using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosinations_Uebungen
{
    internal class Hund
    {
        private List<Laus> laeuse = new List<Laus>();


        public void AddLaus(Laus laus)
        {
            laeuse.Add(laus);
            
        }
    }
}
