using Tiger.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Tiger.Web.Host.Controllers
{
    public class AntiForgeryController : TigerControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}