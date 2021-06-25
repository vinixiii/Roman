using Roman.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Interfaces
{
    interface ITiposDeUsuarioRepository
    {
        // CRUD
        // Cadastra um novo TiposDeUsuario
        void Cadastrar(TiposDeUsuario novoTiposDeUsuario);

        //Lista todos TiposDeUsuario
        List<TiposDeUsuario> ListarTodos();

        //Busca um TiposDeUsuario pelo id
        TiposDeUsuario BuscarPorId(int id);

        //Atualiza um TiposDeUsuario pelo id
        void Atualizar(int id, TiposDeUsuario atualizaTiposDeUsuario);

        // Deleta um TiposDeUsuario pelo id
        void Deletar(int id);

        
    }
}
