using Infra.Data.Database;
using Microsoft.EntityFrameworkCore;
using Domain.Core.Repo.Interfaces;
using AppService;
using AppService.Interfaces.Pedido;
using Infra.Data.Repositories.RepoPedido;
using System.ComponentModel.DataAnnotations;


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
builder.Services.AddScoped<IProcessPedido, AppPedido>();
builder.Services.AddScoped<IRepoPedido, RepoPedido>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("id/", ([Required] int id) => $"Id: {id}");

app.UseCors("PermitirTudo");

app.UseAuthorization();

app.MapControllers();

app.Run();
