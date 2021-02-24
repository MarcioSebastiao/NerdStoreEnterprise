using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSE.Pagamentos.Models;

namespace NSE.Pagamentos.Data.Mappings
{
    public class TransacaoMapping : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Pagamento)
                .WithMany(c => c.Transacoes);

            builder.ToTable("Transacoes");
        }
    }
}