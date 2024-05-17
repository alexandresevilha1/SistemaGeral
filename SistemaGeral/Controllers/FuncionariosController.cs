using Microsoft.AspNetCore.Mvc;
using SistemaGeral.Models;

namespace SistemaGeral.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Index()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario("Alexandre", 000, new DateTime(1999,03,26), "login", "senha"));
            funcionarios.Add(new Funcionario("Cecilia", 001, new DateTime(1999, 09, 27), "login1", "senha1"));

            return View(funcionarios);
        }
    }
}

