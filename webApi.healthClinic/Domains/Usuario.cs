using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.healthClinic.Domains
{
    [Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do usuario é obrigatório")]
        public string? NomeUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O email do usuario é obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName = "CHAR(60)")]
        [Required(ErrorMessage = "O nome do usuario é obrigatório")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve conter de 6 a 20 caracteres")]
        public string? Senha { get; set; }

        //Ref. tabela tipo usuario

        [Required(ErrorMessage = "O Id do Tipo do usuario é obrigatório")]

        public Guid IdTipoUsuario { get; set; }

        [ForeignKey(nameof(IdTipoUsuario))]
        public TipoUsuario? TipoUsuario { get; set; }


    }
}
