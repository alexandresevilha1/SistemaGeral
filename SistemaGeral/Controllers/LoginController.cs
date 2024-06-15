using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using MySqlConnector;
using SistemaGeral.Data;
using SistemaGeral.Models;
using SistemaGeral.Controllers;

namespace SistemaGeral.Controllers
{
    public class LoginController : Controller
    {
        private readonly SistemaGeralContext _context;

        public LoginController(SistemaGeralContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(Funcionario funcionario)
        {
            var usuario = _context.Funcionario.FirstOrDefault(x => x.Login == funcionario.Login && x.Senha == funcionario.Senha);
            if (usuario != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return NoContent();
            }
        }
    }
}
