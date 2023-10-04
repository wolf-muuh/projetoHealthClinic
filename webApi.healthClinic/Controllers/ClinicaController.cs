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
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository;

        public ClinicaController() 
        {
            _clinicaRepository = new ClinicaRepository();
        }

        [HttpPost]
        public IActionResult Post(Clinica clinica) 
        {
            try
            {
                _clinicaRepository.Cadastrar(clinica);
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
                List<Clinica> clinicaCadastrada = _clinicaRepository.Listar();
                return Ok(clinicaCadastrada);
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
                _clinicaRepository.Deletar(id);

                return Ok();

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
