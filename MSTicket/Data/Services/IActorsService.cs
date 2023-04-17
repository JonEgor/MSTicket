using MTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MSTicket.Data.Base;

namespace MSTicket.Data.Services
{
    public interface IActorsService:IEntityBaseRepository<Actor> // импортирует пространство имен, а пространство имен является базой данных.
                                                                 // Сущность в этом случае является векторным классом.
    {
   
    }
}
