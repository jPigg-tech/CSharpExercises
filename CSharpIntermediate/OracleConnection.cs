using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void ClosingConnection()
        {
            Console.WriteLine("Oracle connection is now open");
        }

        public override void OpeningConnection()
        {
            Console.WriteLine("Oracle connection is now closed");
        }
    }
}
