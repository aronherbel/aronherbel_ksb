using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Circle: Shapes
    {
        public float Radius { get; set; }

        public Circle(string name, float x = 100.00f, float y = 100.00f, float radius = 1.0f) : base(name, x, y)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
            {
                Radius = 1.00f;
            }
        }

        public override void PrintPosition()
        {
            Console.WriteLine($"centre point of {ShapeName}: [ {PositionX} | {PositionY} ]");
        }

       

        public override void PrintArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Circlearea of {ShapeName}: {area}");
        }


    }
}
