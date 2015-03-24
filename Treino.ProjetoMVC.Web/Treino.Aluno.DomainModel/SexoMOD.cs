using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Treino.Aluno.DomainModel
{
    public class SexoMOD
    {
        [Key]
        public int Cod_Sexo { get; set; }

        public string Descricao { get; set; }

    }
}
