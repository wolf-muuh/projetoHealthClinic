using webApi.healthClinic.Contexts;
using webApi.healthClinic.Domains;
using webApi.healthClinic.Interfaces;
using webApi.healthClinic.Utils;

namespace webApi.healthClinic.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly healthClinicContext ctx;

        public UsuarioRepository()
        {
            ctx = new healthClinicContext();
        }

        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario

                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        NomeUsuario = u.NomeUsuario,
                        Email = u.Email,
                        Senha = u.Senha,

                        TipoUsuario = new TipoUsuario
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            NomeTipoUsuario = u.TipoUsuario!.NomeTipoUsuario

                        }
                    })

                    .FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }


                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            Usuario usuarioBuscado = ctx.Usuario
               .Select(u => new Usuario
               {
                   IdUsuario = u.IdUsuario,
                   NomeUsuario = u.NomeUsuario,
                   Email = u.Email,

                   TipoUsuario = new TipoUsuario
                   {
                       IdTipoUsuario = u.IdTipoUsuario,
                       NomeTipoUsuario = u.TipoUsuario!.NomeTipoUsuario

                   }
               }).FirstOrDefault(u => u.IdTipoUsuario == id)!;

            return usuarioBuscado;
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Usuario.Add(usuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
