using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.ISP.Problem
{
    class ContactEnroll : IEnroll
    {
        public void Persist()
        {
            // Persist to database
        }

        public void SendEmail()
        {
            // Send email
        }

        public void SendSMS()
        {
            // Send SMS
        }

        public void Validate()
        {
            // Check data
        }
    }
}
