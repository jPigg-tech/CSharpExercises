using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        // More efficiently we can create a property (shown below)
        
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
    }
}
