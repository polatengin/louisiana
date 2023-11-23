var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureAppConfiguration(options =>
{
  options
         .Connect(Environment.GetEnvironmentVariable("CONFIGURATION_CONNECTION_STRING"));
});

builder.Services.AddAzureAppConfiguration();

var app = builder.Build();

app.UseAzureAppConfiguration();

app.MapGet("/", (IConfiguration config) => config.GetValue<string>("Lousiana:Settings:Message"));

app.Run();
