using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.OCP.Solution
{
    public abstract class CarRental
    {
        public abstract decimal Rent(Car car, decimal baseValue, int amount);
    }
}