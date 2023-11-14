using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorInternational.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IStringLocalizer<IndexModel> _localizer;
    private readonly IHtmlLocalizer<IndexModel> _htmlLocalizer;

    public IndexModel(ILogger<IndexModel> logger, 
        IStringLocalizer<IndexModel> localizer,
        IHtmlLocalizer<IndexModel> htmlLocalizer)
    {
        _logger = logger;
        _localizer = localizer;
        _htmlLocalizer = htmlLocalizer;
    }


    public void OnGet()
    {
        ViewData["Message"] = _localizer["Message"];
    }
}
