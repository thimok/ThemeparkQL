namespace ThemeparkQL.Server.Domain;

public class Themepark
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string OpeningHours { get; set; }
    public List<Attraction> Attractions { get; set; } = new();
}