using System.Threading;
using System.Threading.Tasks;

namespace Reports.Worker.Interfaces
{
	public interface IChangedDataConsumer
	{
		Task Handle(CancellationToken stoppingToken);
	}
}
