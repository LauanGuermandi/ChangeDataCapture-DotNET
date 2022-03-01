using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;
using Microsoft.Extensions.Options;
using Reports.Worker.Exceptions;

namespace Reports.Worker.Bus
{
	public abstract class ConsumerBase
	{
		private IConsumer<string, string> _instance;
		private bool _initialized = false;

		protected void InitializeConsumer(IOptions<ConsumerConfig> consumerConfig, string topic)
		{
			_instance = new ConsumerBuilder<string, string>(consumerConfig.Value).Build();
			_instance.Subscribe(topic);
			_initialized = true;
		}

		public async Task Handle(CancellationToken stoppingToken)
		{
			if (!IsInitialized())
			{
				throw new ConsumerNotInitializedException("O Consumidor não foi inicializado.");
			}

			var data = _instance.Consume(stoppingToken);
			await ConsumerHandler(data, stoppingToken);
		}

		public bool IsInitialized()
			=> _initialized;

		public abstract Task ConsumerHandler(ConsumeResult<string, string> data, CancellationToken stoppingToken);
	}
}
