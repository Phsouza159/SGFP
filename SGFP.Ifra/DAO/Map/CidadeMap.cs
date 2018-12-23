using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("SGFP_003_CIDADE");

            builder
                 .HasIndex(p => p.Id)
                 .HasName("PK_003");

            builder
                .Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(35)")
                .IsRequired();


        }
    }
}
