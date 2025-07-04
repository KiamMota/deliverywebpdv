
using Microsoft.EntityFrameworkCore;
using Infra.Data.Repositories.Base;
using System;
using Infra.Data.Repositories;
using Infra.Data.DataModels;
using Infra.Data.Mappers;
using AppService.Interfaces;
using AppService;
using Infra.Data.Repositories.Interfaces;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 30))
        )
);

builder.Services.AddScoped(typeof(ICrudBase<,>), typeof(CrudBase<,>));

builder.Services.AddScoped<IEnderecoRepo, EnderecoRepo>();
builder.Services.AddScoped<IPedidoRepo, PedidoRepo>();
builder.Services.AddScoped<IClienteRepo, ClienteRepo>();
builder.Services.AddScoped<IProdutoRepo, ProdutoRepo>();

builder.Services.AddScoped<IEnderecoGravar, EnderecoGravar>();

builder.Services.AddScoped<IMapperBase<Domain.Core.Entities.Endereco.Endereco, EnderecoDb>, EnderecoMapper>();
builder.Services.AddScoped<IMapperBase<Domain.Core.Entities.Cliente.Cliente, ClienteDb>, ClienteMapper>();
builder.Services.AddScoped<IMapperBase<Domain.Core.Entities.Pedido.Pedido, PedidoDb>, PedidoMapper>();
builder.Services.AddScoped<IMapperBase<Domain.Core.Entities.Produto.Produto, ProdutoDb>, ProdutoMapper>();





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