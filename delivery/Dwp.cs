using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Core;
using Delivery.Web.Pdv.Core.Entity;
using Delivery.Web.Pdv.Helper;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IAppService, AppService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

