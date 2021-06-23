using System;
using System.Collections.Generic;

#nullable disable

namespace Roman.webApi.Domains
{
    public partial class Projeto
    {
        public int IdProjeto { get; set; }
        public int IdProfessor { get; set; }
        public int IdTema { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public virtual Professor IdProfessorNavigation { get; set; }
        public virtual Tema IdTemaNavigation { get; set; }
    }
}
