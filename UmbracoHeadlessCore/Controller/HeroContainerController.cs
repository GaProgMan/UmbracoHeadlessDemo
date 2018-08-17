using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Headless.Client.Services;
using Umbraco.Headless.Client.Web;
using UmbracoHeadlessCore.Models;

namespace UmbracoHeadlessCore.Controller
{
    public class HeroContainerController : DefaultUmbracoController
    {
        public HeroContainerController(UmbracoContext umbracoContext, HeadlessService headlessService) : base(umbracoContext, headlessService)
        {
        }

        public override async Task<IActionResult> Index()
        {
            //get the content for the current route
            var content = UmbracoContext.GetContent();
            
            //get all children of the container
            //var children = (await HeadlessService.Query().GetAll()).Where(x => x.ParentId.Equals(content.Id));
            var children = await HeadlessService.GetChildren<Hero>(content);

            var model = HeadlessService.MapTo<HeroContainer>(content);
            model.Children = children;//children.Select(hero => HeadlessService.MapTo<Hero>(hero));

            //return the view which will be located at /Views/Page/Index.cshtml
            return View(model);
        }
    }
}