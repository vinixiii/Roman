using Roman.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Interfaces
{
    interface IEquipeRepository
    {
        // CRUD
        // Cadastra uma nova equipe
        void Cadastrar(Equipe novaEquipe);

        //Lista todas as equipes
        List<Equipe> ListarTodos();

        //Busca uma equipe pelo id
        Equipe BuscarPorId(int id);

        //Atualiza uma equipe pelo id
        void Atualizar(int id, Equipe atualizaEquipe);

        // Deleta uma equipe pelo id
        void Deletar(int id);
    }
}
