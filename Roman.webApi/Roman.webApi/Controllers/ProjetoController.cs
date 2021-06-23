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
    public class ProjetoController : ControllerBase {
        IProjetoRepository _projetoRepository { get; set; }

        public ProjetoController() {
            _projetoRepository = new ProjetoRepository();
        }

        //[Authorize(Roles ="2")]
        [HttpGet]
        public IActionResult Get() {
            try {
                return Ok(_projetoRepository.ListarTodos());
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id) {
            try {
                return Ok(_projetoRepository.BuscarPorId(id));
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        //[Authorize(Roles ="2")]
        [HttpPost]
        public IActionResult Post(Projeto novoProjeto) {
            try {
                _projetoRepository.Cadastrar(novoProjeto);
                return StatusCode(201);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Projeto projetoAtualizado) {
            try {
                _projetoRepository.Atualizar(id, projetoAtualizado);
                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            try {
                _projetoRepository.Deletar(id);
                return StatusCode(204);
            }
            catch(Exception error) {
                return BadRequest(error);
            }
        }
    }
}
