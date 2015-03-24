using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Treino.Aluno.DomainModel
{
    public class CursoMOD
    {
        [Key]
        public int Cod_Curso { get; set; }
       
        public string Nome { get; set; }
       
        public string Disciplina { get; set; }
        public int Semestres { get; set; }

       

    }
}
