using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Treino.Aluno.DomainModel
{
    public class AlunoMOD
    {
        [Key]
        public int Cod_Aluno { get; set; }

        [Required(ErrorMessage = "Digite o Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [EmailAddress(ErrorMessage = "Digite o E-Mail")]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite a Data de Nascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        public virtual EnderecoMOD Endereco { get; set; }
        //public int? Cod_Endereco { get; set; }


        public virtual SexoMOD Sexo { get; set; }
        public Int32 Cod_Sexo { get; set; }


        public virtual CursoMOD Curso { get; set; }
        [Display(Name = "Curso")]
        public int Cod_Curso { get; set; }

       
       
    }
}
