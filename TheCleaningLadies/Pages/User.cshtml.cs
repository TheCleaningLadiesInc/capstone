using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPagesUser.Models;
using RazorPagesUser.Services;

namespace RazorPagesUser.Pages
{
    public class UserModel : PageModel
    {
        public List<User> users = new();

        [BindProperty]
        public User NewUser { get; set; } = new();

        public void OnGet()
        {
            users = UserService.GetAll();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            UserService.Add(NewUser);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            UserService.Delete(id);
            return RedirectToAction("Get");
        }
    }

}