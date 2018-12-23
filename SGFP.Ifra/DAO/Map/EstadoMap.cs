using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map 
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("SGFP_008_ESTADO");

            builder
                .HasKey(p => p.Id)
                .HasName("PK_008");

            builder
                .Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder
                .Property(p => p.Sigla)
                .HasColumnName("SIGLA")
                .HasColumnType("char(2)")
                .IsRequired();
        }
    }
}
