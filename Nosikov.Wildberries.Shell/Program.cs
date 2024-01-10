using Nosikov.Wildberries;
using Nosikov.Wildberries.Shell;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<IWildberesClient, WildberesClient>();
    })
    .Build();

host.Run();