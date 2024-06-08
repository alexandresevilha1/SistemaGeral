using Microsoft.AspNetCore.Mvc;
using SistemaGeral.Models;

namespace SistemaGeral.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Funcionario usuario = new Funcionario();

            return View("Index", usuario);
        }

        [HttpPost]
        public IActionResult Login(Funcionario usuario)
        {
            usuario.Email = "Funcionou";
            return View("Index", usuario);
        }
    }
}
