using LearnEnglish.API.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var config = builder.Configuration;
// Add services to the container.
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
string connectionString = config.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<LearnEnglishDbContext>(x =>
               x.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
               builder =>
               {
                   builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
               }).EnableSensitiveDataLogging());

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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
