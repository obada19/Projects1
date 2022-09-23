using System.Linq;
using assignment_3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using assignment_3.Models;

namespace assignment_3.Controllers
{
    public class GuestbookController : Controller
    {
        private readonly ILogger<GuestbookController> _logger;
        private readonly ApplicationDbContext _db;

        public GuestbookController(ILogger<GuestbookController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            _logger.LogDebug("GET guestbook/Index");

            // The view expects a list of authors, so fetch that from the database
            return View(_db.Guests.ToList());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Guests());
        }

        [HttpPost]
        public IActionResult Add(Guestbook Guests)
        {
            _logger.LogDebug("POST Guests/Index");

            // You can check if the model requirements have been fulfilled using ModelState
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Received invalid model");

                // If the state is invalid just display the view again, with the partially filled model
                return View(Guests);
            }

            // Model is valid, add it to the database
            _db.Guestbook.Add(Guests);
            _db.SaveChanges();

            // Redirect back to the Index view which will show the current list of authors
            return RedirectToAction(nameof(Index));
        }
    }
}