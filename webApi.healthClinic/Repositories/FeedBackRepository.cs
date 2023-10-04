using webApi.healthClinic.Contexts;
using webApi.healthClinic.Domains;
using webApi.healthClinic.Interfaces;

namespace webApi.healthClinic.Repositories
{ 
    public class FeedBackRepository : IFeedBackRepository
    {

        private readonly healthClinicContext ctx;

        public FeedBackRepository()
        {
            ctx = new healthClinicContext();
        }

        public void Atualizar(Guid id, FeedBack feedBack)
        {
            FeedBack feedbackBuscado = ctx.FeedBack.Find(id);

            if (feedbackBuscado != null) 
            {
                feedbackBuscado.Exibe = feedBack.Exibe;
                feedbackBuscado.IdConsulta = feedBack.IdConsulta;

                ctx.SaveChanges();
            }
        }

        public void Deletar(Guid id)
        {
            FeedBack feedbackBuscado = ctx.FeedBack.Find(id);

            if(feedbackBuscado!= null) 
            {
                ctx.FeedBack.Remove(feedbackBuscado);
            }
        }

        public void Cadastrar(FeedBack feedBack)
        {
            ctx.FeedBack.Add(feedBack);

            ctx.SaveChanges();
        }

        public List<FeedBack> Listar()
        {
            return ctx.FeedBack.ToList();
        }

        public FeedBack ListarPorId(Guid id)
        {
            FeedBack feedbackBuscado = ctx.FeedBack.Find(id);

            return feedbackBuscado;
        }
    }
}
