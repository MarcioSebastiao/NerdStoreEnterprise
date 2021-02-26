using NSE.Core.Messages.Integration;
using NSE.Pagamentos.Models;
using System.Threading.Tasks;

namespace NSE.Pagamentos.Services
{
    public interface IPagamentoService
    {
        Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento);
    }
}
