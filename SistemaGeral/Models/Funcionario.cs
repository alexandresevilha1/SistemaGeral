using SistemaGeral.Models.Enums;

namespace SistemaGeral.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime DataNasc { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario() 
        {
        }

        public Funcionario(int ID, string nome, int cpf, string email, Cargo cargo, DateTime dataNasc, string login, string senha, double salarioBase)
        {
            ID = ID;
            Nome = nome;
            CPF = cpf;
            Email = email;
            Cargo = cargo;
            DataNasc = dataNasc;
            Login = login;
            Senha = senha;
            SalarioBase = salarioBase;
        }
    }
}
