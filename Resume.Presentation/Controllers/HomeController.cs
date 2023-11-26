using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;
using Resume.Presentation.Models;
using System.Diagnostics;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAllDTOsMappingService _AllDTOsMappingService;

        public HomeController(ILogger<HomeController> logger, IAllDTOsMappingService AllDTOsMappingService)
        {
            _logger = logger;
            _AllDTOsMappingService = AllDTOsMappingService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _AllDTOsMappingService.GetAllDTOsAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}