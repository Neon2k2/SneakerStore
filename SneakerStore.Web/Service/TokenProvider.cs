using Newtonsoft.Json.Linq;
using SneakerStore.Web.Service.IService;
using SneakerStore.Web.Utility;

namespace SneakerStore.Web.Service
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Response.Cookies.Delete(SD.TokenCookie);
        }

        public string? GetToken()
        {
            string? token = null;
            bool? hasToken = _contextAccessor.HttpContext?.Request.Cookies.TryGetValue(SD.TokenCookie, out token);
            return hasToken is true ? token : null;
        }

        public void SetToken(string token)
        {
            var options = new CookieOptions
            {
                HttpOnly = true,
                Secure = true, // Ensure it’s only sent over HTTPS
                SameSite = SameSiteMode.Strict // To prevent CSRF attacks

            };
            _contextAccessor.HttpContext?.Response.Cookies.Append(SD.TokenCookie, token);
        }
    }
}
