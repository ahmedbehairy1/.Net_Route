using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    public class Ticket
    {
        private static int counter = 0;

        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public int TicketId { get; }


        public Ticket(string moviename, decimal price)
        {
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero");
            MovieName = moviename;
            Price = price;
            counter++;
            TicketId = counter;
        }

        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName}  | price : {Price} EGP | After Tax : {PriceAfterTax} EGP";
        }

        public static int GetTotalTickets()
        {
            return counter;
        }
    }


}
