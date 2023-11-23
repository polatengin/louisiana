var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/", (IConfiguration config) => config.GetValue<string>("Lousiana:Settings:Message"));

app.Run();
