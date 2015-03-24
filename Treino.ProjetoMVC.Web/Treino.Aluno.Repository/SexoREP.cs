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
    public class SexoREP : ISexo
    {
        public IEnumerable<SexoMOD> ListaSexo()
        {
            var conexao = new Conexao();

            return conexao.Sexo.ToList();
        }

        public void Criar()
        {
            var conexao = new Conexao();
            conexao.Criar();

        }
    }
}
