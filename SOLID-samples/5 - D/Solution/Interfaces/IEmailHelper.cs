namespace SOLID.samples.DIP.Solution
{
    public interface IEmailHelper
    {
        bool IsValid(string email);

        void Send(string to, string subject, string body, string from = "no-reply@system.net");
    }
}
