using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Registration
    {
        //attende + event m : m

        public int AttendeeId { get ; set; }
        public Attendee Attendee { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public string? Note { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
