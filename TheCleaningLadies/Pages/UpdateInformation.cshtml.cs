using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUser.Models;
using RazorPagesUser.Services;

namespace TheCleaningLadies.Pages
{
    public class Index1Model : PageModel
    {
        public IActionResult OnGet()
        {
            UserService userService = new UserService();
            string cookieValue = Request.Cookies["sessionCookie"];
            if (cookieValue != null)
            {
                if (userService.CheckCookie(cookieValue))
                {
                    return Page();
                }
            }
            return RedirectToPage("/Seller");
        }
    }
}
