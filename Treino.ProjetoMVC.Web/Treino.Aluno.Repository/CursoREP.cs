using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Treino.Aluno.RepositoryContract;
using Treino.Aluno.DomainModel;
using Treino.Aluno.DataAcces;

namespace Treino.Aluno.Repository
{
    public class CursoREP : ICurso
    {
        public IEnumerable<CursoMOD> ListaCurso()
        {
            var conexao = new Conexao();

            return conexao.Curso.ToList();
        }
    }
}
