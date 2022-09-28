namespace BitcoinPriceDashboard
{
    public class JSONModel
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public string @base { get; set; }
        public string currency { get; set; }
        public string amount { get; set; }
    }
}
