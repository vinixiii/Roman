using Roman.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        // CRUD
        // Cadastra um novo Usuario
        void Cadastrar(Usuario novoUsuario);

        //Lista todos Usuario
        List<Usuario> ListarTodos();

        //Busca um Usuario pelo id
        Usuario BuscarPorId(int id);

        //Atualiza um Usuario pelo id
        void Atualizar(int id, Usuario atualizaUsuario);

        // Deleta um Usuario pelo id
        void Deletar(int id);

        //Validação Login
        Usuario Login(string email, string senha);

        Professor BuscarProfessorPorId(int id);
    }
}
