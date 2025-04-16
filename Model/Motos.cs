using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_Almir_Api.Model
{
    [Table("Motos")]
    public class Motos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(35)]
        [Display(Name = "Modelo: ")]
        public string modelo { get; set; }

        [Required]
        [StringLength(35)]
        [Display(Name = "Marca: ")]
        public string marca { get; set; }

        [Required]
        [StringLength(35)]
        [Display(Name = "Cor: ")]
        public string cor { get; set; }

        [Required]
        [StringLength(35)]
        [Display(Name = "Chassi: ")]
        public string chassi { get; set; }
    }
}
