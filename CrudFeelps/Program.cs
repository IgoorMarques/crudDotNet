using dominio.Generics;
using Dominio;
using infra;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextBase>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), new MariaDbServerVersion(new Version(8, 0, 35))));

builder.Services.AddSingleton(typeof(InterfaceGenerica<>), typeof(RepositorioGenerics<>));
builder.Services.AddSingleton<InterfaceVaga, RepositorioVaga>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
    builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

app.UseAuthorization();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
