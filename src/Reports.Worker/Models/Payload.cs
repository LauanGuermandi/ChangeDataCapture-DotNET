using System.Text.Json.Serialization;

namespace Reports.Worker.Models
{
	public class Payload
	{
		[JsonPropertyName("after")]
		public object After { get; set; }

		[JsonPropertyName("source")]
		public Source Source { get; set; }
	}
}
