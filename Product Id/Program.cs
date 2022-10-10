using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Id
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Add();
            Console.WriteLine(p1.Print());

            Product p2 = new Product();
            p2.Add();
            Console.WriteLine(p2.Print());
        }
    }
}
