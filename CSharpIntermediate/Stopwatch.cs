using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Stopwatch
    {
        private DateTime _start;


        public void Start()
        {
            _start = DateTime.Now;
        }

        public void Stop()
        {
            TimeSpan duration = DateTime.Now - _start;
            Console.WriteLine(duration.TotalSeconds.ToString());
        }
    }
}
