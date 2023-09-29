using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Deletar(Guid id);

        List<Consulta> ListarMinhasConsultas(string nomeMedico);
    }
}
