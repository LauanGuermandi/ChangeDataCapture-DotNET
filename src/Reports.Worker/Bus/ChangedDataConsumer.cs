using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Reports.Worker.Interfaces;
using Reports.Worker.Models;

namespace Reports.Worker.Bus
{
	public class ChangedDataConsumer : ConsumerBase, IChangedDataConsumer
	{
		private const string _topicName = "reportserver.dbo.PESSOA";

		public ChangedDataConsumer(IOptions<ConsumerConfig> consumerConfig)
			=> InitializeConsumer(consumerConfig, _topicName);

		public override Task ConsumerHandler(ConsumeResult<string, string> data, CancellationToken stoppingToken)
		{
			var json = JsonSerializer.Deserialize<ChangedData>(data.Message.Value);
			var table = json.Payload.Source.Table;
			var changedData = JObject.Parse(json.Payload.After.ToString());

			foreach (var field in changedData)
			{
				Console.WriteLine($"Coluna: {field.Key}, Valor: {field.Value}, Tabela: {table}");
			}

			return Task.CompletedTask;
		}
	}
}
