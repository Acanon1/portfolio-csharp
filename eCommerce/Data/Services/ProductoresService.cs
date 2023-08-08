using eCommerce.Data.Base;
using eCommerce.Models;

namespace eCommerce.Data.Services
{
	public class ProductoresService: EntityBaseRepository<Productor>, IProductoresService
	{
        public ProductoresService(AppDbContext context) : base(context)
        {
            
        }
    }
}
