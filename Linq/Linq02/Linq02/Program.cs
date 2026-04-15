using Demo.DataSources;
using Demo.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using static Demo.DataSources.Source;
namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1. Get top 3 most expensive products

            //var Result = ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);

            #endregion

            #region Q2

            //2. show page 2 of products, with page size = 5

            //var Result = ProductList
            //    .Skip(5)
            //    .Take(5);
            #endregion

            #region Q3

            //3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var Result = ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);

            #endregion

            #region Q4

            //4. Check if ALL products in the "Seafood" category are in stock

            //bool Result = ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);
            //Console.WriteLine(Result);
            #endregion

            #region Q5

            //5. Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //bool Result = ids.Contains(9);
            #endregion

            #region Q6

            //6. Group all products by Category and print each group with its product count.

            //var Result = ProductList
            //    .GroupBy(P => P.Category);
            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"{group.Key} - {group.Count()} products");
            //}

            #endregion

            #region Q7


            // 7. Group products by Category and project only product names per group

            //var Result = ProductList
            //           .GroupBy(p => p.Category)
            //           .Select(k => new
            //           {
            //               Category = k.Key,

            //           });



            #endregion

            #region Q8

            //8. Find all categories that have MORE THAN 3 products 

            //var Result = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);
            #endregion

            #region Q9

            //9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.

            //var Result = from c in Source.CustomerList
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
            //             };
            #endregion

            #region Q10

            // 10. Calculate the total number of units in stock across all products

            //var Result = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(Result);
            #endregion

            #region Q11

            //11. Find the CHEAPEST and MOST EXPENSIVE product prices 

            //var min = ProductList.Min(p => p.UnitPrice);
            //var max = ProductList.Max(p => p.UnitPrice);
            #endregion

            #region Q12

            //12. Get a distinct list of all product categories

            //var Result = ProductList
            //     .Select(p => p.Category)
            //     .Distinct();

            #endregion

            #region Q13
            //13. find product IDs that are in setA but NOT in setB

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var Result = setA.Except(setB);
            #endregion

            #region Q14

            //14. Find countries that appear in list1 but NOT in list2 (case -insensitive).

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var Result = list1
            //   .Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion

            #region Q15

            //15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

            //var dict = ProductList.ToDictionary(p => p.ProductID);

            //if (dict.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine(product);
            //}
            #endregion


            #region Q16
            //16.Get the first product whose price is greater than $50.

            //var Result = ProductList
            //    .First(P => P.UnitPrice > 50);
            //Console.WriteLine(Result);
            #endregion

            #region Q17

            //17. Try to get the first product with a price > $500. it returns null instead of throwing.

            //var Result = ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 500);

            //    Console.WriteLine(Result); 
            #endregion

            #region Q18

            //18. Generate a multiplication table row for 7

            //var result = Enumerable.Range(1, 10)
            //    .Select(i => $"7 x {i} = {7 * i}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q19

            //19. Generate even numbers between 1 and 30.

            //var Result = Enumerable.Range(1, 30)
            //   .Where(n => n % 2 == 0);
            #endregion

            #region Q20
            //20. Concatenate the first 3 product names with the first 3 customer company names into a single sequence.

            //var Result = ProductList
            //    .Select(p => p.ProductName)
            //    .Take(3)
            //    .Concat(
            //         Source.CustomerList
            //         .Select(c => c.CompanyName)
            //         .Take(3)
            //    );
            #endregion

            #region Q21
            //21. Pair each product with a customer (by position) and produce a string "ProductName sold to CompanyName".

            //var Result = ProductList
            //    .Zip(Source.CustomerList, (p, c) =>
            //        $"{p.ProductName} sold to {c.CompanyName}");

            #endregion

            foreach (var item in Result)
            {
               Console.WriteLine(item);
            }
        }
    }
}
