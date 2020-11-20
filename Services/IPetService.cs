using System.Threading.Tasks;
using CacheDemoForDirectSupply.Models;

namespace CacheDemoForDirectSupply.Services
{
    public interface IPetService
    {
        Task<StoreInventoryResponse> GetStoreInventory();
    }
}