using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.ISP.Problem
{
    public interface IEnroll
    {
        void Validate();

        void Persist();

        void SendEmail();

        void SendSMS();
    }
}
