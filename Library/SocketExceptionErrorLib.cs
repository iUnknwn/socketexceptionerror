using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SocketExceptionErrorLibrary
{
    public class SocketExceptionErrorLib
    {
        TcpListener listener = new TcpListener(IPAddress.Any, 8000);

        public async Task StartListening() {
            listener.Start();

            try {
                while (true) {
                    var client = await listener.AcceptTcpClientAsync();

                    System.Console.WriteLine("Client Connected... Prentending to work here");

                    client.Close();
                }
            }
            catch (Exception e) {
                System.Console.WriteLine("Got exception: " + e);
            }
        }

        public void StopListening() {
            listener.Stop();
        }
    }
}