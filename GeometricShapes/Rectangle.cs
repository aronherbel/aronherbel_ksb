using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Rectangle : Shapes, IRotatable
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(string name, float x = 100.00f, float y = 100.00f, float width = 2.00f, float height = 1.00f) : base(name, x, y)
        {
            if (width > 0 && height > 0)
            {
                Width = width;
                Height = height;
            }
            else
            {
                Width = 2.00f;
                Height = 1.00f;
            }
        }

        public override void PrintArea()
        {
            double area = Width * Height;
            Console.WriteLine($"area of {ShapeName}: {area}");
        }

        public void RotatateShape90Degrees()
        {
       
            float originalX = PositionX;
            float originalY = PositionY;

            PositionX = originalY;
            PositionY = originalX - Height;
           

            Console.WriteLine($"The new Position of {ShapeName} is [ {PositionX} | {PositionY} ]");
        }

    }
}
