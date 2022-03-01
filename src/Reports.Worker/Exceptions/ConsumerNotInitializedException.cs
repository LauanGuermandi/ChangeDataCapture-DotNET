using System;
using System.Runtime.Serialization;

namespace Reports.Worker.Exceptions
{
	[Serializable]
	public class ConsumerNotInitializedException : Exception
	{
		public ConsumerNotInitializedException(string message) : base(message)
		{
		}

		protected ConsumerNotInitializedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
