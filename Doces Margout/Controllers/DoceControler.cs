using DocesMargout.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocesMargout.Controllers
{
    public class DoceControler : Controller
    {
        private readonly IDoce _Doce;

        public DoceControler(IDoce doce)
        {
            _Doce = doce; 
        }

        public IActionResult ItensAVenda()
        {
            ViewBag.Cuca = "Está é a parte de Cucas";
            ViewBag.Bolo = "Está é a parte de Bolos";
            return View(_Doce.TodosDoces);
        }





        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
