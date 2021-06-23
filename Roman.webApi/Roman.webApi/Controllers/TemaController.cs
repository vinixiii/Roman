using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using Roman.webApi.Repositories;
using System;

namespace Roman.webApi.Controllers {
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TemaController : ControllerBase {
        ITemaRepository _temaRepository { get; set; }

        public TemaController() {
            _temaRepository = new TemaRepository();
        }

        //[Authorize(Roles ="")]
        [HttpGet]
        public IActionResult Get() {
            try {
                return Ok(_temaRepository.ListarTodos());
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id) {
            try {
                return Ok(_temaRepository.BuscarPorId(id));
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        //[Authorize(Roles ="")]
        [HttpPost]
        public IActionResult Post(Tema novoTema) {
            try {
                _temaRepository.Cadastrar(novoTema);
                return StatusCode(201);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Tema temaAtualizado) {
            try {
                _temaRepository.Atualizar(id, temaAtualizado);
                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            try {
                _temaRepository.Deletar(id);
                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }
    }
}
