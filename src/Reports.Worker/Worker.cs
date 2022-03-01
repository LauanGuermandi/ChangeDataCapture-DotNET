using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Reports.Worker.Interfaces;

namespace Reports.Worker
{
	public class Worker : BackgroundService
	{
		private readonly ILogger<Worker> _logger;
		private readonly IChangedDataConsumer _changedDataConsumer;

		public Worker(
			ILogger<Worker> logger,
			IChangedDataConsumer changedDataConsumer
		)
		{
			_logger = logger;
			_changedDataConsumer = changedDataConsumer;
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			_logger.LogInformation("Starting...");

			while (!stoppingToken.IsCancellationRequested)
			{
				await _changedDataConsumer.Handle(stoppingToken);
				await Task.Delay(1000, stoppingToken);
			}
		}
	}
}
