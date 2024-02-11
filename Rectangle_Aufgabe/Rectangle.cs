using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Aufgabe
{
    internal class Rectangle
    {

        //Konst mit Integer

        public Rectangle(int width, int length)
        {
            this.Width = width;
            this.Length = length;

        }

        //Konst mit Integer und Color
        public Rectangle(int width, int length, Color lineColor) : this(width, length){
            this.LineColor = lineColor;
        }

        //Konst mit decimal
        public Rectangle(decimal width, decimal length)
        {
            this.Width = width;
            this.Length = length; 
        }

        //Konst mit decimal und Color

        public Rectangle(decimal width, decimal length, Color lineColor) : this(width, length)
        {
            this.LineColor = lineColor;
        }


        //Eigenschaften:
        private string name = "unbekannt";
        private decimal length;
        private decimal width;
        private decimal area;
        private Color lineColor;
        

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
        public decimal Width { get; set; }
        public decimal Area
        {
            get 
            {
                return this.width * this.length; 
            }
        }
        public Color LineColor { get; set; }




    }
}
