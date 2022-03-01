using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Reports.Worker.Configuration;

namespace Reports.Worker
{
	public static class Program
	{
		public static void Main(string[] args)
			=> CreateHostBuilder(args).Build().Run();

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureServices((hostContext, services) =>
				{
					var configuration = hostContext.Configuration;
					services.AddOptionsConfiguration(configuration);
					services.AddDependencyInjectionConfiguration();
					services.AddHostedService<Worker>();
				});
	}
}
