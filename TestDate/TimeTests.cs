using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestDate.BLL;

namespace TestDate
{
	[TestClass]
	public class TimeTests
	{
		private IApplicationTime _sut;

		[TestMethod]
		public void ApplicationTime_With_Default_Time_Provider_Has_The_Default_DateTime()
		{
			_sut = new ApplicationTime();

			Assert.AreEqual(_sut.Now, ServerTimeProvider.Current.Now);
		}

		[TestMethod]
		public void ApplicationTime_With_Custom_Time_Provider_Has_DateTime_Changed()
		{
			var expectedNow = DateTime.Now.Subtract(TimeSpan.FromDays(1));
			var timeProviderMoq = new Mock<ITimeProvider>();

			timeProviderMoq.Setup(x => x.Now).Returns(expectedNow);

			_sut = new ApplicationTime(timeProviderMoq.Object);

			Assert.AreNotEqual(expectedNow, ServerTimeProvider.Current.Now);
			Assert.AreEqual(expectedNow, _sut.Now);
		}
	}
}
