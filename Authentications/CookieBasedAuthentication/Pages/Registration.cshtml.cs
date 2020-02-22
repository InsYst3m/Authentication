using CookieBasedAuthentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

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

        public async Task OnPost(UserRegistrationModel model)
        {
            if(ModelState.IsValid)
            {
                var identityUser = new IdentityUser
                {
                    Email = model.Email,
                    UserName = model.Login
                };

                var result = await _userManager.CreateAsync(identityUser, model.Password);

                if(result.Succeeded)
                {
                    ViewData["OnPostSuccess"] = "OnPostMethodSuccess";
                } else
                {
                    ViewData["OnPostSuccess"] = "OnPostMethodUserManagerError";
                    return;
                }     
            }
            
            ViewData["OnPostSuccess"] = "OnPostMethodModelStateError";
        }
    }
}