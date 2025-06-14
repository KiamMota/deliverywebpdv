using AppService.Interfaces.Pedido;
using Domain.Core.Repo.Interfaces;
using Infra.Data.Database;
using Infra.Data.Repositories.RepoPedido;

using Microsoft.EntityFrameworkCore;

using AppService.Pedido;
using AppService;
using AppService.Interfaces.Estabelecimento;
using AppService.Estabelecimento;
using Infra.Data.Repositories.Interfaces;
using Infra.Data.Repositories.RepoEstabelecimento;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("database"));
builder.Services.AddScoped<IProcessPedido, ProcessPedido>();
builder.Services.AddScoped<IRepoPedido, RepoPedido>();
builder.Services.AddScoped<IPedidoValidation, PedidoValidation>();
builder.Services.AddScoped<IRepoEstabelecimento, RepoEstabelecimento>();
builder.Services.AddScoped<IProcessEstabelecimento, ProcessEstabelecimento>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("DevPolicy", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();
app.UseCors("DevPolicy");
app.UseHttpsRedirection();
app.UseCors("PermitirTudo");
app.UseAuthorization();
app.MapControllers();
app.UseRouting();

/* Endpoint dos pedidos */


app.Run();

