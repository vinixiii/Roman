using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using Roman.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TemasController : ControllerBase
    {
        private ITemaRepository _temaRepository;

        public TemasController()
        {
            _temaRepository = new TemaRepository();
        }

        /// <summary>
        /// Lista todos os temas cadastrados
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_temaRepository.ListarTodos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Busca um tema pelo seu id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_temaRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Cadastra um novo Tema
        /// </summary>
        /// <param name="novoTema"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public IActionResult Post(Tema novoTema)
        {
            try
            {
                _temaRepository.Cadastrar(novoTema);
                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Atualiza um tema
        /// </summary>
        /// <param name="id">Busca pelo id</param>
        /// <param name="atualizarTema">atualiza o tema buscado</param>
        /// <returns></returns>
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Tema atualizarTema)
        {
            try
            {
                _temaRepository.Atualizar(id, atualizarTema);
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Deleta um tema
        /// </summary>
        /// <param name="id">Busca pelo id para deletar</param>
        /// <returns></returns>
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _temaRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
