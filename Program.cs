using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.Urls.Add("https://farazwebapp-ebepfvhagvehhkb3.canadacentral-01.azurewebsites.net/");
app.MapGet("/", () => Results.Ok("Hello World!"));
app.Run();