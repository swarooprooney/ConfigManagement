using ConfigManagement.Properties.ApiSettings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<HttpSettings>(builder.Configuration.GetSection(HttpSettings.Section));
var app = builder.Build();

app.MapGet("/", GetHttpSettings);

app.Run();


IResult GetHttpSettings([FromServices] IOptionsMonitor<HttpSettings> settings)
{
    return Results.Ok($"The number of retries is {settings.CurrentValue.NumberOfRetries} and the timeout in seconds is {settings.CurrentValue.TimeoutSeconds}");
}
