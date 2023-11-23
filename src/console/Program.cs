using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateApplicationBuilder(args).Build();

Console.WriteLine("Hello, World!");

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true)
    .AddEnvironmentVariables()
    .AddAzureAppConfiguration(options =>
    {
      options.UseFeatureFlags().Connect(Environment.GetEnvironmentVariable("CONFIGURATION_CONNECTION_STRING"));
    })
    .Build();

var backgroundColor = config.GetValue<string>("Lousiana:Settings:BackgroundColor");
var fontColor = config.GetValue<string>("Lousiana:Settings:FontColor");
var message = config.GetValue<string>("Lousiana:Settings:Message");

Console.WriteLine($"BackgroundColor = {backgroundColor}");
Console.WriteLine($"FontColor = {fontColor}");
Console.WriteLine($"Message = {message}");

await host.RunAsync();
