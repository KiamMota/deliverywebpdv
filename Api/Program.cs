
using Microsoft.EntityFrameworkCore;
using Infra.Data.Repositories.Base;
using Infra.Data.Repositories.Interfaces;
using System;
using Infra.Data.Repositories;
using Infra.Data.DataModels;
using Infra.Data.Mappers;
using AppService.Interfaces;
using AppService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 30))
        )
);

builder.Services.AddScoped(typeof(ICrudBase<,>), typeof(CrudBase<,>));
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IMapperBase<Domain.Core.Entities.Endereco.Endereco, DataEndereco>, EnderecoMapper>();
builder.Services.AddScoped<IEnderecoGravar, EnderecoGravar>();


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