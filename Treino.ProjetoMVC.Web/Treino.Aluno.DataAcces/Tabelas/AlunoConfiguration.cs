using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Treino.Aluno.DomainModel;

namespace Treino.Aluno.DataAcces.Tabelas
{
    public class AlunoConfiguration : EntityTypeConfiguration<AlunoMOD>
    {

        public AlunoConfiguration()
        {

            ToTable("TB_ALUNO");

            HasKey(x => x.Cod_Aluno);

            Property(x => x.Cod_Aluno).HasColumnName("COD_ALUNO").HasColumnType("INT").IsRequired();
            Property(x => x.Nome).HasColumnName("NOME").HasColumnType("VARCHAR");
            Property(x => x.Email).HasColumnName("Email").HasColumnType("VARCHAR");
            Property(x => x.Telefone).HasColumnName("Telefone").HasColumnType("VARCHAR");
            Property(x => x.DataNascimento).HasColumnName("DataNascimento").HasColumnType("DATETIME");

            Property(x => x.Cod_Sexo).HasColumnName("ID_SEXO").HasColumnType("INT");

            Property(x => x.Cod_Curso).HasColumnName("ID_CURSO").HasColumnType("INT");

            //Property(x => x.Cod_Endereco).HasColumnName("ID_ENDERECO").HasColumnType("INT");

            HasRequired(x => x.Curso).WithMany().HasForeignKey(x => x.Cod_Curso);

            HasRequired(x => x.Sexo).WithMany().HasForeignKey(x => x.Cod_Sexo);

            //HasRequired(x => x.Endereco).WithMany().HasForeignKey(x => x.Cod_Endereco);

            HasRequired(x => x.Endereco).WithOptional().Map(x => x.ToTable("TB_ALUNO"));

        }

    }
}
