using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class DbCommand
    {
        
        public DbCommand(DbConnection dbConnection)
        {
            if (dbConnection == null)
            {
                throw new ArgumentNullException();
            }
            else if (dbConnection.ConnectionString == "SQL")
            {
                Console.WriteLine("Connecting you to the SQL database.");
            }
            else if (dbConnection.ConnectionString == "Oracle")
            {
                Console.WriteLine("Connecting you to the Oracle database.");
            }
            else
            {
                throw new ArgumentException();
            }
        }


    }
}
