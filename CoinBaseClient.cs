using System.Net.Http;
using System.Threading.Tasks;

namespace BitcoinPriceDashboard
{
    public static class CoinBaseClient
    {
        public static async Task<string> GetJSON()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://api.coinbase.com/v2/prices/spot?currency=EUR");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
