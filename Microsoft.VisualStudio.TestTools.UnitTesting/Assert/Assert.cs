using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests {
  // The class TimeSpanTest must be inherited from TestFixture
  [TestClass]
  public class TimeSpanTest {
    // Used Assert.AreEqual method to test value
    [TestMethod]
    public void CreateTimeSpanFromDateTime() {
      DateTime n = new DateTime(2015, 9, 5, 9, 15, 0);
      TimeSpan ts = new TimeSpan(n.Ticks);
      Assert.AreEqual(9, ts.Hours);
      Assert.AreEqual(15, ts.Minutes);
    }

    // Used Assert.IsTrue to virifie if a condition is true
    [TestMethod]
    public void TimeSpanIsEqualToAnotherTimeSpan() {
      TimeSpan ts = new TimeSpan(10, 42, 24);
      Assert.IsTrue(ts.Equals(new TimeSpan(10, 42, 24)));
    }

    // Used Assert.IsFalse to virifie if a condition is false
    [TestMethod]
    public void DefaultTimeSpanIsEqualToZero() {
      Assert.IsFalse(new TimeSpan(1) == TimeSpan.Zero);
    }
  }
}
