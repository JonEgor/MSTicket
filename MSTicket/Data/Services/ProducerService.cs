using MSTicket.Data.Base;
using MTickets.Models;

namespace MSTicket.Data.Services
{
    public class ProducerService: EntityBaseRepository<Producer>,IProducersServices

    {
        public ProducerService(AppDbContext context): base(context)
        {

        }
    }
}
