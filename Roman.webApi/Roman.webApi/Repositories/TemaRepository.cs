using Microsoft.EntityFrameworkCore;
using Roman.webApi.Contexts;
using Roman.webApi.Domains;
using Roman.webApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Roman.webApi.Repositories {
    public class TemaRepository : ITemaRepository {
        RomanContext ctx = new RomanContext();

        public void Atualizar(int id, Tema atualizaTema) {
            Tema temaBuscado = BuscarPorId(id);

            if(atualizaTema.IdSituacao > 0) {
                temaBuscado.IdSituacao = atualizaTema.IdSituacao;
            }

            if(atualizaTema.Titulo != null) {
                temaBuscado.Titulo = atualizaTema.Titulo;
            }

            ctx.Temas.Update(temaBuscado);
            ctx.SaveChanges();
        }

        public Tema BuscarPorId(int id) {
            return ctx.Temas.FirstOrDefault(t => t.IdTema == id);
        }

        public void Cadastrar(Tema novoTema) {
            ctx.Temas.Add(novoTema);
            ctx.SaveChanges();
        }

        public void Deletar(int id) {
            ctx.Temas.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public List<Tema> ListarTodos() {
            return ctx.Temas.Include(s => s.IdSituacaoNavigation).ToList();
        }
    }
}
