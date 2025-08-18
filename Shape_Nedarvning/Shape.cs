using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskeFigurer_Nedarvning
{
    internal abstract class Shape
    {
        public abstract double GetArea { get; }
        public abstract double GetPerimeter { get; }
    }
}
