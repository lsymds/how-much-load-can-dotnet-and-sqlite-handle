using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HowMuchLoadCanNetHandle.App.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _dbContext;

    public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}
