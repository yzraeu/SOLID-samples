using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.LSP.Problem
{
    class Square : Rectangle
    {
        public override double Height { set => base.Width = base.Height = value; }
        public override double Width { set => base.Width = base.Height = value; }
    }
}
