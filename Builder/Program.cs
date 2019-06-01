using Builder.Models;
using Builder.Models.ProductModels;
using Builder.Services.ProductServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var products = new List<Product>()
            {
                new Product(){ Name="Product 1",Price=1 },
                new Product(){ Name="Product 2",Price=2 },
                new Product(){ Name="Product 3",Price=3 },
                new Product(){ Name="Product 4",Price=4 },
                new Product(){ Name="Product 5",Price=5 },
                new Product(){ Name="Product 6",Price=6 },
                new Product(){ Name="Product 7",Price=7 },
                new Product(){ Name="Product 8",Price=8 }
            };

            var productStockReportBuilder = new ProductStockReportBuilder(products);
            var productStockReportDirector = new ProductStockReportDirector(productStockReportBuilder);
            productStockReportDirector.BuilReport();
            var report = productStockReportBuilder.GetReport();

            Console.WriteLine(report);

            Console.ReadKey();
        }
    }
}
