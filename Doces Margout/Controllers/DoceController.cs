using BAL;
using DocesMargout.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocesMargout.Controllers
{
    public class DoceController : Controller
    {
        private readonly IDoce _Doce;

        public DoceController(IDoce doce)
        {
            _Doce = doce; 
        }

        public IActionResult ItensAVenda()
        {
            ViewBag.Cuca = "Está é a parte de Cucas";
            ViewBag.Bolo = "Está é a parte de Bolos";
            return View(_Doce.TodosDoces);
        }

         public IActionResult AdicionarItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AuthAdiciocnarItem(string nome, string sabor, string descricao, string ingredientes, int categorias,decimal preco)
        {
            if (DoceBAL.Insert(nome, sabor, descricao, ingredientes, categorias, preco))
            {
                return RedirectToAction("ItensAVenda", "Doce");
            }
            else
            {
                return RedirectToAction("AdidionarItem", "Doce");
            }



            return View();
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
