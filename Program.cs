using Microsoft.Extensions.Configuration;

var cfg = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();

Console.WriteLine(cfg["Secret"]);