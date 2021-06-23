using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "O campo idSituacao é obrigatório")]
        public int? IdSituacao { get; set; }
        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }

        public virtual Situacao IdSituacaoNavigation { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
