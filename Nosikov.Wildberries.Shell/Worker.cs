namespace Nosikov.Wildberries.Shell;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IWildberesClient _wildberesClient;

    public Worker(ILogger<Worker> logger, IWildberesClient wildberesClient)
    {
        _logger = logger;
        _wildberesClient = wildberesClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);


        //GetParameters in DateBase

        var searchWbParameters = CreateMessage("Джинсы", 1);
        var result = await _wildberesClient.SearchAsync(searchWbParameters);
        var names = string.Join(", ", result.Data.Products.Select(i => i.Name));
        _logger.LogInformation(names);

        //saveToDb
    }


    private SearchWbParameters CreateMessage(string query, int page)
    {
        return new SearchWbParameters()
        {
            TestGroup = "no_test",
            TestId = "no_test",
            AppType = 1,
            Curr = "rub",
            Dest = -445278,
            Page = page,
            Query = query,
            Resultset = "catalog",
            Sort = "popular",
            Spp = 27,
            SuppressSpellcheck = false,
            Uclusters = 0
        };
    }
}