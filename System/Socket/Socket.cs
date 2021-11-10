using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Examples {
  class SocketExample {
    public static void Main(string[] args) {
      Console.WriteLine("Press press any key to quit...");
      bool terminate = false;
      Thread server = new Thread(new ThreadStart(delegate {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(new IPEndPoint(IPAddress.Any, 9050));
        socket.Listen((int)SocketOptionName.MaxConnections);
        Socket socketWithClient = socket.Accept();
        while(!terminate) {
          byte[] buffer = new byte[256];
          int count = socketWithClient.Receive(buffer);
          string s = Encoding.Default.GetString(buffer, 0, count);
          Console.WriteLine(s);
        }
      }));
      server.Start();

      Thread client = new Thread(new ThreadStart(delegate {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect("127.0.0.1", 9050);
        int counter = new Random().Next(1, 20000);
        while(!terminate) {
          Thread.Sleep(25);
          socket.Send(Encoding.Default.GetBytes(string.Format("Counter={0}", counter++)));
        }
      }));
      client.Start();

      Console.ReadKey(true);
      terminate = true;

      server.Join();
      client.Join();
     }
  }
}

// This code example can produce the following output:
//
// Counter=186
// Counter=187
// Counter=188
// Counter=189
// ...
