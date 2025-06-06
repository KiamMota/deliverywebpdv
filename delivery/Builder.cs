using Contracts;
using Microsoft.AspNetCore.DataProtection.Repositories;


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
//builder.Services.AddDbContext<Database>(options =>
//options.UseInMemoryDatabase("DbOfPedidos"));


var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("PermitirTudo");

app.UseAuthorization();

app.MapControllers();

app.Run();
