using System;
using System.Collections.Generic;
using System.Text;

namespace DZ6_WPF
{
    abstract class Figure
    {
        public virtual double Area() { return 0; }
        public virtual double Perimeter() { return 0; }
    }
}
