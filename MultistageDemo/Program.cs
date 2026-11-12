
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Azure DevOps Multistage Pipeline toimii!");

app.Run();
