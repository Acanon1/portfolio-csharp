using eCommerce.Data;
using eCommerce.Data.Services;
using eCommerce.Models;
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
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nombre completo, foto de perfil, Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
