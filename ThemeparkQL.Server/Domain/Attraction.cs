namespace ThemeparkQL.Server.Domain;

public class Attraction
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public AttractionCategory Category { get; set; }
    public double MinHeight { get; set; }
    public string ImageUrl { get; set; }
    public Themepark Themepark { get; set; }
}