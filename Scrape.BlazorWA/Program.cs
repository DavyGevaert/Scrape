using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Scrape.BlazorWA;
using Scrape.BlazorWA.Settings;
using Scrape.Data.Helpers;
using Scrape.Sdk;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var settings = new AppSettings();
builder.Configuration.GetSection(nameof(AppSettings)).Bind(settings);
builder.Services.AddSingleton(settings);

builder.Services.AddHttpClient("Scrape", options =>
{
    options.BaseAddress = new Uri(settings.ApiBaseUrl);
});

builder.Services.AddTransient<Data>();
builder.Services.AddTransient<ScrapeApi>();

builder.Services.AddBlazorBootstrap();

var app = builder.Build();

await builder.Build().RunAsync();
