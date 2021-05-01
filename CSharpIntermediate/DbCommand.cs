using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class DbCommand
    {
        
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null && instruction == null || instruction == "")
            {
                throw new ArgumentNullException();
            }            
        }

        public void Execute()
        {
            
        }


    }
}
