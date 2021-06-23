using Roman.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Interfaces
{
    interface IProjetoRepository
    {
        // CRUD
        // Cadastra uma novo Projeto
        void Cadastrar(Projeto novoProjeto);

        //Lista todas os Projeto
        List<Projeto> ListarTodos();

        //Busca um Projeto pelo id
        Projeto BuscarPorId(int id);

        //Atualiza um Projeto pelo id
        void Atualizar(int id, Projeto atualizaProjeto);

        // Deleta um Projeto pelo id
        void Deletar(int id);
    }
}
