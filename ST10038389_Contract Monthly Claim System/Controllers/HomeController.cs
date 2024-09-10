using Microsoft.AspNetCore.Mvc;
using ST10038389_Contract_Monthly_Claim_System.Models;
using System.Diagnostics;

namespace ST10038389_Contract_Monthly_Claim_System.Controllers
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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult DashBoard()
        {
            return View();
        }

        public IActionResult Claims()
        {
            return View();
        }

        public IActionResult ClaimsReview()
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
// <Summary of the Home Controller Code>
// Lines 16 to 44:
// These lines are the IActionResult which is an interface in ASP.NET Core Model-View-Controller (MVC).
// It represents the action method.
// It is used to return a response to the users.
// The Index method is the default action that gets called when a specific action is taken into account.
// The Return View method that corresponds to the action method name in which case it is Index.cshtml, DashBoard.cshtml, and so on.
// </Summary>


