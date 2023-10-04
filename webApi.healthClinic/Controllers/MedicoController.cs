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
    public class MedicoController : ControllerBase
    {
        private IMedicoRepository _medicoRepository;

        public MedicoController()
        {
            _medicoRepository = new MedicoRepository();

        }



        [HttpPost]
        public IActionResult Post(Medico medico)
        {
            try
            {
                _medicoRepository.Cadastrar(medico);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Consulta> consultasMedico = _medicoRepository.ListarMinhasConsultas();
                return Ok(consultasMedico);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }


        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _medicoRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}
