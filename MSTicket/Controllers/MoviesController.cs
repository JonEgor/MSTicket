using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MSTicket.Data;
using System.Threading.Tasks;

namespace MSTicket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() //асинхронный метод 
        {
            var allMovies = await _context.Movies.ToListAsync();
            return View(allMovies);
        }
    }
}

