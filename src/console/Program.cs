using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateApplicationBuilder(args).Build();

Console.WriteLine("Hello, World!");

await host.RunAsync();
