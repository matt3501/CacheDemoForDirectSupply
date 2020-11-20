using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CacheDemoForDirectSupply.Models;
using Newtonsoft.Json;

namespace CacheDemoForDirectSupply.Services
{
    class PetService : IPetService
    {
        private static readonly HttpClient Client = new HttpClient();

        public async Task<StoreInventoryResponse> GetStoreInventory()
        {
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            Client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var endpoint = "store/inventory";
            var response = await GetPetStoreResponse<StoreInventoryResponse>(endpoint);

            return response;
        }

        private static async Task<T> GetPetStoreResponse<T>(string endpoint)
        {
            var stringTask = Client.GetStringAsync("https://petstore.swagger.io/v2/" + endpoint);

            var json = await stringTask;

            var response = JsonConvert.DeserializeObject<T>(json);
            return response;
        }
    }
}