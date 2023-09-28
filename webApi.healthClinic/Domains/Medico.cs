using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.healthClinic.Domains
{
    [Table(nameof(Medico))]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Nome do médico é obrigatorio")]
        public string? NomeMedico { get; set; }

        [Column(TypeName = "CHAR(8)")]
        [Required(ErrorMessage = "CRM do médico obrigatorio")]
        public string? CRM { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Especialização do medico obrigatoria")]
        public string? Especialização { get; set; }

        //ref. tabela clinica
        [Required(ErrorMessage = "A clinica do medico obrigatoria")]
        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica Clinica { get; set; }

        //Ref. tabela usuario

        [Required(ErrorMessage = "O Id de usuario do médico é obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
