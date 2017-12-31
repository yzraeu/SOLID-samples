using System;

namespace SOLID.samples.SRP.Solution
{
    public class Client
    {
        // Model structure
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.Name)) return false;

            if (!EmailHelper.IsValid(this.Email)) return false;

            if (DateOfBirth > DateTime.Now) return false;

            return true;
        }
    }
}
