using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options) 
        {
            
        }
    }
}
