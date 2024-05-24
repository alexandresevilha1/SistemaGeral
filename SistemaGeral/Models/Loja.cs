namespace SistemaGeral.Models
{
    public class Loja
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Funcionario Gerente {  get; set; }   

        public Loja()
        {
        }

        public Loja(int ID, string nome, Funcionario gerente)
        {
            ID = ID;
            Nome = nome;
            Gerente = gerente;
        }
    }
}
