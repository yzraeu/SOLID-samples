using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.samples.DIP.Solution
{
    public class EmailHelper : IEmailHelper
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public void Send(string to, string subject, string body, string from = "no-reply@system.net")
        {
            // Send e-mail
            var mail = new MailMessage(from, to);
            var smtpClient = new SmtpClient
            {
                Port = 25,
                Host = "smtp.system.net"
            };

            mail.Subject = subject;
            mail.Body = body;

            smtpClient.Send(mail);
        }
    }
}
