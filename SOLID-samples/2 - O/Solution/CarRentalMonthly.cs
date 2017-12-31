using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.OCP.Solution
{
    public abstract class CarRentalMonthly : CarRental
    {
        public override decimal Rent(Car car, decimal baseValue, int amount)
        {
            return baseValue * (30 * amount);
        }
    }
}