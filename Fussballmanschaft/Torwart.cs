using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmanschaft
{
    internal class Torwart
    {
        private string nameTorwart { get; set; }

        public string NameTorwart
        {
            get { return this.nameTorwart; }
            set { this.nameTorwart = value;}
        }
        
       

        public Torwart(string name) 
        { 
            this.nameTorwart = name;
        }
        public void SchussHalten(string nameTorwart)
        {
            Console.WriteLine($"{nameTorwart} hält den Schuss vom Gegner");
        }

        public void Abstoss(string nameTorwart)
        {
            Console.WriteLine($"{nameTorwart} macht einen Abstoss");
        }
    }
}
