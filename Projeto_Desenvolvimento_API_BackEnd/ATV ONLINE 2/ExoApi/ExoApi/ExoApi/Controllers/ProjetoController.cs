using ExoApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoController _projetoController;

        public ProjetoController(ProjetoController projetoController)
        {
            _projetoController = projetoController;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_projetoController.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Projeto projeto = (Projeto)_projetoController.BuscarPorId(id);
                if(projeto == null)
                {
                    return NotFound();
                }
                return Ok(projeto);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                _projetoController.Cadastrar(projeto);
                return StatusCode(201);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Projeto projeto)
        {
            try
            {
                _projetoController.Atualizar(id, projeto);
                return StatusCode(204);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [Authorize(Roles ="1")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _projetoController.Deletar(id);
                return StatusCode(204);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
