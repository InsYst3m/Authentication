using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieBasedAuthentication
{
    [Authorize(Policy = "Elite")]
    public class ForAuthorizedEliteModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}