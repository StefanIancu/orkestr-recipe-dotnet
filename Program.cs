var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "hello from .NET on orkestr");
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.Run();
