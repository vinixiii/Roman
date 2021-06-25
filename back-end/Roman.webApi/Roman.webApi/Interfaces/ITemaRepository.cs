using Roman.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Interfaces
{
    interface ITemaRepository
    {
        // CRUD
        // Cadastra um novo Tema
        void Cadastrar(Tema novoTema);

        //Lista todos Tema
        List<Tema> ListarTodos();

        //Busca um Tema pelo id
        Tema BuscarPorId(int id);

        //Atualiza um Tema pelo id
        void Atualizar(int id, Tema atualizaTema);

        // Deleta uma Tema pelo id
        void Deletar(int id);
    }
}
