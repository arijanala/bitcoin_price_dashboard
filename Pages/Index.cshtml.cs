using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace BitcoinPriceDashboard.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var json = CoinBaseClient.GetJSON().Result;
            var bitcoinModel =  JsonSerializer.Deserialize<JSONModel>(json);
            ViewData["BitcoinPrice"] = bitcoinModel;
        }
    }
}
