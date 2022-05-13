using Stix_Mongo_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<StixDatabaseSettings>(
    builder.Configuration.GetSection("StixDatabase"));

builder.Services.AddSingleton<StixDatabaseSettings>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//appp.MapControllers();

app.Run();
