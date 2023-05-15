using AutoMapper.Extensions.ExpressionMapping;
using BusinessLayer.ImplementationsOfManagers;
using BusinessLayer.InterfacesOfManagers;
using DataLayer;
using DataLayer.ImplementationsOfRepo;
using DataLayer.InterfacesOfRepo;
using EntityLayer.Mappings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
});

//automapper ayarlari
builder.Services.AddAutoMapper(x =>
{
    x.AddExpressionMapping();
    x.AddProfile(typeof(Maps));
});

//interfacelerin AddScoped seklindeki yasam donguleri eklenecek 

builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<IStudentManager, StudentManager>();


// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
