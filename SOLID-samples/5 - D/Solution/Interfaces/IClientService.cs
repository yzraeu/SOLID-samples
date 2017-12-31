namespace SOLID.samples.DIP.Solution
{
    public interface IClientService
    {
        (bool, string) AddClient(Client client);
    }
}
