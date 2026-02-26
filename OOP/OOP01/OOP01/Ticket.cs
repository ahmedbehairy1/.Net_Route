using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    public class Ticket
    {
        public string MovieName;
        public TicketType Type;
        public Seat Seat;
        private double Price;


        // Main constructor
        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        // Constructor with defaults (calls main constructor)
        public Ticket(string movieName)
        : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        {
        }

        
        // Calculate total after tax (Price unchanged)
        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }

        // Apply discount
        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

        // Print ticket info
        public void PrintTicket(double taxPercent)
        {
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie   : {MovieName}");
            Console.WriteLine($"Type    : {Type}");
            Console.WriteLine($"Seat    : {Seat}");
            Console.WriteLine($"Price   : {Price:F2}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent):F2}");
        }
    }
}
