using System.Collections.Generic;

namespace Reports.Worker.Extensions
{
	public static class ObjectExtensions
	{
		public static IDictionary<string, object> AsDictionary(this object source)
		{
			var myObjectType = source.GetType();
			IDictionary<string, object> dict = new Dictionary<string, object>();
			var indexer = new object[0];
			var properties = myObjectType.GetProperties();
			foreach (var info in properties)
			{
				var value = info.GetValue(source, indexer);
				dict.Add(info.Name, value);
			}
			return dict;
		}
	}
}
