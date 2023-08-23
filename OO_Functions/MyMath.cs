using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OO_Functions

{
    public static class MyMath
    {
        public static int Calc_ggt(int numOne, int numTwo)
        {
            while (numTwo != 0)
            {
                int temp = numTwo;
                numTwo = numOne % numTwo;
                numOne = temp;
            }
            return numOne;
        }

        public static int Calc_kgv(int numOne, int numTwo)
        {
            int max = Math.Max(numOne, numTwo);
            int kgv = max;

            while (true)
            {
                if (kgv % numOne == 0 && kgv % numTwo == 0)
                    return kgv;

                kgv += max;
            }
        }
        
    }
}
