
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

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4 }));
            Console.ReadLine();

            
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
                Console.ReadLine();
            }
        }
    }
}
