using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SGFP.Domain.Entidades;

namespace SGFP.Infra.DAO.Map
{
    public class OrcamentoMap : IEntityTypeConfiguration<Orcamento>
    {
        public void Configure(EntityTypeBuilder<Orcamento> builder)
        {
            builder.ToTable("SGFP_011_ORCAMENTO");

            builder
                .HasKey(p => p.Id)
                .HasName("PK_011");

            builder
                .Property(p => p.ListaOrcamento)
                .HasColumnName("LISTA_ORCAMENTO")
                .HasColumnType("varchar(255)");

            builder
                .Property(p => p.Status)
                .HasColumnName("STATUS")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(p => p.ValorOrcamento)
                .HasColumnName("VALOR_ORCAMENTO")
                .HasColumnType("float")
                .IsRequired();

            builder
                .Property(p => p.Entrada)
                .HasColumnName("ENTRADA")
                .HasColumnType("datetime")
                .IsRequired();

            builder
                .Property(p => p.Entrega)
                .HasColumnName("ENTREGA")
                .HasColumnType("datetime")
                .IsRequired();

        }
    }
}
