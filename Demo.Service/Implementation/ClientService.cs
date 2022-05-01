using AutoMapper;
using Demo.Domain.Models;
using Demo.Repository.Interface;
using Demo.Service.Interface;
using Demo.Service.Util;
using Demo.Service.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Service.Implementation
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
        public ClientService(IClientRepository clientReppository, IMapper mapper)
        {
            _clientRepository = clientReppository;
            _mapper = mapper;
        }

        public async Task<ClientsPageViewModel> GetClientPages(int? pageNumber, int pageSize)
        {
            var pages = await PaginatedList<Client>.CreateAsync(_clientRepository.GetAll(), pageNumber ?? 1, pageSize);
            var model = _mapper.Map<ClientsPageViewModel>(pages);
            model.Clients = _mapper.Map<IEnumerable<ClientViewModel>>(pages);
            return model;
        }
    }
}