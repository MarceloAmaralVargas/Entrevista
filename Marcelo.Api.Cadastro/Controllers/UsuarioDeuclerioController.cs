using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marcelo.Negocio.Services;
using Marcelo.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marcelo.Api.Cadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioDeuclerioController : ControllerBase
    {
        private readonly IUsuarioDeuclerioService _usuarioDeuclerioService;

        public UsuarioDeuclerioController(IUsuarioDeuclerioService usuarioDeuclerioService)
        {
            _usuarioDeuclerioService = usuarioDeuclerioService;
        }

        // GET: api/UsuarioDeuclerio
        [HttpGet]
        public async Task<IEnumerable<UsuarioDeuclerio>> Get()
        {            
            return _usuarioDeuclerioService.GetAll().ToList();
        }

        // GET: api/UsuarioDeuclerio/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<UsuarioDeuclerio>> Get(int id)
        {
            return await _usuarioDeuclerioService.GetById(id);
        }

        // POST: api/UsuarioDeuclerio
        [HttpPost]
        public async Task<ActionResult<UsuarioDeuclerio>> Post([FromBody] UsuarioDeuclerio usuarioDeuclerio)
        {
            await _usuarioDeuclerioService.Create(usuarioDeuclerio);
            return Ok(new JsonResult("Id", new { id = usuarioDeuclerio.Id }));
        }

        // PUT: api/UsuarioDeuclerio/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UsuarioDeuclerio usuarioDeucleri)
        {
            if(id != usuarioDeucleri.Id)
            {
                return BadRequest(new JsonResult("O id não é válido. "));
            }
            try
            {
                await _usuarioDeuclerioService.Update(id, usuarioDeucleri);
            }
            catch (SystemException ex)
            {
                return BadRequest(new JsonResult(ex.Message));
            }

            return Ok(new JsonResult("Id", new { Id = usuarioDeucleri.Id }));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            UsuarioDeuclerio usuarioDeuclerio = await _usuarioDeuclerioService.GetById(id);
            if (usuarioDeuclerio == null)
            {
                return NotFound();
            }
            await _usuarioDeuclerioService.Delete(id);

            return Ok(new JsonResult("O usuário foi excluido com sucesso:", new { Id = id }));
        }
    }
}
