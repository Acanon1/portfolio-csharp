

using eCommerce.Data.Base;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data.Services
{
    public class ActoresService : EntityBaseRepository<Actor>, IActoresService
    {
        public ActoresService(AppDbContext context) : base(context) { }
    }
}
