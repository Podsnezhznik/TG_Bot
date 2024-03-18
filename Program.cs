using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
        services
            .Configure<DbSettings>(context.Configuration.GetSection(nameof(DbSettings)))
            .AddLogging(configure => configure.AddConsole())
            .AddSingleton<UserService>())
    .Build();

//ExampleUserService(host);

await host.RunAsync();

//static void ExampleUserService(IHost host)
//{
//    var _userService = host.Services.GetService<IUserService>();
//
//    //запрашиваем логин/пароль
//    Console.Write("Login: ");
//    var login = Console.ReadLine();
//
//    Console.Write("Pass: ");
//    var pass = Console.ReadLine();
//
//    //проверяем авторизацию
//    var authorized = _userService.CheckAuth(login, pass);
//    Console.WriteLine($"Authorized: {authorized}");
//
//    //если авторизованы, увеличиваем число входов
//    if (authorized)
//    {
//        var user = _userService.GetByLogin(login);
//        _userService.UpdateActivity(user.Id);
//    }
//}