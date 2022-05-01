using Demo.Repository.Interface;
using Demo.Service.Interface;

namespace Demo.Service.Implementation
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientReppository)
        {
            _clientRepository = clientReppository;
        }
    }
}