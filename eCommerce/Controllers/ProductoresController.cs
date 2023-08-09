using eCommerce.Data;
using eCommerce.Data.Services;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Controllers
{
    public class ProductoresController : Controller
    {
        private readonly IProductoresService _service;

        public ProductoresController(IProductoresService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProductores =await _service.GetallAsync();
            return View(allProductores);
        }

        //get productores detalles
        public async Task<ActionResult> Details(int id)
        {
            var productoresDetails = await _service.GetByIdAsync(id);
            if (productoresDetails == null) return View("NotFound");
            return View(productoresDetails);
        }
        //get productores creae
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create([Bind("FotoPerfilURL,NombreCompleto,Bio")]Productor productor)
        {
            if (!ModelState.IsValid) return View(productor);

            await _service.AddAsync(productor);
            return RedirectToAction(nameof(Index));
        }
		//get productores edit
		public async Task<IActionResult> Edit(int id)
		{
            var productorDetails = await _service.GetByIdAsync(id);
            if (productorDetails == null) return View("NotFound");
			return View(productorDetails);
		}
		[HttpPost]
		public async Task<ActionResult> Edit(int id, [Bind("Id,FotoPerfilURL,NombreCompleto,Bio")] Productor productor)
		{
			if (!ModelState.IsValid) return View(productor);

            if (id == productor.Id)
            {
				await _service.UpdateAsync(id, productor);
				return RedirectToAction(nameof(Index));
			}
			return View(productor);
			
		}


	}
}
