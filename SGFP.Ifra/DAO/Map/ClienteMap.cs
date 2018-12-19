using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("SGFP_004_CLIENTE");

            builder.Ignore(p => p.Notifications);

            //builder
            //    .HasKey(p => p.Id)
            //    .HasName("ID");

            builder
                .Property(p => p.PrimeiroNome)
                .HasColumnName("PRIMEIRO_NOME")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(p => p.UltimoNome)
                .HasColumnName("ULTIMO_NOME")
                .HasColumnType("varchar(25)")
                .IsRequired();

            builder
                .Property(p => p.CPF)
                .HasColumnName("CPF")
                .HasColumnType("varchar(17)")
                .IsRequired();

            builder
                .Property(p => p.RG)
                .HasColumnName("RG")
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder
                .Property(p => p.Sexo)
                .HasColumnName("SEXO")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(p => p.Ativo)
                .HasColumnName("FLAG_ATIVO")
                .HasColumnType("bit")
                .IsRequired();

        }
    }
}
