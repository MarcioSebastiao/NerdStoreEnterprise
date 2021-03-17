using NSE.Core.Communication;

namespace NSE.WebApp.Models
{
    public class UsuarioRespostaLogin
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public double ExpiresIn { get; set; }
        public UsuarioToken UsuarioToken { get; set; }
        public ResponseResult ResponseResult { get; set; }
    }
}
