using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            //main difference between class and struct is 
            // class is refernce type 
            //struct is value type and lightweight from class can't do inhertance 

            // example on class (person):
            //Person P1 = new Person();
            //P1.Name = "Ali";
            //Person P2 = P1; // copy address
            //P2.Name = "Ahmed";
            //Console.WriteLine(P1.Name); // will print Ahmed because class is refernce type

            //Example on Struct (Student) :
            //Student S1 = new Student();
            //S1.Name = "Ali";
            //Student S2 = S1;
            //S2.Name = "Ahmed";
            //Console.WriteLine(S1.Name); // will print Ali because struct is value type



            #endregion
            #region Q2
            // public : 
            // 1- Accessible from anywhere
            // 2-Can be accessed from other classes
            // 3- Used when we want data or methods to be available outside the class

            // Private : 
            // 1-Accessible only inside the same class
            // 2-Cannot be accessed directly from other classes
            // 3- Used to protect data (Encapsulation)

            // Example on class (person) 
            //Person P1 = new Person();
            //P1.Name = "Test"; //accessable
            //P1.age; // unaccessable

            #endregion
            #region Q3
            //- Create a Class Library

            // Create Class Library project.
            // Write public classes.
            // Build the project.

            //- Use the Class Library

            // Create another project.
            // Add Project Reference to the library.
            // Use the classes with using keyword.
            #endregion
            #region Q4
            //A class library is a reusable collection of classes compiled into a DLL file.
            //We use it to reuse code and organize applications.
            #endregion
            #endregion
            #region Part02 
            // Movie ticket booking system 

            Console.Write("Enter Movie Name: ");
            string movie = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX): ");
            int typeInput = int.Parse(Console.ReadLine());
            TicketType type = (TicketType)typeInput;

            Console.Write("Enter Seat Row (A, B, C...): ");
            char row = char.Parse(Console.ReadLine());

            Console.Write("Enter Seat Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

            Seat seat = new Seat(row, number);
            Ticket ticket = new Ticket(movie, type, seat, price);

            double taxPercent = 14;

            Console.WriteLine();
            ticket.PrintTicket(taxPercent);

            Console.WriteLine();
            Console.WriteLine("===== After Discount =====");
            Console.WriteLine($"Discount Before : {discount:F2}");

            ticket.ApplyDiscount(ref discount);

            Console.WriteLine($"Discount After  : {discount:F2}");
            Console.WriteLine($"Movie   : {ticket.MovieName}");
            Console.WriteLine($"Type    : {ticket.Type}");
            Console.WriteLine($"Seat    : {ticket.Seat}");
            Console.WriteLine($"Price   : {ticket.CalcTotal(0) - 0:F2}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {ticket.CalcTotal(taxPercent):F2}");
            #endregion

        }
    }
}
