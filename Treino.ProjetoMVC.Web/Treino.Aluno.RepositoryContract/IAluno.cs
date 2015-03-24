using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Treino.Aluno.DomainModel;

namespace Treino.Aluno.RepositoryContract
{
    public interface IAluno
    {
        IEnumerable<AlunoMOD> ListaAluno();

        void Atualizar(AlunoMOD aluno);
        void AtualizarEndereco(AlunoMOD aluno);
        void Inserir(AlunoMOD aluno);
        void Excluir(Int32 id);

    }
}
