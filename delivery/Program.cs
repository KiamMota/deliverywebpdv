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
using Infra.Data.Repositories.User;
using AppService.Interfaces.User;
using AppService.User;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  
builder.Services.AddScoped<IProcessPedido, ProcessPedido>();
builder.Services.AddScoped<IRepoPedido, RepoPedido>();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 30))
        )
);

builder.Services.AddScoped<IPedidoValidation, PedidoValidation>();
builder.Services.AddScoped<IRepoEstabelecimento, RepoEstabelecimento>();
builder.Services.AddScoped<IProcessEstabelecimento, ProcessEstabelecimento>();
builder.Services.AddScoped<IRepoUser, RepoUser>();
builder.Services.AddScoped<IProcessUser, ProcessUser>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));


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
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

