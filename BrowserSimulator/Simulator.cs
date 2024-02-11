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
        private StringStack historyStack = new StringStack();
        private StringStack forwardStack = new StringStack();
        private StringStack stack = new StringStack();
        private string currentUrl = "";
        private GenericStack<double> doubleStack = new GenericStack<double>(); 
        
        private GenericStack<int> intStack = new GenericStack<int>();

        private GenericStack<float> floatStack = new GenericStack<float>();

        public void Run()
        {

            while (true)
            {
                Console.Clear();
                DisplayUrl();
                Console.Write("Geben sie eine URL ein (u: zurück, r: vorwärts, e: schliessen ):");
                string url = Console.ReadLine();
                BrowseUrl(url);

                switch (url)
                {
                    case "e":
                        Environment.Exit(0);
                        break;
                    case "u":
                        Undo();
                        break;
                    case "r":
                        Redo();
                        break;
                    default:
                        BrowseUrl(url);
                        break;
                }

            }


        }

        public void BrowseUrl(string url)
        {
            if (!string.IsNullOrEmpty(currentUrl))
            {
                historyStack.Push(currentUrl);
                forwardStack.Clear();   

            }
            currentUrl = url;
            Console.WriteLine("Lade:" + url);
            

        }

        private void Undo()
        {
            if (historyStack.Count > 0)
            {
                forwardStack.Push(currentUrl);
                currentUrl = historyStack.Pop();
            }
            else
            {
                Console.WriteLine("Keine vorherige Seite vorhanden");
            }

        }
        private void Redo()
        {
            if (forwardStack.Count > 0)
            {
                historyStack.Push(currentUrl);
                currentUrl = forwardStack.Pop();
            }
            else
            {
                Console.WriteLine("Keine vorherige Seite vorhanden");
            }
        }

            private void DisplayUrl()
        {
            Console.WriteLine($"Die aktuelle ist {currentUrl}");
        }
    }
}