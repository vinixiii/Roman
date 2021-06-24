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

        //Lista todos os Projetos com seus respectivos temas
        List<Projeto> ListarTodos();

        //Lista todos os Projetos com seus respectivos temas e pelo id do professor que cadastrou o projeto
        List<Projeto> ListarTodosPorProfessor(int id);

        //Busca um Projeto pelo id
        Projeto BuscarPorId(int id);

        //Atualiza um Projeto pelo id
        void Atualizar(int id, Projeto atualizaProjeto);

        // Deleta um Projeto pelo id
        void Deletar(int id);
    }
}
