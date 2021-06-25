using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Roman.webApi.Domains
{
    public partial class Professor
    {
        public Professor()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int IdProfessor { get; set; }
        [Required(ErrorMessage = "O campo idUsuario é obrigatório")]
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "O campo idEquipe é obrigatório")]
        public int IdEquipe { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Data de nascimento é obrigatório")]
        public string DataNascimento { get; set; }

        public virtual Equipe IdEquipeNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
