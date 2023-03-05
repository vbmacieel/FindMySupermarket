using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using SupermarketAPI.Data;
using SupermarketAPI.Repository;
using SupermarketAPI.Repository.Impl;
using SupermarketAPI.Service;
using SupermarketAPI.Service.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SupermarketContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("SupermarketConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ISupermarketRepository, SupermarketRepository>();
builder.Services.AddScoped<ISupermarketService, SupermarketService>();

builder.Services.AddCors(opts =>
{
    opts.AddPolicy("CORS", corsPolicyBuilder => corsPolicyBuilder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CORS");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
