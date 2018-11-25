using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeEvents.Data; 
using LifeEvents.Models;

namespace LifeEvents.Services
{
    public class SqlEventData : IEventData
    {
        private LifeEventDbContext _context;

        public SqlEventData(LifeEventDbContext context)
        {
            _context = context;
        }
        public Event Add(Event newEvent)
        {
            _context.Events.Add(newEvent);
            // TODO you can move this out to another method like submit to batch multiple transaction at once.
            _context.SaveChanges();
            return newEvent;
        }

        public Event Get(int eventId)
        {
            return _context.Events.FirstOrDefault(r => r.EventId == eventId);
        }

        // TODO change to IQURIABLE FOR BIG DATA
        public IEnumerable<Event> GetAll()
        {
            return _context.Events.OrderBy(r => r.EventName);
        }

        public Event Update(Event newEvent)
        {
            _context.Attach(newEvent).State =
                Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return newEvent;

        }
    }
}
