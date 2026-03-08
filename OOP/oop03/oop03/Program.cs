using System.Security.AccessControl;
using System.Security.Principal;

namespace oop03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: Identify the type of relationship in each scenario below
            //(Inheritance, Association, Aggregation, Composition, or Dependency):

            //a) A University has Departments. If the university is closed, the departments no longer exist.
            //Answer : Composition

            //b) A Driver uses a Car. The driver does not own the car.
            //Answer : Association

            //c) A Dog is an Animal.
            //Answer : Inheritance

            //d) A Team has Players. If the team is deleted, the players still exist.
            //Answer : Aggregation

            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //Answer : Dependency



            #endregion
            #region Q2
            //Q2 : Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field. Can a child class in a different assembly access it?What about through an object instance from outside?
            //Answer : child can access it in same assembly only , can't be accessed from outside through an object instance 


            //b) What is the difference between protected internal and private protected?
            //protected internal

            //Accessible if either condition is true:
            //The code is in the same assembly, OR
            //The code is in a derived(child) class.

            //private protected

            //Accessible only if both conditions are true:
            //The code is in the same assembly
            //The code is in a derived class


            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?

            //Sealed class:
            //A class marked sealed cannot be inherited(no other class can derive from it).

            //Sealed method:
            //A method marked sealed cannot be overridden in further derived classes(it must already be overriding a base method).


            //d) Can you create an object from a sealed class using new? Why or why not?

            //Yes, you can create an object from a sealed class using new in C#.

            //Why?
            //Because sealed only prevents inheritance(no other class can extend it).
            //It does not prevent object creation, so you can still instantiate it normally.
            #endregion

            Cinema cinema = new Cinema("My Cinema");
            cinema.OpenCinema();
            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintAllTickets();

            cinema.CloseCinema();
        }
    }
}
