using webApi.healthClinic.Contexts;
using webApi.healthClinic.Domains;
using webApi.healthClinic.Interfaces;

namespace webApi.healthClinic.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly healthClinicContext ctx;

        public ClinicaRepository()
        {
            ctx = new healthClinicContext();
        }

        public void Cadastrar(Clinica clinica)
        {

            try
            {
                ctx.Clinica.Add(clinica);
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Clinica clinica = ctx.Clinica.FirstOrDefault(x => x.IdClinica == id)!;
            ctx.Clinica.Remove(clinica);
            ctx.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            try
            {
                return ctx.Clinica.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
