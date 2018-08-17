using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Headless.Client.Services;
using Umbraco.Headless.Client.Web;
using UmbracoHeadlessCore.Models;

namespace UmbracoHeadlessCore.Controller
{
    public class HeroController : DefaultUmbracoController
    {
        public HeroController(UmbracoContext umbracoContext, HeadlessService headlessService) : base(umbracoContext, headlessService)
        {
        }

        public override Task<IActionResult> Index()
        {
            //get the content for the current route
            var content = UmbracoContext.GetContent();
            //map the ContentItem to a custom model called Page (which would inherit from ContentItem)
            var model = HeadlessService.MapTo<Hero>(content);
            //return the view which will be located at /Views/Page/Index.cshtml
            return Task.FromResult((IActionResult)View(model));
        }
    }
}