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
    public class PacienteController : ControllerBase
    {
        private IPacienteRepository _pacienteRepository;

        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();

        }


        [HttpPost]
        public IActionResult Post(Paciente paciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(paciente);
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
                List<Consulta> consultasPaciente = _pacienteRepository.Listar();
                return Ok(consultasPaciente);
            }
            catch (Exception)
            {

                throw;
            }


        }
        [HttpDelete]
        public IActionResult Delete(Guid id) 
        {
            try
            {
                _pacienteRepository.Deletar(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                
            }
        }

    }
}
