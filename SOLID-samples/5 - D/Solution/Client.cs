using System;

namespace SOLID.samples.DIP.Solution
{
    public class Client
    {
        // Model structure
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        private readonly IEmailHelper emailHelper;

        public Client(IEmailHelper emailHelper)
        {
            this.emailHelper = emailHelper;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.Name)) return false;

            if (!emailHelper.IsValid(this.Email)) return false;

            if (DateOfBirth > DateTime.Now) return false;

            return true;
        }
    }
}
