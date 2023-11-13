using System;
using System.Net.Sockets;

//This is the server class for all connection to the server
//Need to check whether this server needs to be local or an actual server

namespace Assignment1_DC.Connection
{
    class Server
    {
        TcpClient client;

        public Server()
        {
            client = new TcpClient();
        }


        public void Connect()
        {
            if(client.Connected == false)
            {
                client.Connect("127.0.0.1", 5001);
                Console.WriteLine("Connection Success");
            }
        }
    }
}
