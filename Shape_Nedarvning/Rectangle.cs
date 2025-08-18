using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskeFigurer_Nedarvning
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea => Width * Height;
        public override double GetPerimeter => 2 * (Width + Height);
    }
}
