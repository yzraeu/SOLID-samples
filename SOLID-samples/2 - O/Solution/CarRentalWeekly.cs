using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.OCP.Solution
{
    public abstract class CarRentalWeekly : CarRental
    {
        public override decimal Rent(Car car, decimal baseValue, int amount)
        {
            return baseValue * (7 * amount);
        }
    }
}