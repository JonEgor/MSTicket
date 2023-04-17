using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MSTicket.Data;
using MSTicket.Data.Services;
using MTickets.Models;

namespace MSTicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersServices _services;

        public ProducersController(IProducersServices services)
        {
            _services = services;
        }


        public async Task<IActionResult> Index()
        {
            var allProducers = await _services.GetAllAsync();
            return View(allProducers);
        }

        //GET: producers/details/1
        public async Task<IActionResult> Details(int id) //Aсинхронный метод ID.
        {
            var producerDetails = await _services.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        //GET: producer/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            await _services.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //GET: producer/edit/1
        public async Task <IActionResult> Edit(int id)
        {
            var producerDetails = await _services.GetByIdAsync(id); // = null - Not found 
            if (producerDetails == null) return View("NotFound");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer); //состояние модели недопустимо  вернем Producer в представление.

            if (id == producer.Id)
            {
                await _services.UpdateAsync(id, producer); // метод изменения 
                return RedirectToAction(nameof(Index));
            }

            return View(producer);

        }
        //GET: producer/delete/1
        public async Task<IActionResult> Delete(int id) // Запрос на получение 
        {
            var producerDetails = await _services.GetByIdAsync(id); // = null - Not found 
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id) // Проверка на существование Producer
        {
            var producerDetails = await _services.GetByIdAsync(id); // = null - Not found 
            if (producerDetails == null) return View("NotFound");

            await _services.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
