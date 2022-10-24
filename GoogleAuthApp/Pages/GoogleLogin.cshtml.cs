using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleAuthApp.Pages
{
    public class GoogleLoginModel : PageModel
    {
        //private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        //public GoogleLoginModel(SignInManager<IdentityUser> signInManager)
        //{
        //    _signInManager = signInManager;
        //}

        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public async Task<IActionResult> OnGetAsync()
        {
            //var properties = new AuthenticationProperties { RedirectUri = "GoogleResponse" };
            //properties.Items["LoginProvider"] = "Google";            
            return new ChallengeResult("Google", null);
        }
    }
}