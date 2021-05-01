using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        public string Instruction { get; set; }
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null && instruction == null || instruction == "")
            {
                throw new ArgumentNullException();
            }

            this.DbConnection = dbConnection;
            this.Instruction = instruction;
        }

        public void Execute()
        {
            DbConnection.OpeningConnection();

            Console.WriteLine("Running {0}", Instruction);

            DbConnection.ClosingConnection();
        }


    }
}
