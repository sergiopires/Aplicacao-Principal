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
    public class SexoConfiguration : EntityTypeConfiguration<SexoMOD>
    {

        public SexoConfiguration()
        {
            ToTable("SEXO");

            HasKey(x => x.Cod_Sexo);

            Property(x => x.Cod_Sexo).HasColumnName("ID_SEXO").HasColumnType("INT").IsRequired();
            Property(x => x.Descricao).HasColumnName("DESCRICAO").HasColumnType("VARCHAR").HasMaxLength(50);


        }
    }
}