using AppService.Interfaces.Pedido;
using Domain.Core.Repo.Interfaces;
using Infra.Data.Database;
using Infra.Data.Repositories.RepoPedido;

using Microsoft.EntityFrameworkCore;

using AppService.Pedido;
using AppService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("database"));
builder.Services.AddScoped<IProcessPedido, ProcessPedido>();
builder.Services.AddScoped<IRepoPedido, RepoPedido>();
builder.Services.AddScoped<IPedidoValidation, PedidoValidation>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors("PermitirTudo");
app.UseAuthorization();


/* Endpoint dos pedidos */


app.Run();

