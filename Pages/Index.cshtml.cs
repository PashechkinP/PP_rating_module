using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PP_rating_module.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Userochek> userki = new List<Userochek>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        async public Task OnPost([FromServices] IFindUser findUserok, string search) // IActionResult - стандартный интерфейс из АСП нужен
        {
            userki = await findUserok.FindUser(search);          
        }

    }
}