using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MSTicket.Data;
using System.Linq;
using System.Threading.Tasks;
using MSTicket.Data.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MSTicket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index() //асинхронный метод 
        {
            var allMovies = await _service.GetAllAsync(n =>n.Cinema);
            return View(allMovies);
        }

        //GET: Movies/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieByIdAsync(id);
            return View(movieDetail);
        }
        //Get : Movies/Create
        public async Task<IActionResult> Create()
        {
            var movieDropdownsData = await _service.GetNewMovieDropdownsValues();
            
            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

            return View();
        }
    }

}

