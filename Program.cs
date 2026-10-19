using Linq01.DataSources;
using Linq01.Models;
using System.Collections;
using System.Drawing;
using System.Xml.Linq;

namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01

            // 1. Get all products from the "Seafood" category. Print each product's name and price.

            //var result = Source.ProductList.Where(p => p.Category == "Seafood")
            //                               .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question02

            //2. Get a list of only the product names from ProductList. Print each name.

            //var result = Source.ProductList.Select(p => p.ProductName);

            #endregion

            #region Question03

            //3. Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });

            #endregion

            #region Question04

            //4. Get all products where UnitPrice is between 10 and 30

            //var result = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            #endregion

            #region Question05

            //5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //var result = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            #endregion

            #region Question06

            //6. Create a new anonymous type with three properties:
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
            //● Print the result.

            //var ProductInfo = new { Name = "Product Name", Price = 400, StockStatus = "Available" };

            //Console.WriteLine(ProductInfo.ToString());

            #endregion

            #region Question07

            //7. Print each product's name along with its position (1-based) in the list. Expected format: 1. Chai, 2. Chang, etc.

            //var result = Source.ProductList.Select((p, i) => new { Position = i + 1, ProductName = p.ProductName });

            #endregion




            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
