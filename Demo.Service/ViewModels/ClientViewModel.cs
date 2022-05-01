using System.Collections.Generic;

namespace Demo.Service.ViewModels
{
    public class ClientViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ClientsPageViewModel
    {
        public IEnumerable<ClientViewModel> Clients { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
