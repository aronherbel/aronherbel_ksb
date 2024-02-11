using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1_auto
{
    public class Motor
    {

        Benzinpumpe benzinpumpeVomAuto = new Benzinpumpe();
        Anlasser anlasserVomAuto = new Anlasser();

       
        public void Starten()
        {
            anlasserVomAuto = new Anlasser();
            benzinpumpeVomAuto = new Benzinpumpe();
            Console.WriteLine("Motor starten");
            benzinpumpeVomAuto.Pumpen();
            anlasserVomAuto.Starten();
            Regeln();
        }

        private void Regeln()
        {
            anlasserVomAuto = new Anlasser();
            for (int i = 0; i < 7; i++) 
            {
                Console.WriteLine("Motor Regeln");
            }


            anlasserVomAuto.Stoppen();
           
        }
    }
}
