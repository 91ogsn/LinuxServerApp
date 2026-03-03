var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hej från min Ubuntu-server!");

app.Run();
