using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.samples.ISP.Solution
{
    public interface IContactEnroll : IEnroll
    {
        void SendEmail();

        void SendSMS();
    }
}
