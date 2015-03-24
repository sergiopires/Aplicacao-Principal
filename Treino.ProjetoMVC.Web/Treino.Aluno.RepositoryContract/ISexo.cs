using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Treino.Aluno.DomainModel;

namespace Treino.Aluno.RepositoryContract
{
    public interface ISexo
    {
        IEnumerable<SexoMOD> ListaSexo();
    }
}
