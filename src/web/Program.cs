var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureAppConfiguration(options =>
{
  options.ConfigureRefresh(refresh =>
         {
           refresh.Register("Lousiana:Settings:Version", refreshAll: true)
                  .SetCacheExpiration(new TimeSpan(0, 0, 5));
         })
         .Connect(Environment.GetEnvironmentVariable("CONFIGURATION_CONNECTION_STRING"));
});

builder.Services.AddAzureAppConfiguration();

var app = builder.Build();

app.UseAzureAppConfiguration();

app.MapGet("/", (IConfiguration config) => config.GetValue<string>("Lousiana:Settings:Message"));

app.Run();
