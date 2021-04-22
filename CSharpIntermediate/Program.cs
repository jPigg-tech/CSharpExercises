
using System;
using System.Threading;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
            Console.ReadLine();
        }

        static void ShowParentClassFields()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        static void RunStopWatchClass()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.TimeElasped().ToString());
            Console.ReadLine();
        }

        static void GetHttpCookieIndexer()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Jeff";
            Console.WriteLine(cookie["name"]);
        }

        static void GetAgeInYearsExample()
        {
            var person = new Person(new DateTime(1992, 10, 5));
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }

        static void CreateNewPersonUsingGetAndSetMethods()
        {
            //var person = new Person();
            //person.SetBirthdate(new DateTime(1992, 10, 5));
            //Console.WriteLine(person.GetBirthdate());
            //Console.ReadLine();
        }

        static void UseOutKeywordExample()
        {
            // Using the Out key word
            int number;
            var result = int.TryParse("123", out number);
            if (result)
            {
                Console.WriteLine(number);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Conversion failed.");
                Console.ReadLine();
            }

            // Two different ways to turn a string into an int
            // and check if its an vaild int

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion Failed.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
            Console.ReadLine();
            // With the params key word in the method signature you do not need
            // to construct a new int array, you can simply put the ints in the parameters
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

        static void CreateCustomer()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Orders.Count);
            Console.ReadLine();

            // This was tested to show the importance of intansiating 
            // a 'readonly' list in the Customer class
        }
    }
}
