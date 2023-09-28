using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.healthClinic.Domains
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName = "CHAR(14)")]
        [Required(ErrorMessage = "O CNPJ da clinica é obrigatorio ")]
        public string? CNPJ { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Nome fantasia da clinica é obrigatorio ")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "A razão social da clinica é obrigatoria ")]
        public string? RazaoSocial { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Horario de funcionamento da clinica obrigatorio")]
        public DateTime HorarioFuncionamento { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Endereço da clinica obrigatorio")]
        public string? Endereco { get; set; }

    }
}
