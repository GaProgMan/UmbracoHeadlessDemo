using Umbraco.Headless.Client.Models;

namespace UmbracoHeadlessCore.Models
{
    public class Hero : ContentItem, IPerson
    {
        public string Fullname { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Citizenship { get; set; }
        public string Aliases { get; set; }
        public string FirstAppearance { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Eyes { get; set; }
        public string Hair { get; set; }
        public string Bio { get; set; }
        public Image Image { get; set; }
        public bool Favorite { get; set; }
    }
}