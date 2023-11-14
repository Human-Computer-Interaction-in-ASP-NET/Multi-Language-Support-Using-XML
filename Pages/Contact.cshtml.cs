using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorInternational.Models;
using RazorInternational.Services;

namespace RazorInternational.Pages;
public class ContactModel : PageModel
{
    private readonly ILogger<ContactModel> _logger;
    private readonly SharedResourceService _sharedLocalizer;
    [BindProperty]
    public Contact Contact { get; set; } = default!;
    public ContactModel(ILogger<ContactModel> logger, SharedResourceService sharedLocalizer)
    {
        _logger = logger;
        _sharedLocalizer = sharedLocalizer;
    }
    public void OnGet() { }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid || Contact == null)
        {
            return Page();
        }
        ViewData["Result"] = _sharedLocalizer.Get("Success");
        return Page();
    }
}