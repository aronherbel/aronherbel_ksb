using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Square : Rectangle
    {
        public Square( string name, float x = 100.00f, float y = 100.00f, float height = 2.00f, float width = 2.00f) : base(name, x, y) 
        {
            if (width == height)
            {
                Height = height;
                Width = width;
            }
            else
            {
                Width = 2.00f;
                Height = 2.00f;
            }
        }
    }
}
