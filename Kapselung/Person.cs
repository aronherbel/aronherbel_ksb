using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselung
{
    internal class Person
    {
        private bool wuetend;
        private bool gereizt;
        private bool froehlich;
        private bool entspannt;

        public bool Wuetend { get; set; }
        public bool Gereizt { get; set; }
        public bool Froehlich { get; set; }
        public bool Entspannt { get; set;}

        public string IchBinWuetend(bool abfrage)
        {

            if (abfrage == true)
            {
                string ausgabe = "Ich bin so wütend, AHHHHHHHHH!";
                return ausgabe;
            }
            else
            {
                string ausgabe2 = "Ich bin nicht wütend";
                return ausgabe2;
            }
        }


        public string IchBinGereizt(bool abfrage)
        {
            if (abfrage == true)
            {
                string ausgabe = "Ich bin gereizt, Grrr!";
                return ausgabe;
            }
            else
            {
                string ausgabe2 = "Ich bin nicht gereizt";
                return ausgabe2;
            }
        }

        public string IchBinEntspannt(bool abfrage)
        {
            if (abfrage == true)
            {
                string ausgabe = "Ich bin entspannt, Ohhh!";
                return ausgabe;
            }
            else
            {
                string ausgabe2 = "Ich bin verspannt";
                return ausgabe2;
            }
        }

        public string IchBinFroehlich(bool abfrage)
        {
            if (abfrage == true)
            {
                string ausgabe = "Ich bin so fröhlich, Yeahhhh";
                return ausgabe;
            }
            else
            {
                string ausgabe2 = "Ich bin nicht fröhlich";
                return ausgabe2;
            }
        }

    }
}
