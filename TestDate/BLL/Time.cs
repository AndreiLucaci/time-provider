using System;

namespace TestDate.BLL
{
	public class Time : ITime
	{
		public Time(ITimeProvider timeProvider = null)
		{
			Now = (timeProvider ?? TimeProvider.Default).Now;
		}

		public DateTime Now { get; }
	}
}
