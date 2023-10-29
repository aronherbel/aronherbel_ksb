using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public abstract class Shapes
    {
        public string ShapeName { get; set; }
        public float PostitionX { get; set; }
        public float PostitionY { get; set; }

        public virtual void PrintPosition()
        {
            Console.WriteLine($"Position of {ShapeName}: [ {PostitionX} | {PostitionY} ]");
        }

        public Shapes(string name, float x = 100.00f, float y = 100.00f)
        {
            ShapeName = name;
            PostitionX = x;
            PostitionY = y;
        }

        public abstract void PrintArea();
    }
}
