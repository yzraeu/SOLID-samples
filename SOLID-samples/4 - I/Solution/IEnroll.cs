using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.ISP.Solution
{
    public interface IEnroll
    {
        void Validate();

        void Persist();
    }
}
