namespace SistemaGeral.Models
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime DataNasc { get; set; }
        private string Login { get; set; }
        private string Senha { get; set; }

        public Funcionario() 
        {
        }

        public Funcionario(string nome, int cpf, DateTime dataNasc, string login, string senha)
        {
            Nome = nome;
            CPF = cpf;
            DataNasc = dataNasc;
            Login = login;
            Senha = senha;
        }
    }
}
