using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Roman.webApi.Domains
{
    public partial class Equipe
    {
        public Equipe()
        {
            Professors = new HashSet<Professor>();
        }

        public int IdEquipe { get; set; }
        [Required(ErrorMessage = "O campo nome da equipe é obrigatório")]
        public string NomeEquipe { get; set; }

        public virtual ICollection<Professor> Professors { get; set; }
    }
}
