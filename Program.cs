
using Microsoft.EntityFrameworkCore;
using HabitTracker;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HabitTrackerDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));



// Add services
builder.Services.AddControllers(); // enable traditional controller support
builder.Services.AddEndpointsApiExplorer(); // needed for Swagger
builder.Services.AddSwaggerGen(); // enable Swagger UI

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers(); // connect controller routes

app.Run();
