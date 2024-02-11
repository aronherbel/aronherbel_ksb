using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheitel_ABC
{
    internal class Formels
    {
        private Formels a;
        private Formels b;
        private Formels c;


        public Formels A { get; set; }
        public Formels B { get; set; }  
        public Formels C { get; set; }  


        public static string Abc_Formel(int a, int b, int c)
        {
            
            decimal sx = (-(b)) / (a * 2);
            decimal sy = c - (b * b) / (4 * a);


            string returnvalue = ("x= " +sx+ "| y= " +sy);

            return returnvalue ;
        }
        
       /* public static string PQ_Formel(int p, int q)
        {

        }*/

    }
}
