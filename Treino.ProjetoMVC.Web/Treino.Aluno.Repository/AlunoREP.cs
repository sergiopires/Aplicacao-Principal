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
    public class AlunoREP : IAluno
    {

        public IEnumerable<AlunoMOD> ListaAluno()
        {
            var conexao = new Conexao();

            return conexao.Alunos.ToList();
        }


        public void Atualizar(AlunoMOD aluno)
        {
            var conexao = new Conexao();

            var alunosis = conexao.Alunos.Single(x => x.Cod_Aluno == aluno.Cod_Aluno);

            alunosis.Nome = aluno.Nome;
            alunosis.Email = aluno.Email;
            alunosis.Telefone = aluno.Telefone;
            alunosis.DataNascimento = aluno.DataNascimento;
            alunosis.Cod_Sexo = aluno.Cod_Sexo;
            alunosis.Cod_Curso = aluno.Cod_Curso;

            alunosis.Endereco.Rua = aluno.Endereco.Rua;
            alunosis.Endereco.NumeroCasa = aluno.Endereco.NumeroCasa;
            alunosis.Endereco.Bairro = aluno.Endereco.Bairro;
            alunosis.Endereco.Cidade = aluno.Endereco.Cidade;
            alunosis.Endereco.Estado = aluno.Endereco.Estado;

            conexao.SaveChanges();

        }

        public void Inserir(AlunoMOD aluno)
        {
            var conexao = new Conexao();

            conexao.Alunos.Add(aluno);
            conexao.SaveChanges();
        }

        public void Excluir(int codigo)
        {
            var conexao = new Conexao();

            var alunosis = conexao.Alunos.Single(x => x.Cod_Aluno == codigo);
            conexao.Alunos.Remove(alunosis);

            conexao.SaveChanges();
        }


        public void AtualizarEndereco(AlunoMOD aluno)
        {
            var conexao = new Conexao();

            var alunosis = conexao.Alunos.Single(x => x.Cod_Aluno == aluno.Cod_Aluno);

            alunosis.Endereco.Rua = aluno.Endereco.Rua;
            alunosis.Endereco.NumeroCasa = aluno.Endereco.NumeroCasa;
            alunosis.Endereco.Bairro = aluno.Endereco.Bairro;
            alunosis.Endereco.Cidade = aluno.Endereco.Cidade;
            alunosis.Endereco.Estado = aluno.Endereco.Estado;
            
            conexao.SaveChanges();
        }
    }

}
