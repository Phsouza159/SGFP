using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    class PaisMap : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("SGFP_012_PAIS");

            builder
               .HasKey(p => p.Id)
               .HasName("PK_012");

            builder
                .Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(p => p.Sigla)
                .HasColumnName("SIGLA")
                .HasColumnType("char(3)")
                .IsRequired();
        }
    }
}
