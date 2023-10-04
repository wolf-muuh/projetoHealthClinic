using webApi.healthClinic.Contexts;
using webApi.healthClinic.Domains;
using webApi.healthClinic.Interfaces;

namespace webApi.healthClinic.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly healthClinicContext ctx;

        public PacienteRepository() 
        {
            ctx = new healthClinicContext();
        }

        public void Cadastrar(Paciente paciente)
        {
            try
            {
                ctx.Paciente.Add(paciente);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Paciente paciente = ctx.Paciente.FirstOrDefault(x => x.IdPaciente == id)!;
            ctx.Paciente.Remove(paciente);
            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            try
            {
                return ctx.Consulta.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
