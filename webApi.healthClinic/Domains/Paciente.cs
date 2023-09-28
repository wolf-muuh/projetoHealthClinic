using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.healthClinic.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do Paciente é obrigatório")]
        public string? NomePaciente { get; set; }

        [Column(TypeName = "INT")]
        [Required(ErrorMessage = "A idade do paciente é obrigatória")]
        public int Idade { get; set; }

        
        [Column(TypeName = "VARCHAR(500)")]
        [Required(ErrorMessage = "A Descrição do paciente é obrigatória")]
        public string? Descricao { get; set; }


        //Ref. tabela usuario

        [Required(ErrorMessage = "O Id de usuario do paciente é obrigatório")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }



    }
}
