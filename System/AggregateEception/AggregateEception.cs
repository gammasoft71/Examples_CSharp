using System;
using System.IO;
using System.Threading.Tasks;

namespace Examples {
  class Program {
    public static void Main() {
      // Get a folder path whose directories should throw an UnauthorizedAccessException.
      string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)).FullName;

      // Use this line to throw UnauthorizedAccessException, which we handle.
      //Task<Array<string>> task1 = Task<>.Factory().StartNew<Array<string>>(delegate_ {return GetAllFiles(path);});

      // Use this line to throw an exception that is not handled.
      Task task1 = Task.Factory.StartNew(delegate { throw new IndexOutOfRangeException(); });
      try {
        task1.Wait();
      } catch (AggregateException ae) {
        ae.Handle(delegate(Exception x) {
          if (x is UnauthorizedAccessException) {// This we know how to handle.
            Console.WriteLine("You do not have permission to access all folders in this path.");
            Console.WriteLine("See your network administrator or try another path.");
            return true;
          }
          return false; // Let anything else stop the application.
        });
      }

      Console.WriteLine("task1 Status: {0}{1}", task1.IsCompleted ? "Completed," : "", task1.Status);
      }

    private static string[] GetAllFiles(string str) {
      // Should throw an UnauthorizedAccessException exception.
      return System.IO.Directory.GetFiles(str, "*.txt", System.IO.SearchOption.AllDirectories);
    }
  }
}
