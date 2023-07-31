using eCommerce.Data;
using eCommerce.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActoresService _service;

        public ActorsController(IActoresService service)
        {
               _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.Getall();
            return View(data);
        }
        //crear actores
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
