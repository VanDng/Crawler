using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

public class ThreadWatcher : BackgroundService
{
    private readonly ILogger<ThreadWatcher> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        throw new System.NotImplementedException();
    }
}