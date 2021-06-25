using Microsoft.EntityFrameworkCore;
using Roman.webApi.Contexts;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        RomanContext ctx = new RomanContext();
        public void Atualizar(int id, Projeto atualizaProjeto)
        {
            Projeto buscaProjeto = BuscarPorId(id);
            if(atualizaProjeto.IdProfessor >0)
            {
                buscaProjeto.IdProfessor = atualizaProjeto.IdProfessor;
            }
            if (atualizaProjeto.IdTema > 0)
            {
                buscaProjeto.IdTema = atualizaProjeto.IdTema;
            }
            if (atualizaProjeto.Titulo != null)
            {
                buscaProjeto.Titulo = atualizaProjeto.Titulo;
            }
            if (atualizaProjeto.Descricao != null)
            {
                buscaProjeto.Descricao = atualizaProjeto.Descricao;
            }
            ctx.Projetos.Update(buscaProjeto);
            ctx.SaveChanges();
        }

        public Projeto BuscarPorId(int id)
        {
            return ctx.Projetos.FirstOrDefault(p => p.IdProjeto == id);
        }

        public void Cadastrar(Projeto novoProjeto)
        {
            ctx.Projetos.Add(novoProjeto);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Projetos.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Projeto> ListarTodos()
        {
            return ctx.Projetos
                .Select(p => new Projeto
                {
                    IdProjeto = p.IdProjeto,
                    IdProfessor = p.IdProfessor,
                    IdTema = p.IdTema,
                    Titulo = p.Titulo,
                    Descricao = p.Descricao,

                    IdTemaNavigation = new Tema
                    {
                        IdTema = p.IdTemaNavigation.IdTema,
                        Titulo = p.IdTemaNavigation.Titulo
                    },

                    IdProfessorNavigation = new Professor
                    {
                        IdProfessor = p.IdProfessorNavigation.IdProfessor,
                        IdUsuario = p.IdProfessorNavigation.IdUsuario,
                        IdEquipe = p.IdProfessorNavigation.IdEquipe,
                        Nome = p.IdProfessorNavigation.Nome,
                        DataNascimento = p.IdProfessorNavigation.DataNascimento
                    }
                })
                .ToList();
        }

        public List<Projeto> ListarTodosPorProfessor(int id)
        {
            return ctx.Projetos
                .Include(p => p.IdTemaNavigation)
                .Include(p => p.IdProfessorNavigation)
                .Where(p => p.IdProfessor == id )
                .ToList();
        }
    }
}
