using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.ISP.Problem
{
    class ProductEnroll : IEnroll
    {
        public void Persist()
        {
            // Persist to database
        }

        public void SendEmail()
        {
            throw new NotImplementedException("Product don't have e-mail!");
        }

        public void SendSMS()
        {
            throw new NotImplementedException("Product don't have phone number!");
        }

        public void Validate()
        {
            // Check data
        }
    }
}
