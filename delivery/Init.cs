using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Repository;
using Delivery.Web.Pdv.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<Database>(options => options.UseInMemoryDatabase("DbOfPedidos"));
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IAppService, AppService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();

