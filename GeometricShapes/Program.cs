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


            }

            Console.WriteLine("Do you want to rotate the shapes\nNo : n\nYes: y ");


            var choice = Console.ReadLine();


            if (choice == "n")
            {
                Console.WriteLine("No Rotation");
            }
            if (choice == "y")
            {

                foreach (Shapes shape in shapes)
                {
                    if (shape is IRotatable rotatable)
                    {
                        rotatable.RotatateShape90Degrees();
                    }
                }

            }


        }
    }

}