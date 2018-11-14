using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cursos.Models
{
    public class Turma
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Código da Turma")]
        public string Codigo { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}