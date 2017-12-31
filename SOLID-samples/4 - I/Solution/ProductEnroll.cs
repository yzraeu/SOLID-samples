using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.ISP.Solution
{
    class ProductEnroll : IEnroll
    {
        public void Persist()
        {
            // Persist to database
        }
        
        public void Validate()
        {
            // Check data
        }
    }
}
