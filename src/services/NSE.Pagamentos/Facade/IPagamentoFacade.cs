using NSE.Pagamentos.Models;
using System.Threading.Tasks;

namespace NSE.Pagamentos.Facade
{
    public interface IPagamentoFacade
    {
        Task<Transacao> AutorizarPagamento(Pagamento pagamento);
    }
}
