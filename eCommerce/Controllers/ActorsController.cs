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
            var data = await _service.GetallAsync();
            return View(data);
        }
        //crear actores
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("NombreCompleto,FotoPerfilURL, Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = _service.GetByIdAsync(id);
            if (actorDetails == null) return View("empty");
            return View(actorDetails);

        }
    }
}
