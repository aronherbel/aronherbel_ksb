using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassendiagrammUebung
{
    internal class Triangle
    {

        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public Color Color
        {
            get { return this.Color; }
            private set { this.Color = value; }
        }

        protected int[] points = new int[3];
        protected int[] Points
        {
            get
            {
                return this.Points;
            }
        }

        private Point center;

        private Point Center { get; set; }


        public int calcCircumference()
        {
            return 0;
        }
    }
}
