using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;
using Treino.Aluno.DomainModel;
using System.Web.Mvc;

namespace Treino.Aluno.UI.Web.ViewModels
{
    public class AlunoVM
    {
        public AlunoMOD Aluno { get; set; }
        public IEnumerable<AlunoMOD> Alunos { get; set; }


        public SelectList ListaALuno { get; set; }

        public SelectList ListaCurso { get; set; }

        public SelectList ListaSexo { get; set; }


    }
}