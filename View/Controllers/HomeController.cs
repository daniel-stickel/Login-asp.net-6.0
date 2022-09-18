using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using View.Models;

namespace View.Controllers
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

        public IActionResult Informacao()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult RegisterPage()
        {
            return View();
        }

        public IActionResult AuthCadastro(string emial, string userLogin, string usePassword)
        {
            return View();
        }

        [HttpPost] //===>>> isso diz que esse método só pode ser chamado quando for uma post 
        public IActionResult AuthLogin(string user, string password)
        {
            // autenticar o login
            if (user == "admin" && password == "admin")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}