using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace webApi.healthClinic.Domains
{
    [Table(nameof(FeedBack))]
    public class FeedBack
    {
        [Key]
        public Guid IdFeedBack { get; set; } = Guid.NewGuid();

        [Column(TypeName = "BIT")]
     
        public bool Exibe { get; set; }

        [Column(TypeName = "VARCHAR(500)")]
        [Required(ErrorMessage = "texto de feedback obrigatorio")]
        public string? Descricao { get; set; }

        //ref. tabela consulta

        [Required(ErrorMessage = "O id da consulta é obrigatório ")]
        public Guid IdConsulta { get; set; }

        [ForeignKey(nameof(IdConsulta))]
        public Consulta Consulta { get; set; }
    }
}
