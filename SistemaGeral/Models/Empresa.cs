namespace SistemaGeral.Models
{
    public class Empresa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CNPJ {  get; set; }
        public Funcionario Proprietario { get; set; }
        public  string Endereco { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Empresa()
        {
        }

        public Empresa(int ID, string nome, int cNPJ, Funcionario proprietario, string endereco)
        {
            ID = ID;
            Nome = nome;
            CNPJ = cNPJ;
            Proprietario = proprietario;
            Endereco = endereco;
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void RemoverFuncionario(Funcionario funcionario)
        {
            Funcionarios.Remove(funcionario);
        }
    }
}
