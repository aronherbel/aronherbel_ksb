using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmanschaft
{
    internal class Feldspieler
    {
        private string name { get; set; }
        private string club { get; set; }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; } 
        }
        public string Club
        {
            get { return this.club; }
            set { this.club = value; }
        }



        public void AufsTorSchiessen(string name, string club)
        {
            Console.WriteLine($"Die Nummer {name} von {club} schiesst aufs Tor!");
        }

        public void Graetschen(string name, string club)
        {
            Console.WriteLine($"Die Nummer {name} von {club} macht eine Blutgreatsche");
        }

        public void Dribbeln(string name, string club)
        {
            Console.WriteLine($"Die Nummer {name} von {club} dribbelt den Gegner schwindlig");
        }
    } 
}
