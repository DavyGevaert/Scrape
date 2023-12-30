using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// call the selenium
app.MapGet("/Parser", () => 
{
    try
    {
        ChromeOptions options = new ChromeOptions();
        // does not open a browser when using this argument
        options.AddArguments("--headless");

        //download chromedriver
        //https://googlechromelabs.github.io/chrome-for-testing/
        var chromeDriverPath = "chromedriver-win64";
        using (var driver = new ChromeDriver(chromeDriverPath, options))
        {
            var vdabJobPath = "https://www.vdab.be/vindeenjob/vacatures/68015340/junior-back-end-software-developer?source=vindeenjob&medium=vacaturedashboard";
            var jobDescriptionClassName = "vej-results";
            driver.Navigate().GoToUrl(vdabJobPath);


            IWebElement productElement = driver.FindElement(By.ClassName(jobDescriptionClassName));
            return Results.Ok(productElement.Text);
        }
    }
    catch (Exception ex)
    {
        return Results.Ok(ex.Message);
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
