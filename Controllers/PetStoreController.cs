using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CacheDemoForDirectSupply.Services;

namespace CacheDemoForDirectSupply.Controllers
{
    public class PetStoreController :Controller
    {
        private IPetService _service { get; set; }

        public PetStoreController()
        {
            _service = new PetService();
        }

        [HttpGet]
        public async Task<IActionResult> GetStoreInventory()
        {
            var storeInventoryResponse = await _service.GetStoreInventory();
            return Ok(storeInventoryResponse);
        }
    }
}
