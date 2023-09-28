using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        void Deletar(Clinica clinica);
    }
}
