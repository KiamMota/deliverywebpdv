using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;

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
app.UseCors("PermitirTudo");
app.UseAuthorization();


/* Endpoint dos pedidos */
RouteGroupBuilder pedidoEndpoint = app.MapGroup("/api/pedidos");

pedidoEndpoint.MapPost("/", ([Required] PedidoRequest pedido, IProcessPedido _apps) =>
{
    return _apps.SalvarPedido(pedido);
});

pedidoEndpoint.MapGet("/{id}", (int id, IProcessPedido _apps) =>
{
    return _apps.PegarPedidoById(id);
});

pedidoEndpoint.MapPut("/{id}", (int id, PedidoRequest pedido, IProcessPedido _apps) =>
{
    return _apps.AlterarPedidoById(pedido, id);
});

pedidoEndpoint.MapDelete("/{id}", (int id, IProcessPedido _apps) =>
{
    return _apps.RemoverPedidoById(id);
});

app.Run();

