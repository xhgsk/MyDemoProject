using Demo.Service.ViewModels;
using System.Threading.Tasks;

namespace Demo.Service.Interface
{
    public interface IClientService
    {
        Task<ClientsPageViewModel> GetClientPages(int? pageNumber, int pageSize);
    }
}
