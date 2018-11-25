using LifeEvents.Models;
using LifeEvents.Services;
using Microsoft.AspNetCore.Mvc;

namespace LifeEvents.Controllers
{
    public class HomeController : Controller
    {
        private IEventData _eventData;
        private IGreeter _greeter;

        public HomeController(IEventData eventData, IGreeter greeter)
        {
            _eventData = eventData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Events = _eventData.GetAll();
            model.CurrentMessage = _greeter.GetMessage();
            return View(model);  
        }

        public IActionResult Details(int id)
        {
            var model = _eventData.Get(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EventEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newEvent = new Event();
                newEvent.EventName = model.EventName;
                newEvent.EventType = model.EventType;
                newEvent = _eventData.Add(newEvent);
                return RedirectToAction(nameof(Details), new { id = newEvent.EventId });
            }
            else
            {
                return View();
            }
        }
    } 
}
