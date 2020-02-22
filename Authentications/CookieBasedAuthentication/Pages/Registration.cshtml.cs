using CookieBasedAuthentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieBasedAuthentication
{
    public class RegistrationModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public RegistrationModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {

        }

        public void OnPost(UserRegistrationModel model)
        {
            if(ModelState.IsValid)
            {
                ViewData["OnPostSuccess"] = "OnPostMethodSuccess";
            }

            ViewData["OnPostSuccess"] = "OnPostMethodValidationError";
        }
    }
}