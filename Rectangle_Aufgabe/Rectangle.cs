using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Aufgabe
{
    internal class Rectangle
    {

        //Eigenschaften:
        private string name = "unbekannt";
        private decimal length;
        private decimal width = 30;
        private decimal area;

        //Zugriffsmodifizierer
        public string Name 
        { 
         get 
            { 
                return this.name;
            }
         set 
            { 
                this.name = value;
            }
        }
          
        public decimal Length { get; set; }
        public decimal Width { get;}
        public decimal Area
        {
            get 
            {
                return this.width * this.length; 
            }
        }
       




    }
}
