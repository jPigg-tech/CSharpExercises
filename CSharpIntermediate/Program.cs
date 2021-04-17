
using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //var customer = new Customer();
            //customer.Id = 1;
            //customer.Name = "John";

            //var order = new Order();
            //customer.Orders.Add(order);

            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            Console.ReadLine();
        }
    }
}
