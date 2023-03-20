using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolicitacaoCompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    public class SolicitacaoCompraConfiguration : IEntityTypeConfiguration<SolicitacaoCompraAgg.SolicitacaoCompra>
    {
        public void Configure(EntityTypeBuilder<SolicitacaoCompraAgg.SolicitacaoCompra> builder)
        {
            builder.ToTable("SolicitacaoCompra");

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.OwnsOne(c => c.TotalGeral, b => b.Property("Value").HasColumnName("TotalGeral"));
            builder.OwnsMany(c => c.Itens);
            builder.OwnsOne(x => x.CondicaoPagamento, y => y.Property(z => z.Valor).HasColumnName("CondicaoPagamento"));
            builder.OwnsOne(x => x.NomeFornecedor, y => y.Property(z => z.Nome).HasColumnName("NomeFornecedor"));
            builder.OwnsOne(x => x.UsuarioSolicitante, y => y.Property(z => z.Nome).HasColumnName("UsuarioSolicitante"));
        }
    }
}
