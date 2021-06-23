using Microsoft.EntityFrameworkCore;
using Roman.webApi.Contexts;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Roman.webApi.Repositories {
    public class ProjetoRepository : IProjetoRepository {
        RomanContext ctx = new RomanContext();

        public void Atualizar(int id, Projeto atualizaProjeto) {
            Projeto projetoBuscado = BuscarPorId(id);

            if(atualizaProjeto.Titulo != null) {
                projetoBuscado.Titulo = atualizaProjeto.Titulo;
            }

            if(atualizaProjeto.IdTema > 0) {
                projetoBuscado.IdTema = atualizaProjeto.IdTema;
            }

            if(atualizaProjeto.Descricao != null) {
                projetoBuscado.Descricao = atualizaProjeto.Descricao;
            }

            if(atualizaProjeto.IdProfessor > 0) {
                projetoBuscado.IdProfessor = atualizaProjeto.IdProfessor;
            }

            ctx.Projetos.Update(projetoBuscado);
            ctx.SaveChanges();
        }

        public Projeto BuscarPorId(int id) {
            return ctx.Projetos.FirstOrDefault(p => p.IdProjeto == id);
        }

        public void Cadastrar(Projeto novoProjeto) {
            ctx.Projetos.Add(novoProjeto);
            ctx.SaveChanges();
        }

        public void Deletar(int id) {
            ctx.Projetos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Projeto> ListarTodos() {
            return ctx.Projetos.Include(prof => prof.IdProfessorNavigation).Include(t => t.IdTemaNavigation).ToList();
        }
    }
}
