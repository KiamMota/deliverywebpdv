using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Core;
using Delivery.Web.Pdv.Helper;
using Delivery.Web.Pdv.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.InMemory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IAppService, AppService>();
builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

