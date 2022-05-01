using Demo.Domain.Data;
using Demo.Domain.Models;
using Demo.Repository.Interface;

namespace Demo.Repository.Implementation
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
