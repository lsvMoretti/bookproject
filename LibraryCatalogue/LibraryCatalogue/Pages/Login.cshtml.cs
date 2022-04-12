using System.Security.Claims;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryCatalog.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogTrace("OnGet function called");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _logger.LogDebug("OnPost");

            _logger.LogDebug("Login Form Submitted!");

            Console.WriteLine("Login Submitted");

            var formData = await Request.ReadFormAsync();

            var userName = formData["Username"];
            var password = formData["Password"];
            return Page();
        }
    }
}
