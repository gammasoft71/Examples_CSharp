using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CSharpConsole {
  class Program {
    public static void Main() {
      Console.WriteLine("Press Ctrl+C to quit...");
      Thread server = new Thread(new ThreadStart(delegate {
        UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Any, 8082));
        while (true) {
          IPEndPoint incomingInformationEndpoint = new IPEndPoint(IPAddress.Any, 0);
          byte[] bytes = udpClient.Receive(ref incomingInformationEndpoint);
          string s = Encoding.UTF8.GetString(bytes);
          Console.WriteLine(s);
        }
      }));

      server.Start();

      Thread client = new Thread(new ThreadStart(delegate {
        UdpClient udpClient = new UdpClient();
        int counter = new Random().Next(1, 20000);
        while (true) {
          byte[] bytes = Encoding.UTF8.GetBytes(string.Format("Counter={0}", counter++));
          udpClient.Send(bytes, bytes.Length, "127.0.0.1", 8082);
          Thread.Sleep(250);
        }
      }));

      client.Start();

      server.Join();
      client.Join();
    }
  }
}

// This code example can produce the following output:
//
// Counter=13975
// Counter=13976
// Counter=13977
// Counter=13978
// ...
