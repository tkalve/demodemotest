using DemoDemo.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DemoContext>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
