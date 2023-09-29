using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Interfaces
{
    public interface IFeedBackRepository
    {
        void FeedBack(FeedBack feedBack);

        void Deletar(Guid id);

        void Atualizar(Guid id, FeedBack feedBack);

        List<FeedBack> Listar();

        List<FeedBack> ListarPorId(Guid id);

    }
}
