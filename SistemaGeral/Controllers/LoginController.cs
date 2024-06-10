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

        public SistemaGeralContext MySqlConnection { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string login, string senha)
        {
            MySqlConnection MySqlConnection = new("server=localhost;userid=alex;password=1234;database=sistemageral");
            await MySqlConnection.OpenAsync();

            MySqlCommand Mysqlcommand = MySqlConnection.CreateCommand();
            Mysqlcommand.CommandText = $"SELECT * FROM funcionario WHERE login = '{login}' AND Senha = '{senha}'";

            MySqlDataReader reader = Mysqlcommand.ExecuteReader();

            if (await reader.ReadAsync())
            {
                return RedirectToAction("Index", "Home");
            }

            return Json(new { Msg = "Usuario Inválido" });
        }
    }
}
