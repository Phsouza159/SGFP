using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("SGFP_009_FUNCIONARIO");

            builder.Ignore(p => p.Notifications);

            builder
                 .HasIndex(p => p.Id)
                 .HasName("PK_009");

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

            builder
                .Property(p => p.Categoria)
                .HasColumnName("CATEGORIA")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
