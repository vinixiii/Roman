using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Roman.webApi.Domains
{
    public partial class Projeto
    {
        public int IdProjeto { get; set; }
        [Required(ErrorMessage = "O campo idProfessor é obrigatório")]
        public int IdProfessor { get; set; }
        [Required(ErrorMessage = "O campo idTema é obrigatório")]
        public int IdTema { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        public virtual Professor IdProfessorNavigation { get; set; }
        public virtual Tema IdTemaNavigation { get; set; }
    }
}
