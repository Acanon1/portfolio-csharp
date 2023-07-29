using eCommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Controllers
{
    public class ProductoresController : Controller
    {
        private readonly AppDbContext _context;

        public ProductoresController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProductores =await _context.Productors.ToListAsync();
            return View();
        }
    }
}
