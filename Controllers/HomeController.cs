using eManagement.Data;
using eManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace eManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContex _dbContext;

        // Constructor with dependency injection
        public HomeController(ILogger<HomeController> logger, ApplicationDbContex dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            try
            {
                // Fetch the list of departments from the database
                var list = _dbContext.Department.ToList();
                return View(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching departments.");
                // Redirect to an error page or handle error appropriately
                return RedirectToAction("Error");
            }
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
