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
    public class FuncionarioController : ControllerBase
    {
        private IFuncionarioRepository _funcionarioRepository { get; set; }

        public FuncionarioController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                return Ok(_funcionarioRepository!.GetAll()); 
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
                return Ok(_funcionarioRepository!.GetById(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post (Funcionario funcionario) 
        {
            try
            {
                _funcionarioRepository!.Post(funcionario);
                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Funcionario funcionario)
        {
            try
            {
                _funcionarioRepository!.Update(id, funcionario);
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
                _funcionarioRepository!.Delete(id);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
