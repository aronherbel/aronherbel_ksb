using System.Drawing;

namespace Rectangle_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5,7,Color.Aqua);
            rectangle1.Name = "Ajnur";

            Rectangle rectangle2 = new Rectangle(17, 19);
            rectangle2.Name = "Aziz";

            Rectangle rectangle3 = new Rectangle(12.65M, 13.899M);

            Rectangle rectangle4 = new Rectangle(99.99M, 89.234M, Color.DarkMagenta);

           

        }
    }
}