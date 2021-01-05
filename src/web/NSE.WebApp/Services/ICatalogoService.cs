using NSE.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.WebApp.Services
{
    public interface ICatalogoService
    {
        Task<IEnumerable<ProdutoViewModel>> ObterTodos();
        Task<ProdutoViewModel> ObterPorId(Guid id);
    }
}
