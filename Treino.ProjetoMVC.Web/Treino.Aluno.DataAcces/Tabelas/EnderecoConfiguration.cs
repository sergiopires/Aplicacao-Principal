using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Treino.Aluno.DomainModel;


namespace Treino.Aluno.DataAcces.Tabelas
{
    public class EnderecoConfiguration : EntityTypeConfiguration<EnderecoMOD>
    {
        public EnderecoConfiguration()
        {
            ToTable("Endereco");

            HasKey(x => x.Cod_Endereco);

            Property(x => x.Cod_Endereco).HasColumnName("Cod_Endereco").HasColumnType("INT");
            Property(x => x.Rua).HasColumnName("Rua").HasColumnType("VARCHAR").HasMaxLength(100);
            Property(x => x.NumeroCasa).HasColumnName("NumeroResidencia").HasColumnType("VARCHAR").HasMaxLength(30);
            Property(x => x.Bairro).HasColumnName("Bairro").HasColumnType("VARCHAR").HasMaxLength(100);
            Property(x => x.Cidade).HasColumnName("Cidade").HasColumnType("VARCHAR").HasMaxLength(100);
            Property(x => x.Estado).HasColumnName("Estado").HasColumnType("VARCHAR").HasMaxLength(100);


            
        }
    }
}
