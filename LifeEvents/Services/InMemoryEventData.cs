using System.Collections.Generic;
using System.Linq;
using LifeEvents.Models;

namespace LifeEvents.Services
{
    //public class InMemoryEventData : IEventData
    //{
    //    public InMemoryEventData()
    //    {
    //        _event = new List<Event>
    //        {
    //            new Event  {
    //            EventId = 1,
    //            UserId = 1,
    //            SharedId = null,
    //            EventName = "Trip to Jp",
    //            EventDescription = "Amazing Japan",
    //            EventPhoto = "link"
    //            },
    //            new Event  {
    //            EventId = 2,
    //            UserId = 3,
    //            SharedId = null,
    //            EventName = "Family",
    //            EventDescription = "Love my family",
    //            EventPhoto = "link"
    //            },
    //            new Event  {
    //            EventId = 3,
    //            UserId = 3,
    //            SharedId = null,
    //            EventName = "Trip to Arizona",
    //            EventDescription = "So much fun",
    //            EventPhoto = "link"
    //            }
    //        };
    //    }
    //    public IEnumerable<Event> GetAll()
    //    {
    //        return _event.OrderBy(r => r.EventName);    
    //    }

    //    public Event Get(int eventId)
    //    {
    //        return _event.FirstOrDefault(r => r.EventId == eventId);
    //    }

    //    public Event Add(Event newEvent)
    //    {
    //        newEvent.EventId = _event.Max(r => r.EventId) + 1;
    //        _event.Add(newEvent);
    //        return newEvent;
    //    }

    //    List<Event> _event; // inmemeroy list is too much for memory
    //}
}
