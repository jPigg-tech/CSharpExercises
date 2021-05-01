using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            
        }
        public override void ClosingConnection()
        {
            Console.WriteLine("SQL connection is now open");
        }

        public override void OpeningConnection()
        {
            Console.WriteLine("SQL connection is now closed");
        }
    }
}
