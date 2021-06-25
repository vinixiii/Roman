using Roman.webApi.Contexts;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        RomanContext ctx = new RomanContext();

        public void Atualizar(int id, Usuario atualizaUsuario)
        {
            Usuario usuarioBuscado = BuscarPorId(id);
            if (atualizaUsuario.Email != null)
            {
                usuarioBuscado.Email = atualizaUsuario.Email;
            }
            if (atualizaUsuario.Senha != null)
            {
                usuarioBuscado.Senha = atualizaUsuario.Senha;
            }
            ctx.Usuarios.Update(usuarioBuscado);
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            // Retorna o usuario encontrado por meio do email e senha
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Professor BuscarProfessorPorId(int id)
        {
            return ctx.Professors.FirstOrDefault(p => p.IdUsuario == id);
        }
    }
}
