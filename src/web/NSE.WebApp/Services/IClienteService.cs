using NSE.Core.Communication;
using NSE.WebApp.Models;
using System.Threading.Tasks;

namespace NSE.WebApp.Services
{
    public interface IClienteService
    {
        Task<EnderecoViewModel> ObterEndereco();
        Task<ResponseResult> AdicionarEndereco(EnderecoViewModel endereco);
    }
}
