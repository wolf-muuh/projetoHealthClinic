using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        void Deletar(Guid id);

        List<Consulta> ListarMinhasConsultas();
    }
}
