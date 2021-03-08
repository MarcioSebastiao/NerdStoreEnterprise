using NSE.WebApp.Models;
using System;
using System.Threading.Tasks;

namespace NSE.WebApp.Services
{
    public interface ICatalogoService
    {
        Task<PagedViewModel<ProdutoViewModel>> ObterTodos(int pageSize, int pageIndex, string query = null);
        Task<ProdutoViewModel> ObterPorId(Guid id);
    }
}
