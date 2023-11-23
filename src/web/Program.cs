var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureAppConfiguration(options =>
{
});

builder.Services.AddAzureAppConfiguration();

var app = builder.Build();

app.UseAzureAppConfiguration();

app.MapGet("/", (IConfiguration config) => config.GetValue<string>("Lousiana:Settings:Message"));

app.Run();
