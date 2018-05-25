using System;

namespace TestDate.BLL
{
	public class ApplicationTime : IApplicationTime
	{
		private readonly ITimeProvider _timeProvider;

		public ApplicationTime(ITimeProvider timeProvider = null)
		{
			_timeProvider = timeProvider ?? TimeProvider.Default;
		}

		public DateTime Now => _timeProvider.Now;
	}
}
