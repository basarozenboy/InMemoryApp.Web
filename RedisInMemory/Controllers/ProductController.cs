using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace RedisInMemory.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMemoryCache memoryCache;

        public ProductController(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
