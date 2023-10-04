using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Interfaces
{
    public interface IFeedBackRepository
    {
        public void Cadastrar(FeedBack feedBack);

        public void Deletar(Guid id);

        public void Atualizar(Guid id, FeedBack feedBack);

        List<FeedBack> Listar();

        public FeedBack ListarPorId(Guid id);

    }
}
