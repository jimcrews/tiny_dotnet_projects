using DI_Lifetime.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Lifetime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly GuidService _guidService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(GuidService guidService, ILogger<HomeController> logger)
        {
            _guidService = guidService;
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            var guid = _guidService.GetGuid();

            var logMessage = $"Controller: The GUID from the GuidService is {guid}";

            _logger.LogInformation(logMessage);

            return Ok();
        }

    }
}
