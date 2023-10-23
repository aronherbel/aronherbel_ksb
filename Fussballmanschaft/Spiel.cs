using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmanschaft
{
    internal class Spiel
    {
      public string heimManschaft { get; set; }
      public string gastManschaft { get; set; }
       public Spiel(string heimManschaft, string gastManschaft) 
        {
            this.heimManschaft = heimManschaft;
            this.gastManschaft= gastManschaft;
        }
    }
}
