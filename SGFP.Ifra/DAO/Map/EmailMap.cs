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
                .HasKey(p => p.Id)
                .HasName("ID");

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
