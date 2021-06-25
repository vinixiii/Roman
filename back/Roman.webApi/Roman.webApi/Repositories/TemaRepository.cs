using Roman.webApi.Contexts;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Repositories
{
    public class TemaRepository : ITemaRepository
    {
        RomanContext ctx = new RomanContext();
        public void Atualizar(int id, Tema atualizaTema)
        {
            Tema buscarTema = BuscarPorId(id);
            if(atualizaTema.Titulo != null)
            {
                buscarTema.Titulo = atualizaTema.Titulo;
            }
            if(atualizaTema.IdSituacao > 0)
            {
                buscarTema.IdSituacao = atualizaTema.IdSituacao;
            }
            ctx.Temas.Update(buscarTema);
            ctx.SaveChanges();
        }

        public Tema BuscarPorId(int id)
        {
            return ctx.Temas.FirstOrDefault(t => t.IdTema == id);
        }

        public void Cadastrar(Tema novoTema)
        {
            novoTema.IdSituacao = 1;
            ctx.Temas.Add(novoTema);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Temas.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Tema> ListarTodos()
        {
            return ctx.Temas.ToList();
        }
    }
}
