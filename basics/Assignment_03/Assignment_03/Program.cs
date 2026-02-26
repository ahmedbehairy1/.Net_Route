using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 01 : A junior developer wrote this code to build a
            //comma - separated list of 5,000 product IDs:

            //String productlist = "";
            //for (int i = 0; i <= 5000; i++)
            //{
            //    productlist += "prod-" + i + ",";
            //}



            //Tasks:
            //    (a)Explain why this code is inefficient.Reference what happens in
            //         memory.
            //ANS:
            //string is immutable ,
            //What happens in memory:

            //A new string object is created

            //Old content is copied

            //New text is added

            //Old string is discarded



            //    (b) Rewrite this code using StringBuilder to be more efficient.
            //ANS:
            // StringBuilder productlist = new StringBuilder();
            //for (int i = 0; i < 5000; i++)
            //{
            //    productlist.Append("prod-")
            //        .Append(i)
            //        .Append(",");
            //}
            //string result = productlist.ToString();





            //    (c) Add timing code(using Stopwatch) to both versions and report
            //         the time difference.
            //AMS:
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();

            //string productList1 = "";

            //for (int i = 0; i <= 5000; i++)
            //{
            //    productList1 += "prod-" + i + ",";
            //}

            //sw1.Stop();

            /////////////////////////////////////////
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();

            //StringBuilder productList2 = new StringBuilder();

            //for (int i = 0; i <= 5000; i++)
            //{
            //    productList2.Append("prod-")
            //                .Append(i)
            //                .Append(",");
            //}

            //string result = productList2.ToString();

            //sw2.Stop();

            //Console.WriteLine("Time using string: " + sw1.ElapsedMilliseconds + " ms");
            //Console.WriteLine("Time using StringBuilder: " + sw2.ElapsedMilliseconds + " ms");

            //Console.WriteLine("Difference: " +
            //    (sw1.ElapsedMilliseconds - sw2.ElapsedMilliseconds) + " ms");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Question 02: Ticket Pricing System
            //Write a program for a cinema ticket pricing system with these rules:

            //int age;
            //int day;
            //string studentInput;
            //bool isStudent;

            //double basePrice = 0;
            //double weekendCharge = 0;
            //double discount = 0;
            //double finalPrice = 0;

            //// Input Section
            //Console.WriteLine("enter your age ");
            //age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter day of week (1-7, 6=Fri, 7=Sat): ");
            //day = int.Parse(Console.ReadLine());

            //Console.WriteLine("do you have student ID ? (yes/no): ");
            //studentInput = Console.ReadLine().ToLower();

            //if (studentInput == "yes")
            //{
            //    isStudent = true;
            //}
            //else
            //{
            //        isStudent = false;
            //}
            ////base price
            //if (age<5)
            //{
            //    basePrice = 0; 
            //}
            //else if (age>= 5 && age<=12) 
            //{
            //    basePrice = 30;
            //}
            //else if (age>= 13 && age<=59)
            //{
            //    basePrice = 50;
            //}
            //else
            //{
            //    basePrice = 25;
            //}
            ////Weekend Charge
            //if (day == 6 || day == 7)
            //{
            //    if (basePrice > 0)   
            //    {
            //        weekendCharge = 10;
            //    }
            //}
            //// Student Discount
            //double priceAfterWeekend = basePrice + weekendCharge;

            //if (isStudent && priceAfterWeekend > 0)
            //{
            //    discount = priceAfterWeekend * 0.20;
            //}

            //// Final Price
            //finalPrice = priceAfterWeekend - discount;

            //Console.WriteLine("\n----- Ticket Price Breakdown -----");

            //Console.WriteLine("Base price (age): " + basePrice + " EGP");

            //if (weekendCharge > 0)
            //    Console.WriteLine("Weekend surcharge: +10 EGP");
            //else
            //    Console.WriteLine("Weekend surcharge: +0 EGP");

            //if (discount > 0)
            //    Console.WriteLine("Student discount (20%): -" + discount + " EGP");
            //else
            //    Console.WriteLine("Student discount: -0 EGP");

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Final price: " + finalPrice + " EGP");

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            //Question 03: Convert the following if-else chain to:
            //        (a)A traditional switch statement
            //string fileExtention = ".pdf";
            //string fileType;
            //switch (fileExtention)
            //{
            //    case ".pdf":
            //        fileType = "pdf document";
            //        break;

            //    case ".docx":
            //    case ".doc":
            //        fileType = "word document";
            //        break;
            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "excel spreadsheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;
            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}
            ////        (b) A switch expression
            //string fileExtension = ".pdf";

            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",

            //    ".docx" or ".doc" => "Word Document",

            //    ".xlsx" or ".xls" => "Excel Spreadsheet",

            //    ".jpg" or ".png" or ".gif" => "Image File",

            //    _ => "Unknown File Type"
            //};

            ///////////////////////////////////////////////////////////////////////////////////////
            //Question 04 : Ternary Operator
            //Rewrite the following using only ternary operators(no if statements):
            //int temperature = 35;

            //string weatherAdvice =
            //    temperature < 0 ? "Freezing! Stay indoors." :
            //    temperature < 15 ? "Cold. Wear a jacket." :
            //    temperature < 25 ? "Pleasant weather." :
            //    temperature < 35 ? "Warm. Stay hydrated." :
            //                       "Hot! Avoid sun exposure.";

            //    Is the Ternary Version More Readable?
            //    Usually: NO(for many conditions)

            //    When ternary operators are nested:
            //    Harder to read
            //    Harder to debug
            // Easy to make mistakes
            //So for many conditions, if-else is clearer.

            //When Is Ternary Better?
            //Use ternary when:
            // Only 1–2 simple conditions
            // Very short expressions
            //Assigning a value quickly
            ///////////////////////////////////////////////////////////////////////////////////////////
            //Question 05 : Input Validation with Loops
            //int attempts = 0;
            //string password;

            //bool isValid;

            //do
            //{
            //    Console.Write("Enter password: ");
            //    password = Console.ReadLine();

            //    attempts++;

            //    // Reset checks
            //    bool hasUpper = false;
            //    bool hasDigit = false;
            //    bool hasSpace = false;
            //    bool hasMinLength = password.Length >= 8;

            //    // Check characters
            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c))
            //            hasUpper = true;

            //        if (char.IsDigit(c))
            //            hasDigit = true;

            //        if (c == ' ')
            //            hasSpace = true;
            //    }

            //    // Validation
            //    isValid = hasMinLength && hasUpper && hasDigit && !hasSpace;

            //    // Error messages
            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid password:");

            //        if (!hasMinLength)
            //            Console.WriteLine("- Must be at least 8 characters long");

            //        if (!hasUpper)
            //            Console.WriteLine("- Must contain at least one uppercase letter");

            //        if (!hasDigit)
            //            Console.WriteLine("- Must contain at least one digit");

            //        if (hasSpace)
            //            Console.WriteLine("- Must not contain spaces");

            //        Console.WriteLine();
            //    }

            //    // Lock after 5 tries
            //    if (attempts == 5 && !isValid)
            //    {
            //        Console.WriteLine("Account locked");
            //        return;
            //    }

            //} while (!isValid);

            //// Success
            //Console.WriteLine("Password accepted!");
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            //Question 06 : Array Processing
            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };


            //// =========================
            //// (a) Failing Scores (<50)
            //// =========================

            //Console.WriteLine("Failing scores (below 50):");

            //foreach (int s in scores)
            //{
            //    if (s < 50)
            //    {
            //        Console.Write(s + " ");
            //    }
            //}

            //Console.WriteLine("\n");


            //// =========================
            //// (b) First Score Above 90
            //// =========================

            //int firstAbove90 = -1;

            //foreach (int s in scores)
            //{
            //    if (s > 90)
            //    {
            //        firstAbove90 = s;
            //        break; // Stop searching
            //    }
            //}

            //if (firstAbove90 != -1)
            //    Console.WriteLine("First score above 90: " + firstAbove90);
            //else
            //    Console.WriteLine("No score above 90 found");

            //Console.WriteLine();


            //// ==========================================
            //// (c) Class Average (Exclude < 40)
            //// ==========================================

            //int sum = 0;
            //int count = 0;

            //foreach (int s in scores)
            //{
            //    if (s >= 40) // Not absent
            //    {
            //        sum += s;
            //        count++;
            //    }
            //}

            //double average = (count > 0) ? (double)sum / count : 0;

            //Console.WriteLine("Class average (excluding <40): " + average);

            //Console.WriteLine();


            //// =========================
            //// (d) Grade Distribution
            //// =========================

            //int A = 0, B = 0, C = 0, D = 0, F = 0;

            //foreach (int s in scores)
            //{
            //    if (s >= 90)
            //        A++;
            //    else if (s >= 80)
            //        B++;
            //    else if (s >= 70)
            //        C++;
            //    else if (s >= 60)
            //        D++;
            //    else
            //        F++;
            //}

            //Console.WriteLine("Grade Distribution:");
            //Console.WriteLine("A (90-100): " + A);
            //Console.WriteLine("B (80-89): " + B);
            //Console.WriteLine("C (70-79): " + C);
            //Console.WriteLine("D (60-69): " + D);
            //Console.WriteLine("F (Below 60): " + F);

        }
    }
}
