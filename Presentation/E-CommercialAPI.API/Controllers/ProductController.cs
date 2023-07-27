using E_CommercialAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommercialAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductWriteRepository _writeRepo;
        readonly IProductReadRepository _readRepo;

        public ProductController(IProductWriteRepository writeRepo , IProductReadRepository readRepo)
        {
            _writeRepo = writeRepo;
            _readRepo = readRepo;
        }

        [HttpGet("GetProduct")]
        public async void Get()
        {
            await _writeRepo.AddRangeAsync(new()
            {
                new() { Id= Guid.NewGuid(), Name ="Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock=10 },
                new() { Id= Guid.NewGuid(), Name ="Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock=20 },
                new() { Id= Guid.NewGuid(), Name ="Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock=30 },
            });
            await _writeRepo.SaveAsync();
        }
    }
}
