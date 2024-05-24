using SistemaGeral.Models;
using SistemaGeral.Models.Enums;

namespace SistemaGeral.Data
{
    public class SeedingService
    {
        private SistemaGeralContext _context;

        public SeedingService(SistemaGeralContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Empresa.Any() || _context.Loja.Any() || _context.Funcionario.Any())
            {
                return; //Banco de dados já populado
            }
           
            Funcionario Proprietario = new Funcionario(01, "Proprietario", 00, "funcionario00@gmail.com", Cargo.Propietario,new DateTime(01/01/2000), "login00", "senha00", 10000.00);
            Funcionario Surpevisor01 = new Funcionario(02, "Surpevisor01", 01, "Surpevisor01@gmail.com", Cargo.Surpevisor, new DateTime(01 / 02 / 2000), "login01", "senha01", 7500.00);
            Funcionario Surpevisor02 = new Funcionario(03, "Surpevisor02", 02, "Surpevisor02@gmail.com", Cargo.Surpevisor, new DateTime(02 / 02 / 2000), "login02", "senha02", 7500.00);
            Funcionario Gerente01 = new Funcionario(04, "Gerente01", 03, "Gerente01@gmail.com", Cargo.Gerente, new DateTime(01 / 03 / 2000), "login03", "senha03", 5000.00);
            Funcionario Gerente02 = new Funcionario(05, "Gerente02", 04, "Gerente02@gmail.com", Cargo.Gerente, new DateTime(02 / 03 / 2000), "login04", "senha04", 5000.00);
            Funcionario Caixa01 = new Funcionario(06, "Caixa01", 05, "Caixa01@gmail.com", Cargo.Caixa, new DateTime(01 / 04 / 2000), "login05", "senha05", 2500.00);
            Funcionario Caixa02 = new Funcionario(07, "Caixa02", 06, "Caixa02@gmail.com", Cargo.Caixa, new DateTime(02 / 04 / 2000), "login06", "senha06", 2500.00);
            Funcionario Vendedor01 = new Funcionario(08, "Vendedor01", 07, "Vendedor01@gmail.com", Cargo.Vendedor, new DateTime(01 / 05 / 2000), "login07", "senha07", 2500.00);
            Funcionario Vendedor02 = new Funcionario(09, "Vendedor02", 08, "Vendedor02@gmail.com", Cargo.Vendedor, new DateTime(02 / 05 / 2000), "login08", "senha08", 2500.00);
            Funcionario Estoquista01 = new Funcionario(10, "Estoquista01", 09, "Estoquista01@gmail.com", Cargo.Estoquista, new DateTime(01 / 06 / 2000), "login09", "senha09", 2500.00);
            Funcionario Estoquista02 = new Funcionario(11, "Estoquista02", 10, "Estoquista02@gmail.com", Cargo.Estoquista, new DateTime(02 / 06 / 2000), "login010", "senha10", 2500.00);

            Empresa Empresa01 = new Empresa(01, "Empresa001", 1000, Proprietario, "Endereço01");
            Empresa Empresa02 = new Empresa(02, "Empresa002", 2000, Proprietario, "Endereço02");

            Loja Loja01 = new Loja(01, "Loja01", Gerente01);
            Loja Loja02 = new Loja(02, "Loja02", Gerente02);

            _context.Funcionario.AddRange(Proprietario, Surpevisor01, Surpevisor02, Gerente01, Gerente02, Caixa01, Caixa02, Vendedor01, Vendedor02, Estoquista01, Estoquista02);
            _context.Empresa.AddRange(Empresa01, Empresa02);
            _context.Loja.AddRange(Loja01, Loja02);

            _context.SaveChanges();
        }
    }
}
