using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_EvoSystems.Interfaces;
using Projeto_EvoSystems.Models;
using Projeto_EvoSystems.Repositories;

namespace Projeto_EvoSystems.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DepartamentoController : ControllerBase
    {
        private IDepartamentoRepository _departamentoRepository { get; set; }

        public DepartamentoController()
        {
            _departamentoRepository = new DepartamentoRepository();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                return Ok(_departamentoRepository.GetAll());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            try
            {
                return Ok(_departamentoRepository.GetById(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Departamento departamento) 
        {
            try
            {
                _departamentoRepository.Post(departamento);
                return StatusCode(201, departamento);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Departamento departamento)
        {
            try
            {
                _departamentoRepository.Update(id, departamento);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            try
            {
                _departamentoRepository.Delete(id);
                return StatusCode(204);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
