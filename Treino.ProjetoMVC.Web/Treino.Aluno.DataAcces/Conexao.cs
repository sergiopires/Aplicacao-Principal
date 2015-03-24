using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using Treino.Aluno.DomainModel;

namespace Treino.Aluno.DataAcces
{
    public class Conexao : DbContext
    {
        public Conexao()
            : base("Data source=SERGIO;Initial Catalog= TREINOALUNO; Integrated Security=True;")
        {
        }

        public DbSet<AlunoMOD> Alunos { get; set; }
        public DbSet<CursoMOD> Curso { get; set; }
        public DbSet<SexoMOD> Sexo { get; set; }
        public DbSet<EnderecoMOD> Endereco { get; set; }


        public void Criar()
        {
            Database.Create();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

          
            modelBuilder.Configurations.Add(new Tabelas.SexoConfiguration());
            modelBuilder.Configurations.Add(new Tabelas.CursoConfiguration());
            modelBuilder.Configurations.Add(new Tabelas.AlunoConfiguration());
            modelBuilder.Configurations.Add(new Tabelas.EnderecoConfiguration());   

            base.OnModelCreating(modelBuilder);
        }


    }
}
