using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Treino.Aluno.DomainModel;

namespace Treino.Aluno.UI.Web.ViewModels
{
    public class CursoVM
    {
        public IEnumerable<CursoMOD> ListaCurso { get; set; }

    }
}