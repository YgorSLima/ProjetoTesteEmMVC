using Microsoft.AspNetCore.Mvc;

namespace ProjetoTesteEmMVC.Controllers
{
    public class PersonagensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarPersonagem()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir()
        {
            return View();
        }
    }
}
