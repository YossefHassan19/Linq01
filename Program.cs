using Linq01.DataSources;
using Linq01.Models;
using System.Collections;

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







            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
