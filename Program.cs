using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateApplicationBuilder(args).Build();

var cfg = host.Services.GetService<IConfiguration>();
var settings = cfg.GetRequiredSection(nameof(DbSettings)).Get<DbSettings>();
Console.WriteLine(settings.ConnectionString);

await host.RunAsync();