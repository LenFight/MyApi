
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (context) =>
{
await context.Response.WriteAsync("Hello world");
});

app.Run();
