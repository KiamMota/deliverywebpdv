
using Microsoft.EntityFrameworkCore;
using AppService.UseCases.Interfaces;
using AppService.UseCases;
using Infra.Data.Repositories.Base;
using Infra.Data.Repositories.Interfaces;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IProcessPedido, ProcessPedido>();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 30))
        )
);

builder.Services.AddScoped<IProcessEstabelecimento, ProcessEstabelecimento>();
builder.Services.AddScoped(typeof(ICrudBase<>), typeof(CrudBase<>));

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