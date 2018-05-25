using System;

namespace TestDate.BLL
{
	public class ServerTimeProvider : ITimeProvider
	{
		private static ITimeProvider _current;

		public DateTime Now => DateTime.Now;

		public static ITimeProvider Current => _current ?? (_current = new ServerTimeProvider());
	}
}
