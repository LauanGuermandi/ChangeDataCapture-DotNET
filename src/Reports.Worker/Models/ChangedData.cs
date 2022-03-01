using System.Text.Json.Serialization;

namespace Reports.Worker.Models
{
	public class ChangedData
	{
		[JsonPropertyName("payload")]
		public Payload Payload { get; set; }

		[JsonPropertyName("schema")]
		public Schema Schema { get; set; }
	}
}
