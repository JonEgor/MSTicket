using MTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MSTicket.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);

        void Add(Actor actor); // метод добавления данных 
        Actor Update(int id, Actor newActor); //Обновление данных 

        void Delete(int id); //Метод удаления 
    }
}
