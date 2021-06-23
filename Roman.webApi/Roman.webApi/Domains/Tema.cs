using System;
using System.Collections.Generic;

#nullable disable

namespace Roman.webApi.Domains
{
    public partial class Tema
    {
        public Tema()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int IdTema { get; set; }
        public int? IdSituacao { get; set; }
        public string Titulo { get; set; }

        public virtual Situacao IdSituacaoNavigation { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
