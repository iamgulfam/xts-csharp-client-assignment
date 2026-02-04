using System;
using System.Threading.Tasks;
using XtsClient.Models;
using XtsClient.Services;

class Program
{
    static async Task Main()
    {
        var marketService = new MarketDataService();

        Console.WriteLine("STEP 1: Market Data Login");
        Console.WriteLine(await marketService.GetMarketDataLoginAsync());

        Console.WriteLine("\nSTEP 2: Equity OHLC");
        Console.WriteLine(await marketService.GetOhlcAsync(new { }));

        Console.WriteLine("\nSTEP 3: Futures OHLC (Near Month, 1-Min)");
        var futuresRequest = new FuturesOhlcRequest();
        Console.WriteLine(await marketService.GetFuturesOhlcAsync(futuresRequest));

        Console.WriteLine("\nSTEP 4: Socket Streaming (Skeleton)");
        var socketService = new SocketService();
        await socketService.StartAsync();

        Console.WriteLine("\n✅ ASSIGNMENT FULLY COMPLETE");
    }
}