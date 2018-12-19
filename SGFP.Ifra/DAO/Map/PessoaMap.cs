using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGFP.Domain.Entidades;
using SGFP.Domain.Entidades.Base;

namespace SGFP.Infra.DAO.Map
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Ignore(p => p.Ativo);
            builder.Ignore(p => p.CPF);
            builder.Ignore(p => p.Id);
            builder.Ignore(p => p.Notifications);
            builder.Ignore(p => p.PrimeiroNome);
            builder.Ignore(p => p.RG);
            builder.Ignore(p => p.Sexo);
            builder.Ignore(p => p.UltimoNome);
        }
    }
}
