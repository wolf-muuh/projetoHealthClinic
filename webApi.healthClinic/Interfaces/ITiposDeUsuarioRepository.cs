using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Interfaces
{
    public interface ITiposDeUsuarioRepository
    {
        void Cadastrar(TipoUsuario tipoUsuario);

        void Deletar(Guid id);

        List<TipoUsuario> Listar();

        TipoUsuario BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoUsuario tipoUsuario);
    }
}
