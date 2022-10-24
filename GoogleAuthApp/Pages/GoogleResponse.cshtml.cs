using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GoogleAuthApp.Pages
{
    public class GoogleResponseModel : PageModel
    {
        public async Task OnGetAsync()
        {
            var auth = await HttpContext.AuthenticateAsync(IdentityConstants.ExternalScheme);
        }
    }
}
