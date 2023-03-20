using MSTicket.Data.Base;
using MTickets.Models;

namespace MSTicket.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService

    {
        public CinemasService(AppDbContext context): base(context)
        {

        }
    }
}
