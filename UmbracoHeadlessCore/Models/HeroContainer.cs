using System.Collections.Generic;
using Umbraco.Headless.Client.Models;

namespace UmbracoHeadlessCore.Models
{
    public class HeroContainer : ContentItem
    {
        public IEnumerable<Hero> Children { get; set; }
    }
}