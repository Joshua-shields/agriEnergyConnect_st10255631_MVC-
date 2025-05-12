/////////////////////////////////////////START OF IMPORTS//////////////////////////////////////////////////////////////////
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AgriEnergyConnect_st10255631_MVC.Models;
using Microsoft.Extensions.Logging;
using agri_enegry.Models;
/////////////////////////////////////////END OF IMPORTS//////////////////////////////////////////////////////////////////

namespace AgriEnergyConnect_st10255631_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Login()
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
////////////////////////////////////////////////////////////END OF FILE////////////////////////////////////////////////////////////