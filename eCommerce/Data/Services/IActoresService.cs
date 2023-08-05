using eCommerce.Models;
using System.Threading.Tasks;

namespace eCommerce.Data.Services
{
    public interface IActoresService
    {
        Task<IEnumerable<Actor>> GetallAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Delete(int id);
    }
}
