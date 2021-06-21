using System.Web.Mvc;
using EPiServer.Web.Mvc;
using MusicFestival.Template.Models.Pages;

namespace MusicFestival.Template.Controllers
{
    public class DefaultPageController : PageController<BasePage>
    {
        public ViewResult Index(BasePage currentPage)
        {
            return View("~/Views/DefaultPage/Index.cshtml", currentPage);
        }
    }
}