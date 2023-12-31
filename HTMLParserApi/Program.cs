using HTMLParserApi.DTO;
using Infrastructuur.Services.Classes;
using Infrastructuur.Services.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Concurrent;
using System.Diagnostics;
using HTMLParserApi.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.UseConfiguration();

var app = builder.Build();
//allow the origins cors

app.UseCors("AllowMultipleOrigins");

app.MapGet("/api/scrape/Parser",  async (IHtmlParserService parser) =>
{
    try
    {
        var vacancyNumber = 68015340;
        var vacancies = await parser.JobDescriptionParserAsync(5,vacancyNumber);
        return Results.Ok(vacancies);

    }
    catch (Exception ex)
    {
        return Results.BadRequest(ex.Message);
    }

});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
