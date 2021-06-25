using Roman.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Interfaces
{
    interface ISituacaoRepository
    {
        // CRUD
        // Cadastra uma nova Situacao
        void Cadastrar(Situacao novaSituacao);

        //Lista todas Situacao
        List<Situacao> ListarTodos();

        //Busca um Situacao pelo id
        Situacao BuscarPorId(int id);

        //Atualiza um Situacao pelo id
        void Atualizar(int id, Situacao atualizaSituacao);

        // Deleta uma Situacao pelo id
        void Deletar(int id);
    }
}
