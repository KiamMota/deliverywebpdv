using AppService.Interfaces.Pedido;
using Domain.Core.Repo.Interfaces;
using Infra.Data.Database;
using Infra.Data.Repositories.RepoPedido;

using Microsoft.EntityFrameworkCore;

using AppService.Mappers.Interfaces;
using AppService.Pedido;
using AppService.Interfaces.EstabelecimentoMappers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("database"));
builder.Services.AddScoped<IProcessPedido, AppPedido>();
builder.Services.AddScoped<IRepoPedido, RepoPedido>();
builder.Services.AddScoped<IEstabelecimentoMapper, EstabelecimentoMapper>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors("PermitirTudo");
app.UseAuthorization();


/* Endpoint dos pedidos */


app.Run();

