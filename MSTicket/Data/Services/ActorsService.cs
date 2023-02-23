using MTickets.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MSTicket.Data.Services
{
    public class ActorsService : IActorsService

    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var resulat = await _context.Actors.ToListAsync();
            return resulat;
        }

        public Actor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }
    }
}
