using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Person
    {
        //private DateTime _birthdate;

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}

        // ..... More efficiently we can create a property (shown below) 
        
        //public DateTime Birthdate
        //{
        //    get { return _birthdate; }
        //    set { _birthdate = value; }
        //}

        // ...... Or we can use Auto-implemented Properties 
        public DateTime Birthdate {get; private set;}
        public string Name { get; set; }
        public string  Username { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
        
        
    }
}
