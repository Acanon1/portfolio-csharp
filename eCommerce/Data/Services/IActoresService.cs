using eCommerce.Models;

namespace eCommerce.Data.Services
{
    public interface IActoresService
    {
        Task<IEnumerable<Actor>> GetallAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
