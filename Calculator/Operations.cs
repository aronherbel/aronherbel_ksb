using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operations
    {
        
        public int LastResult { get; set; }   
        
        public static int Additon(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Subtraktion(int a, int b)
        { 
            int result =  a - b; 
            return result;
        }


        public static int Multiplikation(int a, int b)
        {
            int result = a * b;
            return result;
        }


        public static int Division(int a, int b)
        {
            int result =  a / b;
            return result;
        }
    }
}
