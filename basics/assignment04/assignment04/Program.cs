using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1: Enums
            //Q1: Day of the Week
            //Console.WriteLine("Enter a day number (0-6): ");
            //int dayNumber = int .Parse(Console.ReadLine());
            //if (dayNumber < 0 || dayNumber > 6)
            //{
            //    Console.WriteLine("invalid day num");
            //}
            //DayOfWeek day = (DayOfWeek)dayNumber;
            //Console.WriteLine($"Day name: {day}");

            //switch (day)
            //{

            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Weekend");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("Weekend");
            //        break;
            //    default:
            //        Console.WriteLine("Workday");
            //        break;
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Part 2: Arrays
            //Q1: Array Statistics
            //Console.WriteLine("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("enter element" + (i+1)+ ":");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //int max = numbers[0];
            //int min = numbers[0];

            //for (int i = 1; i < size; i++) 
            //{ 
            //    sum += numbers[i];

            //    if (numbers[i]>max)
            //        max = numbers[i];

            //    if (numbers[i]<min)
            //        min = numbers[i];
            //}

            //double average = (double) sum / size;

            //Console.WriteLine("-------------------------");
            //Console.WriteLine($"sum: {sum}");
            //Console.WriteLine($"average: {average}");
            //Console.WriteLine($"maximum :{max}");
            //Console.WriteLine($"minimum : {min}");

            //Console.WriteLine("reverse");
            //for (int i = size-1; i >=0; i--)
            //{
            //    Console.Write(numbers[i] );
            //}
            //////////////////////////////////////////////////////////////////////////////////
            //Q2 : Student Grades Matrix
            //int[,] grades = new int[3,4];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"\nEntering grades for Student {i + 1}:");

            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //double totalSum = 0;
            //Console.WriteLine("\n--- Student Averages ---");

            //for (int i = 0; i < 3; i++)
            //{
            //    int studentSum = 0;

            //    for (int j = 0; j < 4; j++)
            //    {
            //        studentSum += grades[i, j];
            //    }

            //    double studentAverage = (double)studentSum / 4;
            //    Console.WriteLine($"Student {i + 1} Average: {studentAverage:F2}");

            //    totalSum += studentSum;
            //}
            //double classAverage = totalSum / (3 * 4);

            //Console.WriteLine("\nOverall Class Average: " + classAverage.ToString("F2"));

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //Part 3: Functions(Methods)
            //Q1: Basic Calculator Functions
            //Console.WriteLine("enter first number");
            //double num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number");
            //double num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter operator (+, -, *, /) ");
            //char operation = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //double result = 0 ;

            //switch (operation)
            //{
            //    case '+':
            //        result = add(num1, num2);
            //        break;
            //    case '-':
            //        result = subtract(num2, num1);
            //        break;
            //    case '*':
            //            result = multiply(num1, num2);
            //        break;
            //    case '/':
            //            result = divide(num1, num2);
            //        break;        
            //    default:
            //        Console.WriteLine("Invalid operation!");
            //        break;
            //}
            //if (!double.IsNaN(result))
            //{
            //    Console.WriteLine($"Result: {result}");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////
            //Q2 : Circle Calculator with out
            //Console.Write("Enter circle radius: ");
            //double radius = double.Parse(Console.ReadLine());

            //double area;
            //double circumference;

            //CalculateCircle(radius, out area, out circumference);

            //Console.WriteLine($"\nArea: {area:F2}");
            //Console.WriteLine($"Circumference: {circumference:F2}");

        }
        static double add(double x, double y)
        {
            return x + y;
        }

        static double subtract(double x, double y)
        {
            return x - y;
        }

        static double multiply(double x, double y)
        {
            return x * y;
        }

        static double divide(double x, double y)
        {
            if (y == 0)
            { Console.WriteLine("error division by zero");
                return double.NaN;
            }
            return x / y;
        }

        static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }

    }
}
