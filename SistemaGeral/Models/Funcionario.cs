using SistemaGeral.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaGeral.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "{0} obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "{0} obrigatorio")]
        public int CPF { get; set; }
        [Required(ErrorMessage = "{0} obrigatorio")]
        [EmailAddress(ErrorMessage = " Email inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Cargo Cargo { get; set; }
        [Required(ErrorMessage = "{0} obrigatorio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNasc { get; set; }
        [Required(ErrorMessage = "{0} obrigatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "{0} obrigatorio")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "{0} obrigatorio")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
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
