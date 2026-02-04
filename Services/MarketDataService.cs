using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XtsClient.Models;

namespace XtsClient.Services
{
    public class MarketDataService
    {
        private readonly HttpClient _httpClient;

        public MarketDataService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://dummy-xts-url.com");
        }
        public async Task<string> GetMarketDataLoginAsync()
        {
            await Task.Delay(100);
            return "Market Data Login Successful";
        }
        public async Task<string> GetOhlcAsync(object request)
        {
            await Task.Delay(100);
            return "Equity OHLC fetched successfully";
        }
        public async Task<string> GetFuturesOhlcAsync(FuturesOhlcRequest request)
        {
            try
            {
                await Task.Delay(200);

                return
                    $"Futures OHLC READY | Symbol={request.Symbol} | Expiry={request.Expiry} | Interval={request.Interval}";
            }
            catch (Exception ex)
            {
                return $"Handled Exception (Expected): {ex.Message}";
            }
        }
        private async Task<string> PostAsync(string url, object payload)
        {
            try
            {
                var json = JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await _httpClient.PostAsync(url, content);
                return await res.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Handled Exception (Expected): {ex.Message}";
            }
        }
    }
}