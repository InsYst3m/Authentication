using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieBasedAuthentication
{
    [Authorize]
    public class ForAuthorizedEliteModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}