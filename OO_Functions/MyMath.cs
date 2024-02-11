using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
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
            int ggt = Calc_ggt(numOne, numTwo);
            return (numOne * numTwo) / ggt;
        }

        public static int ReadInt()
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");
                if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ihre Zahl ist ungültig \n beachten sie folgende Regeln \n 1. Positiv und Ganzzahlig \t 2. Nicht 0");
                }
            }
        }

        public static void ShowResult(string operation, int numOne, int numTwo, int result)
        {
            Console.WriteLine($"{operation} von {numOne} und {numTwo} ist {result}\n\n");
            
        }

        public static int Calc_ggt_r(int numOne, int numTwo)
        {
            if (numTwo == 0)
            {
                return numOne;
            }
            else
            {
                return Calc_ggt(numTwo, numOne % numTwo); 
            }
            
        }

        public static double Calc_Mittelwert(int[] numbers)
        {
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public static int Calc_KleinsterWert(int[] numbers)
        {
            int a = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num < a)
                {
                    a = num;
                }
            }
            return a;
        }

        public static int Calc_GroessterWert(int[] numbers)
        {
            int a = int.MinValue;
            foreach (int num in numbers)
            {
                if (num > a)
                {
                    a = num;
                }
            }
            return a;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }

        public static void ReverseArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
           

            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }
    }
}
