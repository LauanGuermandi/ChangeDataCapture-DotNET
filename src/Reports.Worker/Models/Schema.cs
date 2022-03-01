using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Reports.Worker.Models
{
	public class Schema
	{
		[JsonPropertyName("fields")]
		public List<Field> Fields { get; set; }

		[JsonPropertyName("optional")]
		public bool Optional { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}
}
