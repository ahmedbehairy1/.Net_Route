namespace Adv2
{
    internal class Program
    {
        // Smart Product Search Method 
        static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter) 
        { 
            return products.Where(filter).ToList();
        }

        //Custom Report Generator method 
        static void PrintReport (List<Product> products , Action<Product>printer)
        {
            foreach(var p in products)
            {
                printer(p);
            }
        }

        //Transform products method
        static List<string> TransformProducts(List<Product> products, Func<Product, string> transformer) 
        {
            return products.Select(transformer).ToList();
        }

        //Filter products methos 
        static List<Product> FilterProducts (List<Product>products, Predicate<Product> condition) 
        {
            return products.FindAll(condition);
        }
        static void Main(string[] args)
        {
            List<Product> Catalog = new()
            {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
            new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 },
            };

            #region Task01
            //1. All Electronics products 
            //Console.WriteLine("---Electronics---");
            //var elecreonics = SearchProducts(Catalog, p => p.Category == "Electronics");
            //elecreonics.ForEach(p => Console.WriteLine($"{p.Name}-${p.Price} (Stock:{p.Stock})"));

            //2.Products cheaper than $50
            //Console.WriteLine("---Under $50---");
            //var cheap = SearchProducts(Catalog, P => P.Price < 50);
            //cheap.ForEach(p => Console.WriteLine($"{p.Name}-${p.Price} (Stock:{p.Stock})"));

            //3. Products that are in stock (Stock > 0) 
            //Console.WriteLine("---In Stock---");
            //var instock = SearchProducts(Catalog, p => p.Stock > 0);
            //instock.ForEach(p => Console.WriteLine($"{p.Name}-${p.Price} (Stock:{p.Stock})"));

            //4. Clothing products under $100
            //Console.WriteLine("---Clothing Under $100---");
            //var clothing = SearchProducts(Catalog, p => p.Category == "Clothing" && p.Price < 100);
            //clothing.ForEach(p => Console.WriteLine($"{p.Name}-${p.Price} (Stock:{p.Stock})"));
            #endregion
            #region Task3.1
            //scenario 1 : short report 
            //Console.WriteLine("---Short Report---");
            //PrintReport(Catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

            //Console.WriteLine();

            //senario 2 : detailed Report 
            //Console.WriteLine("---Detailed Report---");
            //PrintReport(Catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price:${p.Price} | Stock:{p.Stock}"));


            #endregion
            #region Task 3.2
            //Scenario 3: Summary List
            //Console.WriteLine("---Summary List---");
            //var summary = TransformProducts(Catalog,p => $"{p.Name} (${p.Price})");
            //summary.ForEach(Console.WriteLine);

            //Console.WriteLine();

            // Scenario 4: Price Label
            //Console.WriteLine("---Price Labels---");
            //var labels = TransformProducts(Catalog, p => p.Price > 100 ? $"{p.Name}: Expensive!" : $"{p.Name}: Affordable");

            //labels.ForEach(Console.WriteLine);
            #endregion
            #region Task3.3
            //Scenario 5: Low Stock Alert 
            Console.WriteLine("---Low-Stock Alert---");
            var lowStock = FilterProducts(Catalog, p => p.Stock < 20);

            foreach (var p in lowStock)
            {
                Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
            }
            #endregion

        }
    }
}
