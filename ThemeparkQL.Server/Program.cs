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

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowAll", builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

app.MapGraphQL();
app.UseCors("AllowAll");

app.Run();