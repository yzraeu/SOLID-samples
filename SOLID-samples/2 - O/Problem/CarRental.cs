using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.OCP.Problem
{
    public class CarRental
    {
        public decimal Rent(Car car, decimal baseValue, int amount, RentType rentType)
        {
            if (rentType == RentType.Daily)
            {
                // Daily Logic
                return baseValue * amount;
            }

            if (rentType == RentType.Weekly)
            {
                // Weekly Logic
                return baseValue * (7 * amount);
            }

            return 0;
        }
    }
}