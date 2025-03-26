
using Microsoft.EntityFrameworkCore;
using pjt.apc.crud.produto.api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProdutosContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DbCon")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();