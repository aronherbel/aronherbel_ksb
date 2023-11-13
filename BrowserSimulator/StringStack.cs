using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator
{

    public class StringStack
    {

        private string[] stringStack;
        private int currentIndex { get; set; }

        public StringStack()
        {
            stringStack = new string[10];
            currentIndex = 0;
        }


        public void Push(string value)
        {
            if (currentIndex == 10)
            {
                Console.WriteLine("Es wurde maximale Anzahl an Seiten geöffnet");
            }
            else
            {
                this.stringStack[currentIndex] = value;
                currentIndex++;
            }

        }
        public string Pop()
        {
            if (currentIndex == 0)
            {
                return "Es wurden keine Seiten vorher aufgerufen";
            }
            else
            {

                return stringStack[--currentIndex]; ;
            }

        }

        public string Peak()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("Der Stack ist Momentan noch Leer");
                return null;
            }

            return stringStack[currentIndex - 1];
        }
        public void Clear()
        {
            Array.Clear(stringStack, 0, stringStack.Length);
            currentIndex = 0;
        }
    }

    
}
