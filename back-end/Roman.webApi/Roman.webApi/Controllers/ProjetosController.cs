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
    public class ProjetosController : ControllerBase
    {
        private IProjetoRepository _projetosRepository;
        public ProjetosController()
        {
            _projetosRepository = new ProjetoRepository();
        }
        /// <summary>
        /// Retorna uma lista com todos os projetos contendo tema
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "2")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_projetosRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Retorna uma lista com todos os projetos contendo tema por professor
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("Professor/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_projetosRepository.ListarTodosPorProfessor(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca projeto pelo id
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_projetosRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra novo projeto 
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Post(Projeto novoProjeto)
        {
            try
            {
                _projetosRepository.Cadastrar(novoProjeto);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza um projeto pelo id
        /// </summary>
        /// <param name="id">id do projeto a ser atualizado</param>
        /// <param name="projetoatualizado">Objeto a ser atualizado</param>
        /// <returns></returns>
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Projeto projetoatualizado)
        {
            try
            {
                _projetosRepository.Atualizar(id, projetoatualizado);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _projetosRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
