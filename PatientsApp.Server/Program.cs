using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PatientsApp.Server.Data;

var builder = WebApplication.CreateBuilder(args);

//public class Startup
//{
//    private readonly IConfiguration _config;

//    public Startup(IConfiguration config)
//    {
//        _config = config;
//    }
//}

// Add services to the container.


builder.Services.AddDbContext<DataContext>(options =>
{
    //options.UseSqlite(IConfiguration.Equals("DefaultConnection"));
    options.UseSqlite("Data source=PatientsApp.db");
});

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
