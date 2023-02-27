using MTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MSTicket.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);

        Task<T> UpdateAsync(int id, T newActor); //Обновление данных 

        Task DeleteAsync(int id); //Метод удаления 
    }
}
