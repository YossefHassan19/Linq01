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



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


        }
    }
}
