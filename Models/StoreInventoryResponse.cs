using System.Text.Json.Serialization;

namespace CacheDemoForDirectSupply.Models
{
    public class StoreInventoryResponse
    {
        public int AvailablQQe { get; set; }
        public int Sold { get; set; }
        public int Deceased { get; set; }

        [JsonPropertyName("string")]
        public int String { get; set; }
        public int Pending { get; set; }
        public int Available { get; set; }
        public int Availablej { get; set; }
    }
}