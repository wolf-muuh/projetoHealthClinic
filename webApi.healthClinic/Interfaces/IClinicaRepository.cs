using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Interfaces
{
    public interface IClinicaRepository
    {
        List<Clinica> Listar();
        void Cadastrar(Clinica clinica);

        void Deletar(Guid id);
    }
}
