using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator
{
    public class Simulator
    {
       
        public void Run() 
        {
            do
            {

                Console.Write("Geben sie eine URL ein: ");
                string url = Console.ReadLine();
                BrowseUrl(url);



                if (url == "e")
                {
                    break;
                }

                Console.Write("Geben sie eine URL ein: ");

            } while(true);
            

        }

        public void BrowseUrl(string url)
        {
            Console.WriteLine("Lade:" + url);

        }
    }
}
