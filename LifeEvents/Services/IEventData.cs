using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeEvents.Models;

namespace LifeEvents.Services
{
    public interface IEventData
    {
        IEnumerable<Event>GetAll();
        Event Get(int eventId);
        Event Add(Event newEvent);
        Event Update(Event newEvent);
    }
}
