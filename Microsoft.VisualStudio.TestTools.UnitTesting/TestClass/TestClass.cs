using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests {
  // The class DirectoryTest must be declared with TestClass attribute.
  [TestClass]
  public class DirectoryTest {
    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext) {
    }

    [ClassCleanup]
    public static void ClassCleanup() {
    }

    // This is the method that is called before any tests in a class test are run.
    [TestInitialize]
    public void TestInitialize() {
      savedCurrentDirecory = Environment.CurrentDirectory;
    }

    // This is the method that is called before any tests in a class test are run.
    [TestInitialize]
    public void TestInitialize2() {
      savedCurrentDirecory = Environment.CurrentDirectory;
    }

    // This is the method that is called after any tests in a class test are run.
    [TestCleanup]
    public void TestCleanup() {
      Environment.CurrentDirectory = savedCurrentDirecory;
    }

    [TestMethod]
    public void ChangeCurrentDirectoryWithDownloads() {
      Environment.CurrentDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
    }

    [TestMethod]
    public void ChangeCurrentDirectoryWithPotatoes() {
      Environment.CurrentDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Potatoes");
    }

    private string savedCurrentDirecory;
  }
}
