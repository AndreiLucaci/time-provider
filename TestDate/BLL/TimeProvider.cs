using System;

namespace TestDate.BLL
{
	public class TimeProvider : ITimeProvider
	{
		public DateTime Now { get; set; }

		public static ITimeProvider Default =  new TimeProvider
		{
			Now = DateTime.Now
		};
	}
}
