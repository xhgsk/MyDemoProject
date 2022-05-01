using Demo.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Demo.Web.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly ILogger<ClientController> _logger;
        private const int pageSzie = 10;
        public ClientController(IClientService clientService, ILogger<ClientController> logger)
        {
            _clientService = clientService;
            _logger = logger;
        }

        // GET: ClientController
        public async Task<ActionResult> Index(int? pageNumber)
        {
            try
            {
                var clients = await _clientService.GetClientPages(pageNumber, pageSzie);
                return View(clients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Read Client Error");
                throw;
            }

        }

    }
}
