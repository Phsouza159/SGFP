using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder) 
        {
            builder.ToTable("SGFP_001_AVALIACAO");

            builder.Ignore(p => p.Notifications);

            builder
                .HasKey(p => p.Id)
                .HasName("ID");

            builder.Property(p => p.Nota)
                .HasColumnName("NOTA")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Texto)
                .HasColumnName("TEXTO")
                .HasColumnType("varchar(255)")
                .IsRequired();

        }
    }
}
