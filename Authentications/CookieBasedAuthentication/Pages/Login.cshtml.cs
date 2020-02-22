using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CookieBasedAuthentication
{
    public class LoginModel : PageModel
    {
        [Required]
        [BindProperty]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [BindProperty]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        [BindProperty]
        public bool RememberMe { get; set; }

        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(Login, Password, RememberMe, false);

                if(result.Succeeded)
                {
                    return RedirectToPage("/index");
                } else
                {
                    return Page();
                } 
            }

            return Page();
        }
    }
}