using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.LSP.Problem
{
    public class Rectangle
    {
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }

        public double Area { get { return this.Height * this.Width; } }
    }
}
