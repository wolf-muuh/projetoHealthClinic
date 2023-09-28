using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.healthClinic.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Dia da consulta é obrigatorio")]
        public DateTime DataConsulta { get; set; }

        //ref. tabela paciente
        [Required(ErrorMessage = "Id do paciente que foi consultado obrigatório")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }

        //ref. tabela medico
        [Required(ErrorMessage = "Id do medico que realizou a consulta obrigatório")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico Medico { get; set; }



    }
}
