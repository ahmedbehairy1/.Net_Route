using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    public class StandardTicket : Ticket 
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string moviename , decimal price , string seat):base(moviename , price)
        {
            SeatNumber = seat;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Seat: {SeatNumber}";
        }
    }
}
