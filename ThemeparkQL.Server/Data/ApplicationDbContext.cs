using Microsoft.EntityFrameworkCore;
using ThemeparkQL.Server.Domain;

namespace ThemeparkQL.Server.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Themepark> Themeparks { get; set; }
    public DbSet<Attraction> Attractions { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     var bigThunderMountain = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Big Thunder Mountain",
    //         Description =
    //             "Big Thunder Mountain is a mine train roller coaster located in Frontierland at several Disneyland-style Disney Parks worldwide.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl =
    //             "https://upload.wikimedia.org/wikipedia/en/9/9b/Big_Thunder_Mountain_Railroad.jpg",
    //         MinHeight = 1.02
    //     };
    //
    //     var phantomManor = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Phantom Manor",
    //         Description =
    //             "Phantom Manor is an attraction located in Frontierland at Disneyland Park in Disneyland Paris.",
    //         Category = AttractionCategory.DarkRide,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Phantom_Manor.jpg",
    //         MinHeight = 0.80
    //     };
    //
    //     var spaceMountain = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Space Mountain",
    //         Description =
    //             "Space Mountain is the name of a space-themed indoor roller coaster attraction located at five of the six Disneyland-style Disney Parks.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Space_Mountain.jpg",
    //         MinHeight = 1.32
    //     };
    //
    //     var piratesOfTheCaribbean = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Pirates of the Caribbean",
    //         Description =
    //             "Pirates of the Caribbean is a dark ride at Disneyland Park, Walt Disney World's Magic Kingdom, Tokyo Disneyland, Disneyland Park at Disneyland Paris, and Shanghai Disneyland Park.",
    //         Category = AttractionCategory.DarkRide,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Pirates_of_the_Caribbean.jpg",
    //         MinHeight = 0.90
    //     };
    //
    //     var itsASmallWorld = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "It's a Small World",
    //         Description =
    //             "It's a Small World is a water-based dark ride located in the Fantasyland area at the various Walt Disney Parks and Resorts worldwide.",
    //         Category = AttractionCategory.DarkRide,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/It's_a_Small_World.jpg",
    //         MinHeight = 0.90
    //     };
    //
    //     var disneyLandParis = new Themepark()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Disneyland Paris",
    //         Location = "Paris, France",
    //         Description =
    //             "Disneyland Paris, originally Euro Disney Resort, is an entertainment resort in Marne-la-Vallée, France, a new town located 32 km east of the centre of Paris.",
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Disneyland_Paris_logo.svg",
    //         OpeningHours = "09:00 - 20:00",
    //         Attractions = new List<Attraction>
    //         {
    //             bigThunderMountain,
    //             phantomManor,
    //             spaceMountain,
    //             piratesOfTheCaribbean,
    //             itsASmallWorld
    //         }
    //     };
    //
    //     bigThunderMountain.Themepark = disneyLandParis;
    //     phantomManor.Themepark = disneyLandParis;
    //     spaceMountain.Themepark = disneyLandParis;
    //     piratesOfTheCaribbean.Themepark = disneyLandParis;
    //     itsASmallWorld.Themepark = disneyLandParis;
    //
    //     var baron1898 = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Baron 1898",
    //         Description = "Baron 1898 is a dive coaster at the Efteling theme park in the Netherlands.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Baron_1898.jpg",
    //         MinHeight = 1.40
    //     };
    //
    //     var symbolica = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Symbolica",
    //         Description =
    //             "Symbolica is a trackless dark ride at the Efteling theme park in the Netherlands.",
    //         Category = AttractionCategory.DarkRide,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Symbolica.jpg",
    //         MinHeight = 0.90
    //     };
    //
    //     var vogelRok = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Vogel Rok",
    //         Description =
    //             "Vogel Rok is an enclosed roller coaster in the Efteling amusement park in the Netherlands.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Vogel_Rok.jpg",
    //         MinHeight = 1.20
    //     };
    //
    //     var python = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Python",
    //         Description =
    //             "Python is a double-loop corkscrew roller coaster in the Efteling amusement park in the Netherlands.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Python.jpg",
    //         MinHeight = 1.20,
    //     };
    //
    //     var efteling = new Themepark()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Efteling",
    //         Location = "Kaatsheuvel, Netherlands",
    //         Description = "Efteling is a fantasy-themed amusement park in Kaatsheuvel in the Netherlands.",
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1b/Efteling_logo.svg",
    //         OpeningHours = "10:00 - 18:00",
    //         Attractions = new List<Attraction>
    //         {
    //             baron1898,
    //             symbolica,
    //             vogelRok,
    //             python
    //         }
    //     };
    //
    //     baron1898.Themepark = efteling;
    //     symbolica.Themepark = efteling;
    //     vogelRok.Themepark = efteling;
    //     python.Themepark = efteling;
    //
    //     var blueFire = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Blue Fire",
    //         Description = "Blue Fire is a launched roller coaster at Europa-Park.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Blue_Fire.jpg",
    //         MinHeight = 1.40
    //     };
    //
    //     var euroMir = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Euro-Mir",
    //         Description = "Euro-Mir is a spinning roller coaster located at Europa-Park.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Euro-Mir.jpg",
    //         MinHeight = 1.30
    //     };
    //
    //     var piratesInBatavia = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Pirates in Batavia",
    //         Description = "Pirates in Batavia is a boat ride at Europa-Park.",
    //         Category = AttractionCategory.DarkRide,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Pirates_in_Batavia.jpg",
    //         MinHeight = 0.90
    //     };
    //
    //     var silverStar = new Attraction()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Silver Star",
    //         Description = "Silver Star is a steel roller coaster located at Europa-Park.",
    //         Category = AttractionCategory.RollerCoaster,
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Silver_Star.jpg",
    //         MinHeight = 1.40
    //     };
    //
    //     var europaPark = new Themepark()
    //     {
    //         Id = Guid.NewGuid(),
    //         Name = "Europa-Park",
    //         Location = "Rust, Germany",
    //         Description = "Europa-Park is a theme park located in Rust, Germany.",
    //         ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Europa-Park_logo.svg",
    //         OpeningHours = "09:00 - 18:00",
    //         Attractions = new List<Attraction>
    //         {
    //             blueFire,
    //             euroMir,
    //             piratesInBatavia,
    //             silverStar
    //         }
    //     };
    //
    //     blueFire.Themepark = europaPark;
    //     euroMir.Themepark = europaPark;
    //     piratesInBatavia.Themepark = europaPark;
    //     silverStar.Themepark = europaPark;
    //
    //     modelBuilder.Entity<Attraction>().HasData(bigThunderMountain, phantomManor, spaceMountain,
    //         piratesOfTheCaribbean, itsASmallWorld, baron1898, symbolica, vogelRok, python, blueFire, euroMir,
    //         piratesInBatavia, silverStar);
    //     modelBuilder.Entity<Themepark>().HasData(disneyLandParis, efteling, europaPark);
    // }
}