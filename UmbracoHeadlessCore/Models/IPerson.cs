namespace UmbracoHeadlessCore.Models
{
    public interface IPerson
    {
        string Fullname { get; set; }
        string PlaceOfBirth { get; set; }
        string Citizenship { get; set; }
        string Aliases { get; set; }
        string FirstAppearance { get; set; }
        string Height { get; set; }
        string Weight { get; set; }
        string Eyes { get; set; }
        string Hair { get; set; }
        string Bio { get; set; }
        Image Image { get; set; }
    }
}