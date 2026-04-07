using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Exercise 1: Student Grade Manager
            //Create a program that manages student grades using One Of Collections
            //Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65

            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Print the collection, Count, first and last grade

            //Console.WriteLine("Grades : ");
            //foreach (var grade in grades)
            //{
            //    Console.Write(grade+" ");
            //}

            //Console.WriteLine("\n\nCount: " + grades.Count);
            //Console.WriteLine($"First Grade: {grades.First()}");
            //Console.WriteLine($"Last Grade: {grades.Last()}");

            //Sort the grades ascending, then print

            //grades.Sort();
            //Console.WriteLine("\nsorted Grades :");
            //foreach (var grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Get the first grade above 90

            //int above90 = grades.FirstOrDefault(X => X > 90);
            //Console.WriteLine("\n\nfirst grade above 90 : " + above90);

            //Get all grades below 75(failing grades)

            //var below75 = grades.Where(x => x < 75);
            //Console.WriteLine("Failing Grades (<75):");
            //foreach (var x in below75)
            //{
            //    Console.Write(x + " ");
            //}

            //Remove all failing grades(below 75)

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("\nAfter Removing Failing Grades:");
            //foreach (var grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Check if any grade equals 100

            //bool equals100 = grades.Contains(100);
            //Console.WriteLine("\n\nequals 100? " + equals100);


            //Create a List<string> where each grade becomes "Grade: X"

            //List<string> gradesString = grades.Select(x => "Grade " + x).ToList();
            //Console.WriteLine("\nFormatted Grades:");
            //foreach (var s in gradesString)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion
            #region Q2
            //Exercise 2: Leaderboard
            //Create a leaderboard that automatically sorts players by score.
            //Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"

            //SortedList<int, string> leaderboard = new SortedList<int, string>()
            //{
            //    {500 , "Ahmed" },
            //    {200 , "Sara" },
            //    {800 , "Ali" },
            //    {350 , "Mona" }
            //};

            //Print all entries(they should be sorted by score automatically)

            //Console.WriteLine("Leaderboard : ");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}

            //Access the first key and first value

            //Console.WriteLine("\nFirst Score: " + leaderboard.Keys[0]);
            //Console.WriteLine("First Player: " + leaderboard.Values[0]);

            //Check if score 500 exists

            //Console.WriteLine("\n Contains Score 500" + leaderboard.ContainsKey(500));

            //Safely get the player with score 999

            //if (leaderboard.TryGetValue(999, out string player))
            //{
            //    Console.WriteLine("Player with score 999: " + player);
            //}
            //else
            //{
            //    Console.WriteLine("Score 999 not found");
            //}

            //Remove the player with score 200 and print the updated list

            //leaderboard.Remove(200);
            //Console.WriteLine("\nAfter removing score 200:");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}
            #endregion
            #region Q3
            //Exercise 3: Phone Book
            //Build a phone book application.
            //Create a Collection with 4 contacts(name → phone number)

            //Dictionary<string, string> phonebook = new Dictionary<string, string>()
            //{
            //    { "Ahmed", "01012345678" },
            //    { "Sara", "01198765432" },
            //    { "Ali", "01234567890" },
            //    { "Mona", "01511223344" }
            //};

            //Add a new contact using [] syntax (add or update)

            //phonebook["omar"] = "01000000005"; //Add
            //phonebook["Ahmed"] = "01114166745"; //Update

            //Try adding a duplicate using .Add() — catch the exception and print the error

            //try
            //{
            //    phonebook.Add("Sara", "012355141414");

            //}
            //catch (Exception ex)

            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //Try adding a duplicate using .TryAdd() — print whether it succeeded

            //bool added = phonebook.TryAdd("Ali", "11111111111");
            //Console.WriteLine("TryAdd success? " + added);


            //Search for a contact that doesn’t exist

            //if (phonebook.ContainsKey("Youssef"))
            //{
            //    Console.WriteLine("Found Youssef");
            //}
            //else
            //{
            //    Console.WriteLine("Youssef not found");
            //}

            //Get a contact with a fallback of "Not Found"

            //string result;
            //if (phonebook.TryGetValue("Youssef", out result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}


            //Print all Keys on one line, then all Values on another line
            //keys

            //Console.WriteLine("\nNames:");
            //foreach (var name in phonebook.Keys)
            //{
            //    Console.Write(name + " ");
            //}

            //values

            //Console.WriteLine("\nPhone Numbers:");
            //foreach (var number in phonebook.Values)
            //{
            //    Console.Write(number + " ");
            //}

            #endregion
            #region Q4
            //Exercise 4: Unique Email Validator
            //Use Collection to manage unique email addresses.
            //Create a HashSet<string> with a case -insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"

            //    HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //Print Count — how many are actually stored? Explain why.

            //Console.WriteLine("Email Count: " + emails.Count);

            //Console.WriteLine("Stored Emails:");
            //foreach (var email in emails)
            //{
            //    Console.WriteLine(email);
            //}

            //Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };


            //Print the result of: UnionWith, IntersectWith, ExceptWith
            //union
            //HashSet<int> union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine("\nUnion:");
            //foreach (var n in union)
            //{
            //    Console.Write(n + " ");
            //}

            // INTERSECTION
            //HashSet<int> intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);
            //Console.WriteLine("\nIntersection:");
            //foreach (var n in intersect)
            //{
            //    Console.Write(n + " ");
            //}

            // EXCEPT
            //HashSet<int> except = new HashSet<int>(setA);
            //except.ExceptWith(setB);
            //Console.WriteLine("\nExcept (A - B):");
            //foreach (var n in except)
            //{
            //    Console.Write(n + " ");
            //}

            //Use IsSubsetOf to check if { 1,2} is a subset of Set A

            //HashSet<int> subset = new HashSet<int> { 1, 2 };
            //Console.WriteLine("\n\nIs {1,2} subset of A? " + subset.IsSubsetOf(setA));

            #endregion
            #region Q5
            //Exercise 5: Print Queue Simulator
            //Simulate a printer queue
            //Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf", "Letter.docx", "Resume.pdf", "Photo.jpg"

            //Queue<string> printerQueue = new Queue<string>();

            //printerQueue.Enqueue("Report.pdf");
            //printerQueue.Enqueue("Invoice.pdf");
            //printerQueue.Enqueue("Letter.docx");
            //printerQueue.Enqueue("Resume.pdf");
            //printerQueue.Enqueue("Photo.jpg");


            //Print the queue contents and Count

            //Console.WriteLine("Queue:");
            //foreach (var doc in printerQueue)
            //{
            //    Console.Write(doc + " ");
            //}
            //Console.WriteLine("\nCount: " + printerQueue.Count);

            //Use Peek to see which document will print next(without removing)

            //Console.WriteLine("\nNext to print: " + printerQueue.Peek());


            //Process the queue: Dequeue each document and print "Printing: [name]"

            //Console.WriteLine("\nPrinting...");
            //while (printerQueue.Count > 0)
            //{
            //    string doc = printerQueue.Dequeue();
            //    Console.WriteLine("Printing: " + doc);
            //}

            //Try TryDequeue on the now - empty queue — what happens?

            //bool success = printerQueue.TryDequeue(out string result);
            //Console.WriteLine("\nTryDequeue success? " + success);
            //Console.WriteLine("Result: " + (result ?? "null"));


            #endregion
            #region Q6
            //Exercise 6: Browser History(Undo)
            //Simulate browser back / forward
            //Create a Stack<string> for browser history
            //Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com", "claude.ai"

            //Stack<string> history = new Stack<string>();

            //history.Push("google.com");
            //history.Push("github.com");
            //history.Push("stackoverflow.com");
            //history.Push("youtube.com");
            //history.Push("claude.ai");


            //Use Peek to see the current page(top of stack)

            //Console.WriteLine("Current Page: " + history.Peek());


            //Press "back" 3 times using Pop — print each page you leave

            //Console.WriteLine("\nGoing Back:");
            //for (int i = 0; i < 3; i++)
            //{
            //    string leftPage = history.Pop();
            //    Console.WriteLine("Leaving: " + leftPage);
            //}


            //Print the current page after going back

            //Console.WriteLine("\nCurrent Page Now: " + history.Peek());

            //Try TryPop on an empty stack — what happens?

            //  Empty the stack
            //while (history.Count > 0)
            //{
            //    history.Pop();
            //}

            //  TryPop on empty stack
            //bool success = history.TryPop(out string result);
            //Console.WriteLine("\nTryPop success? " + success);
            //Console.WriteLine("Result: " + (result ?? "null"));

            #endregion



        }

    }
}