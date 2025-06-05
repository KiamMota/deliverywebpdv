using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Repository;
using Delivery.Web.Pdv.Database;
using Microsoft.EntityFrameworkCore;
using Delivery.Web.Pdv.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddDbContext<Database>(options =>
    options.UseInMemoryDatabase("DbOfPedidos"));
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IAppService, AppService>();
builder.Services.AddScoped<IDto2O, Dto2O>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("PermitirTudo");

app.UseAuthorization();

app.MapControllers();

app.Run();
