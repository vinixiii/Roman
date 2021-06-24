using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Roman.webApi.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Temas = new HashSet<Tema>();
        }

        public int IdSituacao { get; set; }
        [Required(ErrorMessage = "O campo estado é obrigatório")]
        public string Estado { get; set; }

        public virtual ICollection<Tema> Temas { get; set; }
    }
}
