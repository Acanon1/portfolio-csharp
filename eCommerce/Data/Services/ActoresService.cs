

using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data.Services
{
    public class ActoresService : IActoresService
    {
        private readonly AppDbContext _context;
        public ActoresService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetallAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }
            
        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }   

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
