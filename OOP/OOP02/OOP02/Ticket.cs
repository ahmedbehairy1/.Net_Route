using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    public class Ticket
    {
        private string moviename;
        private TicketType type;
        private Seat seat;
        private double price;
        public double PriceAfterTax => Price * 1.14;
        private static int ticketCounter = 0;

        public int TicketId { get; }


        public string MovieName
        {
            get {  return moviename; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                    moviename = value;
                }
        }

        public TicketType Type 
        {
            get { return type; }
            set { type = value; }
        }

        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        public double Price 
        {
            get { return price; }
            set
            {
                if(value > 0 )
                    price = value;
            }
        }
        // Main constructor
        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
            ticketCounter++;
            TicketId = ticketCounter;
        }

        // Constructor with defaults (calls main constructor)
        public Ticket(string movieName)
        : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        {
        }

        //get total tickets sold
        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
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
