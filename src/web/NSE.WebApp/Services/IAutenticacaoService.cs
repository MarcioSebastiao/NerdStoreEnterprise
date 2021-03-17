using NSE.WebApp.Models;
using System.Threading.Tasks;

namespace NSE.WebApp.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);

        Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);

        Task RealizarLogin(UsuarioRespostaLogin resposta);

        Task Logout();

        bool TokenExpirado();

        Task<bool> RefreshTokenValido();
    }
}
