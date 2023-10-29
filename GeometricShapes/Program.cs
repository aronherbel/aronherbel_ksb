using System;
using System.Collections.Generic;


namespace GeometricShapes
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapes = new List<Shapes>
            {
                new Circle("circle1",30, 20, 10),
                new Rectangle("rectangle1",250, 170, 8, 4 ),
                new Square("square1", 300, 300, 6, 6),
            };

            foreach (Shapes shape in shapes)
            {
                shape.PrintPosition();
                shape.PrintArea();


                if (shape is IRotatable rotatable)
                {
                    rotatable.RotatateShape90Degrees();
                }
            }

        }
    }

}