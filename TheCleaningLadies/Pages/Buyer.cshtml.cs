using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TheCleaningLadies.Pages;

public class Buyer : PageModel
{
    private readonly ILogger<Buyer> _logger;

    public Buyer(ILogger<Buyer> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}