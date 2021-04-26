using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class EncapsulationCustomer
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1");
            }
            Console.WriteLine("Promoted to level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
