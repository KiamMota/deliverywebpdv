using Infra.Data.Database;
using Microsoft.EntityFrameworkCore;
using Domain.Core.Repo.Interfaces;
using AppService.Interfaces;
using Infra.Data.Repositories;
using AppService;


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
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("database"));
builder.Services.AddScoped<IProcessPedido, ApsPedido>();
builder.Services.AddScoped<IRepoPedido, RepoPedido>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("PermitirTudo");

app.UseAuthorization();

app.MapControllers();

app.Run();
