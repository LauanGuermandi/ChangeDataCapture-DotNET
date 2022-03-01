using System.Text.Json.Serialization;

namespace Reports.Worker.Models
{
	public class Source
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("connector")]
		public string Connector { get; set; }

		[JsonPropertyName("db")]
		public string Db { get; set; }

		[JsonPropertyName("table")]
		public string Table { get; set; }
	}
}
