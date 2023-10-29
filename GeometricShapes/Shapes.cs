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
        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public virtual void PrintPosition()
        {
            Console.WriteLine($"Position of {ShapeName}: [ {PositionX} | {PositionY} ]");
        }

        public Shapes(string name, float x = 100.00f, float y = 100.00f)
        {
            ShapeName = name;
            PositionX = x;
            PositionY = y;
        }

        public abstract void PrintArea();
    }
}
