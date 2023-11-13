/**
 * FILENAME:    Program.cs
 * PURPOSE:     Contains the Main() method which opens the Server.
 */

using System;
using System.ServiceModel;

using ChatDLL;

namespace ChatServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting up 'ChatServer'...");

            string url = "net.tcp://0.0.0.0:8100/ChatService";
            NetTcpBinding tcp = new NetTcpBinding();
            ServiceHost host = new ServiceHost(typeof(ServerImplementation));

            host.AddServiceEndpoint(typeof(ServerInterface), tcp, url);
            host.Open();

            // Hold the server open until someone does something
            Console.WriteLine("'ChatServer' is Online. Press Enter to exit.");
            Console.ReadLine();
            host.Close();
        }
    }
}
