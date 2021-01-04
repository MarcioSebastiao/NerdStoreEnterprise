using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Security.Claims;

namespace NSE.WebAPI.Core.Identidade
{
    public class CustomAuthorization
    {
        public static bool ValidarClaimsUsuario(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity.IsAuthenticated &&
                    context.User.Claims.Any(c => c.Type == claimName && c.Value.Contains(claimValue));
        }
    }

    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAttribute(string claimName, string claimValue) : base(typeof(RequisitoClaimFilter))
        {
            Arguments = new object[] { new Claim(claimName, claimValue) };
        }
    }
    public class RequisitoClaimFilter : IAuthorizationFilter
    {
        private readonly Claim _Claim;

        public RequisitoClaimFilter(Claim claim)
        {
            _Claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
                context.Result = new StatusCodeResult(401);

            if (!CustomAuthorization.ValidarClaimsUsuario(context.HttpContext, _Claim.Type, _Claim.Value))
                context.Result = new StatusCodeResult(403);
        }

    }
}
