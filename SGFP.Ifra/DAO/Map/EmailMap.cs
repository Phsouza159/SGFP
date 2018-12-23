using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class EmailMap : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("SGFP_006_EMAIL");

            builder.Ignore(p => p.Notifications);

            builder
                 .HasIndex(p => p.Id)
                 .HasName("PK_006");

            builder
                .Property(p => p.Senha)
                .HasColumnName("SENHA")
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder
                .Property(P => P.Endereco)
                .HasColumnName("ENDERECO")
                .HasColumnType("varchar(35)")
                .IsRequired();
        }
    }
}
