using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1_auto
{
    public class Auto
    {
        public string Name;
        public int HerstellungsJahr;

        Motor motorVomAuto = new Motor();

        public Auto(string name, int HerstellJahr) 
        {
            Name = name;
            HerstellungsJahr = HerstellJahr;
        }
        public void Anlassen () {
            Console.WriteLine(Name + " anlassen");
            motorVomAuto = new Motor();
            motorVomAuto.Starten();
           
        }
    }
}
