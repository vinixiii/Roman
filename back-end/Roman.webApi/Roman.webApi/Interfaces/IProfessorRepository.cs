using Roman.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Interfaces
{
    interface IProfessorRepository
    {
        // CRUD
        // Cadastra um novo Professor
        void Cadastrar(Professor novoProfessor);

        //Lista todos os professores
        List<Professor> ListarTodos();

        //Busca um professor pelo id
        Professor BuscarPorId(int id);

        //Atualiza um professor pelo id
        void Atualizar(int id, Professor atualizaProfessor);

        // Deleta um professor pelo id
        void Deletar(int id);
    }
}
