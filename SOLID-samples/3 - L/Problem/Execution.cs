using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SOLID.samples.LSP.Problem
{
    public class Execution
    {
        public Execution()
        {
            var r = new Rectangle()
            {
                Height = 10,
                Width = 5
            };
            GetRectArea(r);

            var s = new Square()
            {
                Height = 10, // Squares cannot have diff height and width event thought Square ARE Rectangles in real life
                Width = 5    // 
            };
            GetRectArea(s);
        }

        public double GetRectArea(Rectangle rect)
        {
            Debug.WriteLine($"{rect.Height.ToString()} * {rect.Width.ToString()}");
            Debug.WriteLine($"{rect.Area.ToString()}");

            return rect.Area;
        }
    }
}
