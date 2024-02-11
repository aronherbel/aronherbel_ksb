using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator
{

    public class GenericStack<T>
    {

        private T[] genericStack;
        private int currentIndex { get; set; }

        public GenericStack()
        {
            genericStack = new T[10];
            currentIndex = 0;
        }


        public void Push(T value)
        {
            if (currentIndex == 10)
            {
                Console.WriteLine("Es wurde maximale Anzahl an Seiten geöffnet");
            }
            else
            {
                this.genericStack[currentIndex] = value;
                currentIndex++;
            }

        }
        public T Pop()
        {
            if (currentIndex == 0)
            {

                return default(T);
            }
            else
            {
                --currentIndex;
                return genericStack[currentIndex];
            }

        }

        public T Peak()
        {
            if (currentIndex == 0)
            {
                return default(T);
                
            }

            return genericStack[currentIndex - 1];
        }
        public void Clear()
        {
            Array.Clear(genericStack, 0, genericStack.Length);
            currentIndex = 0;
        }

        public int Count
        {
            get { return genericStack.Length; }
        }
    }

    
}
