using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PP_rating_module.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Userochek> userki = new List<Userochek>();
        public UserochekHome userokHome = new UserochekHome();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        async public Task OnPost([FromServices] IFindUser findUserok, string search, int id) // IActionResult - стандартный интерфейс из АСП нужен в каких-то случаях
        {
            userki = await findUserok.FindUser(search);
            //foreach (var user in userki)
            //{
            //    user.Id = id;
            //    userokHome = await findUserok.UserochekFindHome(id);
            //}

        }

		protected void showStats(object sender, EventArgs e)
		{

		}

	}
}