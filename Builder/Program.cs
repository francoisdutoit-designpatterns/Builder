using Builder.Models;
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
            var a = new ProductStockReport();
            Console.WriteLine(a.GetString());

            Console.ReadKey();
        }
    }
}
