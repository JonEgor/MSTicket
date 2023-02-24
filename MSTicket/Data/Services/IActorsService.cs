using MTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MSTicket.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);

       Task<Actor> UpdateAsync(int id, Actor newActor); //Обновление данных 

        Task DeleteAsync(int id); //Метод удаления 
    }
}
