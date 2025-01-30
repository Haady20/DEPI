using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Data;
using static Data.ListGenerators;

namespace AssigmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1-
            //var OutOfStock = ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).ToList();
            //foreach (var item in OutOfStock)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2-
            //var ExpensiveProducts = ListGenerators.ProductList.Where(product => product.UnitPrice > 3.00M);
            //foreach (var item in ExpensiveProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3-
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Select((name, index) => new { Name = name, Value = index }).Where(x => x.Value < x.Name.Length)
            //    .Select(x => x.Value).ToList();
            //Console.WriteLine("Digits whose name is shorter than their value:");
            //Console.WriteLine(string.Join(",",result));
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region 1-
            //var OutOfStock = ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).ToList();
            //var FirstOutOfStock = OutOfStock.FirstOrDefault();
            //Console.WriteLine(FirstOutOfStock);
            #endregion
            #region 2-
            //var firstExpensiveProduct = ListGenerators.ProductList
            //               .FirstOrDefault(product => product.UnitPrice > 1000M);
            //if (firstExpensiveProduct != null)
            //{

            //    Console.WriteLine("First product is:");
            //    Console.WriteLine(firstExpensiveProduct);
            //}
            //else
            //{
            //    Console.WriteLine("No products found with a price greater than 1000.");
            //}
            #endregion
            #region 3-
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThanFive = Arr
            //    .Where(num => num > 5)
            //    .FirstOrDefault();
            //Console.WriteLine($"Secound Number Greater Than 5 is: {secondNumberGreaterThanFive}.");
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region 1-
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(num => num % 2 != 0);
            //Console.WriteLine($"Tnumber of odd numbers in the array is: {oddCount}.");
            #endregion
            #region 2-
            //List<Customer> customers = ListGenerators.CustomerList;
            //foreach (var item in customers)
            //{
            //    int orderCount = item.Orders?.Length ?? 0;
            //    Console.WriteLine($"Customer: {item.Name}, Orders Count: {orderCount}.");
            //}
            #endregion
            #region 3-
            //List<Product> products = ListGenerators.ProductList;
            //var categoryCounts = products
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Count = g.Count() })
            //    .ToList();
            //foreach (var category in categoryCounts)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Products Count: {category.Count}.");
            #endregion
            #region 4-
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total=Arr.Sum();
            //Console.WriteLine($"Summition is: {total}.");
            #endregion
            #region 5-
            #endregion
            #region 6-
            //var categoryTotals = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    });

            //foreach (var category in categoryTotals)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Total Units in Stock: {category.TotalUnitsInStock}.");
            //}
            #endregion
            #region 7-
            #endregion
            #region 8-
            //var cheapestPrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category =g.Key,
            //        CheapestPrice=g.Min(p=>p.UnitPrice)
            //    });
            //foreach (var category in cheapestPrices)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Cheapest Price: {category.CheapestPrice}.");
            //}
            #endregion
            #region 9-
            //var cheapestProducts = ListGenerators.ProductList
            //   .GroupBy(p => p.Category)
            //   .SelectMany(g =>
            //   {
            //       var cheapestPrice = g.Min(p => p.UnitPrice);
            //       return g.Where(p => p.UnitPrice == cheapestPrice);
            //   });

            //foreach (var product in cheapestProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.UnitPrice}");
            //}
            #endregion
            #region 10-
            #endregion
            #region 11-
            //var mostExpensivePrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        mostExpensivePrices=g.Max(p => p.UnitPrice)
            //    });
            //foreach (var category in mostExpensivePrices)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Most Expensive Price: {category.mostExpensivePrices}");
            //}
            #endregion
            #region 12-
            //var mostExpensiveProducts = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .SelectMany(g =>
            //    {
            //        var mostExpensivePrice = g.Max(p => p.UnitPrice);
            //        return g.Where(p => p.UnitPrice == mostExpensivePrice);
            //    });
            //foreach (var product in mostExpensiveProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.UnitPrice}.");
            //}
            #endregion
            #region 13-
            #endregion
            #region 14-
            //var averagePrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        AveragePrice=g.Average(p=>p.UnitPrice)
            //    });
            //foreach (var category in averagePrices)
            //{
            //    Console.WriteLine($"Category: {category.category}, Average Price: {category.AveragePrice}.");
            //}
            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region 1-
            //var sortedProducts = ListGenerators.ProductList
            //  .OrderBy(product => product.ProductName)
            //  .ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion
            #region 2- //GPT
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr, new CaseInsensitiveComparer());

            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 3-
            //var sortedProducts=ListGenerators.ProductList.OrderByDescending(p=>p.UnitsInStock).ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 4-
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var sortedDigits = Arr
            //    .OrderBy(name => name.Length)
            //    .ThenBy(name => name)// <-- GPT
            //    .ToList();
            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #region 5-
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = words
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 6-
            //var sortedProducts = ListGenerators.ProductList
            //.OrderBy(product => product.Category)
            //.ThenByDescending(product => product.UnitPrice)
            //.ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"{product.Category}: {product.ProductName} - ${product.UnitPrice}");
            //}
            #endregion
            #region 7-
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = words
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 8-
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var filteredReversedDigits = Arr
            //    .Where(word => word[1] == 'i')
            //    .Reverse() 
            //    .ToList();
            //foreach (var digit in filteredReversedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #endregion
            #region LINQ – Transformation Operators
            #region 1-
            //var productNames = ListGenerators.ProductList
            //   .Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #region 2-
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var wordCases = words
            //    .Select(word => new
            //    {
            //        UpperCase = word.ToUpper(),
            //        LowerCase = word.ToLower()
            //    });
            //foreach (var word in wordCases)
            //{
            //    Console.WriteLine($"Uppercase: {word.UpperCase}, Lowercase: {word.LowerCase}.");
            //}
            #endregion
            #region 3-
            //var products = ListGenerators.ProductList;
            //var productDetails = products.Select(p => new
            //{
            //    ProductName = p.ProductName,
            //    Price = p.UnitPrice,
            //    Category = p.Category
            //});
            //foreach (var product in productDetails)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.Price}, Category: {product.Category}.");
            //}
            #endregion
            #region 4-
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine("Result Number: In-place?");
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    bool matches = Arr[i] == i;
            //    Console.WriteLine($"{Arr[i]}: {matches}");
            //}
            #endregion
            #region 5-
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }; int[] numbersB = { 1, 3, 5, 7, 8 };
            //foreach (var item1 in numbersA)
            //{
            //    foreach (var item2 in numbersB)
            //    {
            //        if (item1< item2)
            //        {
            //            Console.WriteLine($"{item1} is less than, {item2}.");
            //        }
            //    }
            //}
            #endregion
            #region 6-
            //var lowValueOrders = ListGenerators.CustomerList
            //.SelectMany(customer => customer.Orders)
            //.Where(order => order.Total < 500.00)
            //.ToList();
            //foreach (var order in lowValueOrders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion
            #region 7-
            //var recentOrders = ListGenerators.CustomerList
            //.SelectMany(customer => customer.Orders)
            //.Where(order => order.OrderDate.Year >= 1998)
            //.ToList();
            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine(order);
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region 1-
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int oddCount = Arr.Count(number => number % 2 != 0);
            //Console.WriteLine($"Number of odd numbers: {oddCount}");
            #endregion
            #region 2-
            //var customerOrderCounts = ListGenerators.CustomerList
            //    .Select(customer => new
            //    {
            //        CustomerName = customer.Name,
            //        OrderCount = customer.Orders?.Length ?? 0
            //    })
            //    .ToList();
            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine($"{customer.CustomerName} has {customer.OrderCount} orders.");
            //}
            #endregion
            #region 3-
            //var categoryProductCounts = ListGenerators.ProductList
            //    .GroupBy(product => product.Category)
            //    .Select(group => new
            //    {
            //        Category = group.Key,
            //        ProductCount = group.Count()
            //    })
            //    .ToList();
            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"{category.Category} has {category.ProductCount} products.");
            //}
            //#endregion
            //#region 4-
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = Arr.Sum();
            //Console.WriteLine($"Total: {total}");
            #endregion
            #region 5-
            #endregion
            #region 6-
            //var categoryTotals = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    });

            //foreach (var category in categoryTotals)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Total Units in Stock: {category.TotalUnitsInStock}.");
            //}
            #endregion
            #region 7-
            #endregion
            #region 8-
            //var cheapestPrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category =g.Key,
            //        CheapestPrice=g.Min(p=>p.UnitPrice)
            //    });
            //foreach (var category in cheapestPrices)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Cheapest Price: {category.CheapestPrice}.");
            //}
            #endregion
            #region 9-
            //var cheapestProducts = ListGenerators.ProductList
            //   .GroupBy(p => p.Category)
            //   .SelectMany(g =>
            //   {
            //       var cheapestPrice = g.Min(p => p.UnitPrice);
            //       return g.Where(p => p.UnitPrice == cheapestPrice);
            //   });

            //foreach (var product in cheapestProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.UnitPrice}");
            //}
            #endregion
            #region 10-
            #endregion
            #region 11-
            //var mostExpensivePrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        mostExpensivePrices=g.Max(p => p.UnitPrice)
            //    });
            //foreach (var category in mostExpensivePrices)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Most Expensive Price: {category.mostExpensivePrices}");
            //}
            #endregion
            #region 12-
            //var mostExpensiveProducts = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .SelectMany(g =>
            //    {
            //        var mostExpensivePrice = g.Max(p => p.UnitPrice);
            //        return g.Where(p => p.UnitPrice == mostExpensivePrice);
            //    });
            //foreach (var product in mostExpensiveProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, Price: {product.UnitPrice}.");
            //}
            #endregion
            #region 13-
            #endregion
            #region 14-
            //var averagePrices = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    });
            //foreach (var category in averagePrices)
            //{
            //    Console.WriteLine($"Category: {category.category}, Average Price: {category.AveragePrice}.");
            //}
            #endregion
            #endregion
            #region LINQ - Ordering Operators
            #region 1-
            //var sortedProducts = ListGenerators.ProductList
            //  .OrderBy(product => product.ProductName)
            //  .ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion
            #region 2- //GPT
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr, new CaseInsensitiveComparer());

            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 3-
            //var sortedProducts=ListGenerators.ProductList.OrderByDescending(p=>p.UnitsInStock).ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 4-
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var sortedDigits = Arr
            //    .OrderBy(name => name.Length)
            //    .ThenBy(name => name)// <-- GPT
            //    .ToList();
            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #region 5-
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = words
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 6-
            //var sortedProducts = ListGenerators.ProductList
            //.OrderBy(product => product.Category)
            //.ThenByDescending(product => product.UnitPrice)
            //.ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"{product.Category}: {product.ProductName} - ${product.UnitPrice}");
            //}
            #endregion
            #region 7-
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = words
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #endregion
            #region LINQ - Quantifiers
            #region 1-
            #endregion
            #region 2-
            //var groupedProductsOutOfStock = ListGenerators.ProductList
            //   .Where(product => product.UnitsInStock == 0)
            //   .GroupBy(product => product.Category)
            //   .Where(group => group.Any())
            //   .Select(group => new
            //   {
            //       Category = group.Key,
            //       Products = group.ToList()
            //   })
            //   .ToList();
            //if (groupedProductsOutOfStock.Any())
            //{
            //    foreach (var categoryGroup in groupedProductsOutOfStock)
            //    {
            //        Console.WriteLine($"Category: {categoryGroup.Category}");
            //        foreach (var product in categoryGroup.Products)
            //        {
            //            Console.WriteLine($" - Product: {product.ProductName}, Stock: {product.UnitsInStock}");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No categories with out-of-stock products.");
            //}
            #endregion
            #region 3-
            //var groupedProducts = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0))
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.ToList()
            //    });
            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Category}");
            //    foreach (var product in group.Products)
            //    {
            //        Console.WriteLine($"{product}");
            //    }
            //    #endregion
            #endregion
        }
    }
                #endregion
        class CaseInsensitiveComparer : IComparer<string>//GPT
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            }

        }
    }