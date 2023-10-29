using HK.Lawand.Learnings.DataService.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//get connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Initialising my DbContext
builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
