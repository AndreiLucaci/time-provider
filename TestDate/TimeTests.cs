using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestDate.BLL;

namespace TestDate
{
	[TestClass]
	public class TimeTests
	{
		[TestMethod]
		public void Time_With_Default_Time_Provider_Has_The_Default_DateTime()
		{
			var sut = new Time();

			Assert.AreEqual(sut.Now, TimeProvider.Default.Now);
		}

		[TestMethod]
		public void Time_With_Custom_Time_Provider_Has_DateTime_Changed()
		{
			var expectedNow = DateTime.Now.Subtract(TimeSpan.FromDays(1));
			var timeProviderMoq = new Mock<ITimeProvider>();

			timeProviderMoq.Setup(x => x.Now).Returns(expectedNow);

			var sut = new Time(timeProviderMoq.Object);

			Assert.AreNotEqual(expectedNow, TimeProvider.Default.Now);
			Assert.AreEqual(expectedNow, sut.Now);
		}
	}
}
