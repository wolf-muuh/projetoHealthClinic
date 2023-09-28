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
    public class TipoUsuarioController : ControllerBase
    {
        private ITiposDeUsuarioRepository _tiposDeUsuarioRepository;

        public TipoUsuarioController() 
        {
            _tiposDeUsuarioRepository = new TipoUsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(TipoUsuario tipoUsuario)
        {
            try
            {
                _tiposDeUsuarioRepository.Cadastrar(tipoUsuario);
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
                List<TipoUsuario> tiposUsuarios = _tiposDeUsuarioRepository.Listar();

                return Ok(tiposUsuarios);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                
            }
        }

        [HttpGet("GetById")]
        public IActionResult GetById(Guid id) 
        {
            try
            {
                TipoUsuario tipoUsuario = _tiposDeUsuarioRepository.BuscarPorId(id);
                return Ok(tipoUsuario);
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
                _tiposDeUsuarioRepository.Deletar(id);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(Guid id, TipoUsuario tipoUsuario)
        {
            try
            {
                _tiposDeUsuarioRepository.Atualizar(id, tipoUsuario);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
