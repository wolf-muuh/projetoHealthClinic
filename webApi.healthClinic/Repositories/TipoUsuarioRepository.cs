using webApi.healthClinic.Contexts;
using webApi.healthClinic.Domains;
using webApi.healthClinic.Interfaces;

namespace webApi.healthClinic.Repositories
{
    public class TipoUsuarioRepository : ITiposDeUsuarioRepository
    {
        private readonly healthClinicContext ctx;

        public TipoUsuarioRepository() 
        {
            ctx = new healthClinicContext();
        }

        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {
            TipoUsuario tipoBuscado = ctx.TipoUsuario.FirstOrDefault(x => x.IdTipoUsuario == id)!;

            if (tipoUsuario != null)
            {
                tipoBuscado.NomeTipoUsuario = tipoUsuario.NomeTipoUsuario;

            }

            ctx.TipoUsuario.Update(tipoBuscado!);

            ctx.SaveChanges();

        }

        public TipoUsuario BuscarPorId(Guid id)
        {
            List<TipoUsuario> tipoUsuarios = ctx.TipoUsuario.ToList();

            TipoUsuario tipoUsuario = ctx.TipoUsuario.FirstOrDefault(x => x.IdTipoUsuario == id)!;

            return tipoUsuario;
        }

        public void Cadastrar(TipoUsuario tipoUsuario)
        {
            try
            {
                ctx.TipoUsuario.Add(tipoUsuario);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            TipoUsuario tipoUsuario = ctx.TipoUsuario.FirstOrDefault(x => x.IdTipoUsuario == id)!;
            ctx.TipoUsuario.Remove(tipoUsuario);
            ctx.SaveChanges();

        }

        public List<TipoUsuario> Listar()
        {
            try
            {
                return ctx.TipoUsuario.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
