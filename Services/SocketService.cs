using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XtsClient.Services
{
    public class SocketService
    {
        private ClientWebSocket? _socket;

        public async Task StartAsync()
        {
            _socket = new ClientWebSocket();

            Console.WriteLine("Socket: Connecting...");
            await Task.Delay(200);

            Console.WriteLine("Socket: Subscribed to market data...");
            await Task.Delay(200);

            Console.WriteLine("Socket: Receiving data...");
            await Task.Delay(200);

            Console.WriteLine("Socket: Disconnecting...");
        }
    }
}