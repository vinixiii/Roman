using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using Roman.webApi.Repositories;
using Roman.webApi.ViewModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Roman.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }
        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Senha);
                Professor professorBuscado = _usuarioRepository.BuscarProfessorPorId(usuarioBuscado.IdUsuario);

                if (usuarioBuscado == null)
                {
                    return NotFound("Email ou senha invalidos");
                }

                // caso seja encontrado prossegue com a criação do token
                var claims = new[]
                {
                    //Armazena na claim o Email do usuario autenticado
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),

                    //Armazena na claim o id do usuario autenticado
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),

                    //Armazena na claim o id do tipo de usuario autenticado
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString()),

                    //Armazena na Claim o tipo de usuário que foi autenticado (Administrador ou Professor)
                    new Claim("role", usuarioBuscado.IdTipoUsuario.ToString()),

                    //Armazena na Claim o id do professor que está logado
                    new Claim("educatorId", professorBuscado.IdProfessor.ToString())
                };

                //Define a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Roman-chave-autenticacao"));

                //Define as credenciais do token
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    issuer: "Roman.webApi",            //emissor do token
                    audience: "Roman.webApi",          // destinatário do token
                    claims: claims,                         // Dados do token definidos acima
                    expires: DateTime.Now.AddMinutes(40),   //tempo de expiração
                    signingCredentials: creds               //credenciais do token
                );

                // Retorna status OK com token
                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

