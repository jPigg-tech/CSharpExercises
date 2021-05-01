using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            this.ConnectionString = connectionString ?? throw new ArgumentNullException();
        }

        public abstract void OpeningConnection();
        public abstract void ClosingConnection();

    }
}
