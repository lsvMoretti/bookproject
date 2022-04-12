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
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var formData = await Request.ReadFormAsync();

            var userName = formData["Username"];
            var password = formData["Password"];

            _logger.LogInformation($"Login Attempt Username: {userName}");

            return Page();
        }
    }
}
