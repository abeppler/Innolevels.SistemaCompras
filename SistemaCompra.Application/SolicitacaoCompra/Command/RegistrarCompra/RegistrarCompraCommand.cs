using MediatR;

using SolicitacaoCompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra
{
    public class RegistrarCompraCommand : IRequest<bool>
    {
        public SolicitacaoCompraAgg.SolicitacaoCompra SolicitacaoCompra { get; internal set; }
    }
}
