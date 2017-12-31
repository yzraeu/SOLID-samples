namespace SOLID.samples.DIP.Solution
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        private readonly IEmailHelper emailHelper;

        public ClientService(IClientRepository clientRepository, IEmailHelper emailHelper)
        {
            this.clientRepository = clientRepository;
            this.emailHelper = emailHelper;
        }

        public (bool, string) AddClient(Client client)
        {
            if (!client.IsValid()) return (false, "Client data is not valid");

            clientRepository.Add(client);

            emailHelper.Send(client.Email, "Welcome", "Congrats!");

            return (true, string.Empty);
        }
    }
}
