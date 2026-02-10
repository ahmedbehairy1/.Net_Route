using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_02_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1: What will this print and explain what happens ?

            //double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x);

            //answer:

            //    it will print 9 
            //    variable d is assigned by value 9.99,
            //    then we make explicit type casting from double to int 
            //    so the value will be 9
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q2: This code doesn’t compile. Fix it with the smallest change?
            //int n = 5;
            //double d2 = n / 2;
            //Console.WriteLine(d2);

            //Answer:

            //divide int / int -> int
            //double n = 5;
            //double d2 = n / 2;
            //Console.WriteLine(d2);
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q3: You read a number from user input ..Write the correct line to
            //    get age as int.

            // Answer:

            //Console.WriteLine("Enter your age ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("your age is :"+ age);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q4: What happens here and why ?

            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);

            //Answer :

            //trying to convert string "12a" to int this will not happen because it contains letter "a"
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q5: Complete the code from the previous question so it prints
            //    Invalid if conversion into int fails, otherwise prints the number
            //string s = "12";

            //if (int.TryParse(s, out _))
            //{
            //    Console.WriteLine(s);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q6: What will this print and explain why ?
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1);
            // Answer : 
            // will print 11 as 10 is stored as object then cast back to int and 1 is added
            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q7: What will this print and explain why and if there is a
            //    problem handle it ?
            //object o = 10;
            //long x = (long)o;
            //Console.WriteLine(x);

            // Answer : 

            //This throws an InvalidCastException because you cannot unbox an int directly to long.
            //To fix it, either unbox to int first or use Convert.ToInt64.
            //object o = 10;
            //long x = Convert.ToInt64(o);
            //Console.WriteLine(x);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q8: Fix this to avoid exceptions and print - 1 if conversion isn’t
            //   possible?
            //object o = 10;
            //long x = o;
            //Console.WriteLine(x);  

            //Answer :

            //object o = 10;
            //long x;
            //try
            //{
            //    x = Convert.ToInt64(o);
            //}
            //catch
            //{
            //    x = -1;
            //}
            //Console.WriteLine(x);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Q9: What will this print and explain why ?

            //string? name = null;
            //Console.WriteLine(name?.Length);
            // Answer 
            //Prints nothing because name is null, and?.safely returns null instead of throwing an error.
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q10: What will this print and explain the process ?

            //string ? name2 = null;
            //int length = name2?.Length ?? 0;

            // Answer 

            //Prints 0 because name2 is null; ?. returns null safely, and ?? 0 replaces null with 0.
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q11: What’s wrong with this “safe” code and how can we solve it?

            //string? s = null;
            //int x = int.Parse(s ?? "0");
            //Console.WriteLine(x);

            // Answer

            //string? s = null;
            //int.TryParse(s, out int x);
            //Console.WriteLine(x);

            //TryParse does not throw an exception, just returns false if conversion fails.

            // Assign 0 if parsing fails → safe.
            /////////////////////////////////////////////////////////////////////////////////////////
            //Q12: What happens here and if there is a problem, handle it

            //string? s = null;
            //Console.WriteLine(s!.Length);

            // Answer

            //string? s = null;
            //Console.WriteLine(s?.Length ?? 0);
            // prints 0 if s is null
            //Using s! ignores null, but since s is actually null, it throws a NullReferenceException.
            //To fix it, use s?.Length or s?.Length ?? 0.
            ////////////////////////////////////////////////////////////////////////////////////////////
            ///
            //Q13: What will this print?
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);

            // Answer

            //Convert.ToInt32 is different from int.Parse.
            //If the input is null, it does not throw an exception.
            //Instead, it returns 0.
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ///
            //Q14: Compare results and explain each result :

            //string? s = null;
            // A
            // int a = int.Parse(s);
            // B
            //int b = Convert.ToInt32(s);
            //Console.WriteLine(b);

            // Answer

            //A: int a = int.Parse(s);
            //s is null
            //int.Parse cannot parse null
            //Throws: FormatException
            //Program crashes at this line
            //Nothing is printed

            //B: int b = Convert.ToInt32(s);
            //s is null
            //Convert.ToInt32 treats null as 0
            //b is assigned 0
            //Console.WriteLine(b) prints:0
            //////////////////////////////////////////////////////////////////////////////////////////////////
            
            //Q15: Complete the line to print "Guest" when user is null,
            //     otherwise print the user name in uppercase:

            //  string? user = null;
            // Answer

            //string? user = null;
            //Console.WriteLine(user?.ToUpper() ?? "Guest");


        }
    }
}
