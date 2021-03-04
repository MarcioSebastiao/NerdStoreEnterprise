using NSE.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.Pagamentos.Models
{
    public interface IPagamentoRepository : IRepository<Pagamento>
    {
        void AdicionarPagamento(Pagamento pagamento);

        void AdicionarTransacao(Transacao transacao);
        Task<IEnumerable<Transacao>> ObterTransacoesPorPedidoId(Guid pedidoId);
    }
}
