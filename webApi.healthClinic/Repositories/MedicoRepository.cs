using webApi.healthClinic.Contexts;
using webApi.healthClinic.Domains;
using webApi.healthClinic.Interfaces;

namespace webApi.healthClinic.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly healthClinicContext ctx;

        public MedicoRepository()
        {
            ctx = new healthClinicContext();
        }

        public void Cadastrar(Medico medico)
        {
            try
            {
                ctx.Medico.Add(medico);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Deletar(Guid id)
        {
            Medico medico = ctx.Medico.FirstOrDefault(x => x.IdMedico == id)!;
            ctx.Medico.Remove(medico);
        }
    

        public List<Consulta> ListarMinhasConsultas()
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

