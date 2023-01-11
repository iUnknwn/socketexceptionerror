using System;
using SocketExceptionErrorLibrary;
using System.Threading.Tasks;
using System.Threading;

namespace SocketExceptionRunner {
    class Program
    {
        static async Task Main(string[] args)
        {
            var socketLibrary = new SocketExceptionErrorLib();

            Console.WriteLine("Starting listener");
            var listenTask = socketLibrary.StartListening();

            Console.WriteLine("Listener Started");


            Thread.Sleep(500);
            
            Console.WriteLine("Stopping Listener");
            socketLibrary.StopListening();

            await listenTask;
        }
    }

}
