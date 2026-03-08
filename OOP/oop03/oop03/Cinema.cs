using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    public class Cinema
    {
        public string CinemaName { get; set; }
        private Ticket[] tickets = new Ticket[20];
        private Projector projector = new Projector();

        public Cinema(string name)
        {
            CinemaName = name;
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========= All Tickets =========");
            foreach (var t in tickets)
            {
                if (t != null)
                    Console.WriteLine(t);
            }

            Console.WriteLine("\n========= Statistics =========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
        }


        public void OpenCinema()
        {
            Console.WriteLine("========= Cinema Opened =========");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n========= Cinema Closed =========");
            projector.Stop();
        }
    }
}
