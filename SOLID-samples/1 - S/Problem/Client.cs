using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.samples.SRP.Problem
{
    public class Client
    {
        // Model structure
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public (bool status, string errorMessage) Add()
        {
            // Validations
            if (string.IsNullOrEmpty(this.Name)) return (false, "Name is invalid");

            if (!this.Email.Contains("@")) return (false, "Email is invalid");

            if (DateOfBirth > DateTime.Now) return (false, "Date of Birth is invalid");

            // Persist Data
            using (var cn = new SqlConnection("cnString"))
            {
                var cmd = new SqlCommand("INSERT INTO clients(Name, Email, DateOfBirth) VALUES(@Name, @Email, @DateOfBirth)", cn);

                cmd.Parameters.AddWithValue("Name", this.Name);
                cmd.Parameters.AddWithValue("Email", this.Email);
                cmd.Parameters.AddWithValue("DateOfBirth", this.DateOfBirth);

                cmd.ExecuteNonQuery();
            }

            // Send e-mail
            var mail = new MailMessage("no-reply@system.net", this.Email);
            var smtpClient = new SmtpClient
            {
                Port = 25,
                Host = "smtp.system.net"
            };

            mail.Subject = "[System.NET] Welcome";
            mail.Body = "Congrats!";

            smtpClient.Send(mail);

            return (true, string.Empty);
        }
    }
}
