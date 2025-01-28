using Auto;
using Microsoft.AspNetCore.Mvc;

namespace AutoWeb.Controllers
{
    public class SearchController : Controller
    {
        private readonly IAuto_Repository auto_Repository;
        public SearchController(IAuto_Repository auto_Repository)
        {
            this.auto_Repository = auto_Repository;
        }
        public IActionResult Index(string query)
        {
            var autos = auto_Repository.GetAllByMarka_auto(query);

            return View(autos);
        }
    }
}