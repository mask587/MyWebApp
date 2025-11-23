using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty] public string Name { get; set; }
    [BindProperty] public string Email { get; set; }
    [BindProperty] public string Message { get; set; }
    public bool Submitted { get; set; }

    public void OnPost()
    {
        Submitted = true;
    }
}
