using System;

namespace TestDate.BLL
{
	public interface ITimeProvider
	{
		DateTime Now { get; }
	}
}
