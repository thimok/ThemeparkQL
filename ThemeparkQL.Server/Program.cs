using Microsoft.EntityFrameworkCore;
using ThemeparkQL.Server.Data;
using ThemeparkQL.Server.Domain;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<ApplicationDbContext>()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();