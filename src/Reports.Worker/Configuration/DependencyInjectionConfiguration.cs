using Microsoft.Extensions.DependencyInjection;
using Reports.Worker.Bus;
using Reports.Worker.Interfaces;

namespace Reports.Worker.Configuration
{
	public static class DependencyInjectionConfiguration
	{
		public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services)
		{
			services.AddSingleton<IChangedDataConsumer, ChangedDataConsumer>();
			return services;
		}
	}
}
