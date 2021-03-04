using NSE.Core.Messages.Integration;
using NSE.Pagamentos.Models;
using System;
using System.Threading.Tasks;

namespace NSE.Pagamentos.Services
{
    public interface IPagamentoService
    {
        Task<ResponseMessage> AutorizarPagamento(Pagamento pagamento);
        Task<ResponseMessage> CapturarPagamento(Guid pedidoId);
        Task<ResponseMessage> CancelarPagamento(Guid pedidoId);
    }
}
