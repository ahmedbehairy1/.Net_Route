using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee = 50;

        public VIPTicket(string moviename, decimal price, bool lounge) : base(moviename, price)
        {
            LoungeAccess = lounge;

        }

        public override string ToString()
        {
            decimal total = PriceAfterTax + ServiceFee;
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {total:F2} EGP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }
    }
}
