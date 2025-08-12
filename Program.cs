var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// simple health check + homepage
app.MapGet("/", () => "BritEdge POC running on Azure App Service (.NET 8)!");

// optional: an about endpoint
app.MapGet("/about", () => new { app = "BritEdge POC", runtime = "ASP.NET Core 8" });

app.Run();
