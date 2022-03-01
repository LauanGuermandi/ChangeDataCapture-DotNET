using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Reports.Worker.Configuration
{
	public static class OptionsConfiguration
	{
		public static IServiceCollection AddOptionsConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<ConsumerConfig>(configuration.GetSection(nameof(ConsumerConfig)));
			return services;
		}
	}
}
