using System;
using System.Collections.Generic;

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
        public string Situacao1 { get; set; }

        public virtual ICollection<Tema> Temas { get; set; }
    }
}
