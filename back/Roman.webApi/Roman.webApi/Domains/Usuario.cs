using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Roman.webApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Professors = new HashSet<Professor>();
        }

        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        [Required(ErrorMessage = "Informe o e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A senha deve conter no mínimo 5 caracteres")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string NomeUsuario { get; set; }

        public virtual TiposDeUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
    }
}
