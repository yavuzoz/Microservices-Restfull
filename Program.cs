/**
 * @author  Cristian Hume Henriquez
 * @version 1.0.0
 * @since   2022.11.11
 */

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

