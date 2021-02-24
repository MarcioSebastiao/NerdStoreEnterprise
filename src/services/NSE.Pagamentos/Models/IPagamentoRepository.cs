using NSE.Core.Data;

namespace NSE.Pagamentos.Models
{
    public interface IPagamentoRepository : IRepository<Pagamento>
    {
        void AdicionarPagamento(Pagamento pagamento); 
    }
}
