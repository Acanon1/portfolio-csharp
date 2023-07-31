using eCommerce.Models;

namespace eCommerce.Data.Services
{
    public interface IActoresService
    {
        Task<IEnumerable<Actor>> Getall();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
