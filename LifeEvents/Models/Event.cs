using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LifeEvents.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public int? SharedId { get; set; }
        [Display(Name ="Event Name")]
        [Required, MaxLength(80)]
        public string EventName { get; set; }
        public string EventPhoto { get; set; }
        public string EventDescription { get; set; }    
        public EventType EventType { get; set; }
    }
}
