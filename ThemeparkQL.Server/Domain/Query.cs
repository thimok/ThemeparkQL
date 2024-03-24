using Microsoft.EntityFrameworkCore;
using ThemeparkQL.Server.Data;

namespace ThemeparkQL.Server.Domain;

public class Query
{
    public List<Themepark> GetThemeparks(ApplicationDbContext context) => context
        .Themeparks
        .Include(x => x.Attractions)
        .ToList();

    public Themepark? GetThemepark(ApplicationDbContext context, Guid id) => context
        .Themeparks
        .Include(x => x.Attractions)
        .FirstOrDefault(x => x.Id == id);
    
    public List<Attraction> GetAttractions(ApplicationDbContext context) => context
        .Attractions
        .Include(x => x.Themepark)
        .ToList();
    
    public Attraction? GetAttraction(ApplicationDbContext context, Guid id) => context
        .Attractions
        .Include(x => x.Themepark)
        .FirstOrDefault(x => x.Id == id);
}