using System;
using System.IO;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1) Public Fields (Owner & Balance) ,Anyone can directly modify them
            //2) Withdraw Method Has No Validation

            //How to Fix It (Encapsulation):
            //Make fields private
            //Use properties to control access
            //Add validation inside methods

            //Example idea
            //private string owner;
            //private double balance;

            //public string Owner { get; set; }

            //public double Balance
            //{
            //    get { return balance; }
            //    private set { balance = value; }
            //}

            //Why Public Fields Are Bad in OOP

            //Exposing fields directly is bad because:


            //Breaks encapsulation
            //No data protection
            //No validation
            //Harder to maintain and change later
            //Other classes become tightly coupled

            #endregion
            #region Q2
            //A field stores data directly, while a property provides controlled access to that data using get and set.
            //Yes, a property can contain logic such as validation or calculations.
            //A read-only property can return a calculated value like Area = Width × Height.

            //Rectangle r = new Rectangle() { lenght = 5 , Width = 4 };
            //Console.WriteLine(r.area);
            #endregion
            #region Q3
            //a) this[int index] is an indexer. It allows objects to be accessed like arrays.
            //b) Writing register[10] causes IndexOutOfRangeException. We can prevent it by adding index validation.
            //c) Yes, a class can overload indexers.For example, accessing data by index or by key (like name or ID).
            #endregion
            #region Q4
            //a) What does the static keyword mean on TotalOrders? How is it different from the Item field?
            //The static keyword means that TotalOrders belongs to the class itself rather than to a specific object.
            //TotalOrders(Static): There is only one copy shared by all instances of the class. If one Order object changes it, it changes for everyone.This is why it works as a counter for all orders.
            //Item(Instance): This is unique to each object. Every time you create a new Order, that specific object gets its own separate Item name.

            //b) Can a static method inside Order access the Item field directly? Why or why not?
            //No. A static method cannot access the Item field directly.

            //Why: A static method exists at the class level and can be called without creating an object.
            //The Item field, however, only exists once an object is instantiated.
            //Because the static method doesn't belong to a specific instance (it has no this context), it doesn't know which Order's item it should be looking at.


            #endregion
            #region Q5
            // read 3 tickets
            Console.WriteLine("===============Ticket Booking============");
            Cinema cinema = new Cinema();
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine($"enter data for ticket{i+1}");

                Console.Write("Movie Name :  ");
                string movie = Console.ReadLine();

                Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                TicketType type = (TicketType)int.Parse(Console.ReadLine());

                Console.Write("Seat Row (A-Z): ");
                char row = char.Parse(Console.ReadLine());

                Console.Write("Seat Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Price :  ");
                double price = double.Parse(Console.ReadLine());

                Seat seat = new Seat(row , number);
                Ticket ticket = new Ticket(movie, type, seat, price);

                cinema.AddTicket(ticket);
            }

            //print 3 tickets 
            Console.WriteLine("========================All Tickets ======================");
            for (int i = 0; i < 3; i++)
            {
                Ticket t = cinema[i];

                if(t != null)
                {
                    Console.WriteLine($"\nTicket ID: {t.TicketId}");
                    Console.WriteLine($"Movie: {t.MovieName}");
                    Console.WriteLine($"Type: {t.Type}");
                    Console.WriteLine($"Seat: {t.Seat}");
                    Console.WriteLine($"Price: {t.Price:F2}");
                    Console.WriteLine($"Price After Tax: {t.PriceAfterTax:F2}");
                }
            }

            //search movie by name
            Console.Write("\nEnter movie name to search: ");
            string searchName = Console.ReadLine();

            Ticket found = cinema .GetMovieByName ( searchName );
            if (found != null)
            {
                Console.WriteLine("Movie Found:");
                Console.WriteLine($"Ticket ID: {found.TicketId}");
                Console.WriteLine($"Seat: {found.Seat}");
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }

            Console.WriteLine("=====================statistics=====================");
            //ptint all tickets sold 
            Console.WriteLine($"total tickets sold : {Ticket.GetTotalTicketsSold()}");

            // Generate 2 booking references
            Console.WriteLine("\nBooking References:");
            Console.WriteLine(BookingHelper.GenerateBookingReference());
            Console.WriteLine(BookingHelper.GenerateBookingReference());

            // Group discount calculation
            double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"\nGroup Discount Total (5 tickets × 80 EGP): {groupTotal:F2}");

            #endregion
        }
    }
}
