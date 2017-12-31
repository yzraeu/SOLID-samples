using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SOLID.samples.LSP.Solution
{
    public class Execution
    {
        public Execution()
        {
            var s = new Square() { Lenght = 10 };
            GetArea(s);

            var r = new Rectangle() { Height = 5, Width = 10 };
            GetArea(r);
        }

        public double GetArea(IParallelogram parallelogram)
        {
            Debug.WriteLine($"{parallelogram.Area().ToString()}");

            return parallelogram.Area();
        }
    }
}
