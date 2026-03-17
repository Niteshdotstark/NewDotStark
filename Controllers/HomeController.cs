using DotStark.Models;
using Dotstark;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[assembly: RegisterWebPageRoute(Home.CONTENT_TYPE_NAME, typeof(DotStark.Controllers.HomeController))]

namespace DotStark.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContentRetriever _contentRetriever;

        public HomeController(IContentRetriever contentRetriever)
        {
            _contentRetriever = contentRetriever;
        }

        public async Task<IActionResult> Index()
        {
            var page = await _contentRetriever.RetrieveCurrentPage<Home>(
                new RetrieveCurrentPageParameters(),
                HttpContext.RequestAborted
            );

            var model = page is not null
                ? new HomeViewModel { Title = page.Title, Detail = page.Detail }
                : new HomeViewModel();

            return View(model);
        }
    }
}
