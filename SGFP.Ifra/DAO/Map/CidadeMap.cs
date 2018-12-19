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
                .HasKey(p => p.Id)
                .HasName("ID");

            builder
                .Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(35)")
                .IsRequired();


        }
    }
}
