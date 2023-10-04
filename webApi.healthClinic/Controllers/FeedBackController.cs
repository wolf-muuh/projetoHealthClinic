using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.healthClinic.Domains;
using webApi.healthClinic.Interfaces;
using webApi.healthClinic.Repositories;

namespace webApi.healthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FeedBackController : ControllerBase
    {
        IFeedBackRepository _feedBackRepository;

        public FeedBackController()
        {
            _feedBackRepository = new FeedBackRepository();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_feedBackRepository.ListarPorId(id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_feedBackRepository.Listar());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post(FeedBack feedBack)
        {
            try
            {
                _feedBackRepository.Cadastrar(feedBack);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id, FeedBack feedback) 
        {
            try
            {
                _feedBackRepository.Deletar(id, feedback);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put(Guid id, FeedBack feedback)
        {
            try
            {
                _feedBackRepository.Atualizar(id, feedback);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
