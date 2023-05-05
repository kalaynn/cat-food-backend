using System.Configuration;
using WebStore.Core.Models;
using WebStore.Infrastructure;
using WebStore.Infrastructure.Interfaces;
using WebStore.Infrastructure.Repositories;
using WebStore.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<WebStoreContext>();
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();

var app = builder.Build();

app.MapControllers();
app.Run();