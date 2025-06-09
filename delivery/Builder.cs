using Contracts;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Infra.Data.Database;
using Microsoft.EntityFrameworkCore;
using Infra.Data.Interfaces;
using Infra.Data.Repositories;


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
builder.Services.AddScoped<IPedidoRepository, RepoPedido>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("PermitirTudo");

app.UseAuthorization();

app.MapControllers();

app.Run();
