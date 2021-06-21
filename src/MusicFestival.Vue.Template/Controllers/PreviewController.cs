using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Framework.Web.Mvc;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using MusicFestival.Template.Models.Preview;

namespace MusicFestival.Template.Controllers
{
    [TemplateDescriptor(Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview, RenderingTags.Edit },
        AvailableWithoutTag = false)]
    [RequireClientResources]
    public class PreviewController : ActionControllerBase, IRenderTemplate<BlockData>
    {
        private readonly IContentRepository _contentRepository;

        public PreviewController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public ActionResult Index(IContent currentContent)
        {
            var startPage = _contentRepository.Get<PageData>(ContentReference.StartPage);
            var model = new BlockEditPageViewModel(startPage, currentContent);

            return View(model);
        }
    }
}