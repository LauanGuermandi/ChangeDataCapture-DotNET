using System.Text.Json.Serialization;

namespace Reports.Worker.Models
{
	public class Field
	{
		[JsonPropertyName("optional")]
		public bool Optional { get; set; }

		[JsonPropertyName("field")]
		public string Content { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("version")]
		public int? Version { get; set; }
	}
}
