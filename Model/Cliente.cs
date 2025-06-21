using System.ComponentModel.DataAnnotations;

namespace Atividade_Almir_Api.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [Required]
        public string CEP { get; set; }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }

       
    }
}
