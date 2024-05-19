namespace SistemaGeral.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime DataNasc { get; set; }
        private string Login { get; set; }
        private string Senha { get; set; }

        public Funcionario() 
        {
        }

        public Funcionario(int id, string nome, int cpf, DateTime dataNasc, string login, string senha)
        {
            ID = id;
            Nome = nome;
            CPF = cpf;
            DataNasc = dataNasc;
            Login = login;
            Senha = senha;
        }
    }
}
