using Demo.Models;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using static Demo.DataSources.Source;
namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1. Get all products from the "Seafood" category. Print each product's name and price.


            //var Result = ProductList.Where(p => p.Category == "Seafood").Select(p => new { p.ProductName, p.UnitPrice });


            #endregion
            #region Q2
            //2. Get a list of only the product names from ProductList. Print each name.

            //var Result = ProductList.Select(P => P.ProductName);
            #endregion
            #region Q3
            //3. Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var Result = ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });
            #endregion
            #region Q4
            //4. Get all products where UnitPrice is between 10 and 30

            //var Result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            #endregion
            #region Q5
            //5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            #endregion
            #region Q6
            //6. Create a new anonymous type with three properties:
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0,
            //otherwise "Out of Stock"
            //● Print the result.


            //var Result = ProductList
            //    .Select(p => new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //    });


            #endregion
            #region Q7
            //7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.

            //var Result = ProductList
            //    .Select((p, i) => new
            //    {
            //        I = i + 1,
            //        Name = p.ProductName
            //    });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.I}. {item.Name}");
            //}
            #endregion
            #region Q8
            //8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var Result = ProductList.OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .Select(p=> new {p.Category , p.ProductName , p.UnitPrice});
            #endregion
            #region Q9
            //9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

            //var Result = ProductList.Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .Select(p => new { p.ProductName, p.UnitsInStock });
            #endregion
            #region Q10
            //10. Using QUERY SYNTAX with a compound from clause, list
            //all orders placed in 1997 or later showing CustomerID and OrderDate.

            //Ans:

            //var Result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new
            //             {
            //                 CustomerID = c.CustomerID,
            //                 OrderDate = o.OrderDate
            //             };
            #endregion
            #region Q11
            //11. Show position number alongside ProductName

            //var Result = ProductList.Select((p, i) => new
            //{
            //    I = i + 1,
            //    p.ProductName
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.I}. {item.ProductName}");
            //}
            #endregion
            #region Q12
            //12. Sort first by-word length and then by a case -insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr
            //    .OrderBy(p => p.Length)
            //    .ThenBy(p => p, StringComparer.OrdinalIgnoreCase);
            #endregion
            #region Q13

            //13.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.


            //string[] Arr = { "bind", "lily", "mini", "filter", "limit", "iris" };

            //var Result = Arr
            //    .Where(w => w.Length > 1 && char.ToLower(w[1]) == 'i')
            //    .Reverse();

            #endregion


            //for print
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }



        
    }
        
    
}
