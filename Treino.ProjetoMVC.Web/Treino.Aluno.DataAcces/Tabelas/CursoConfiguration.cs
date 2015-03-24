using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Treino.Aluno.DomainModel;


namespace Treino.Aluno.DataAcces.Tabelas
{
    public class CursoConfiguration : EntityTypeConfiguration<CursoMOD>
    {
        public CursoConfiguration()
        {
            ToTable("TB_CURSO");

            HasKey(x => x.Cod_Curso);

            Property(x => x.Cod_Curso).HasColumnName("COD_CURSO").HasColumnType("INT").IsRequired();
            Property(x => x.Nome).HasColumnName("NOME").HasColumnType("VARCHAR").HasMaxLength(50);
            Property(x => x.Disciplina).HasColumnName("DISCIPLINA").HasColumnType("VARCHAR").HasMaxLength(50);
            Property(x => x.Semestres).HasColumnName("SEMESTRE").HasColumnType("INT");
            
        }
    }
}
