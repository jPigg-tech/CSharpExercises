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
        TimeSpan duration;
        bool IsRunning;


        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Cannot start: already running");
            }
            _start = DateTime.Now;
            IsRunning = true;
        }

        public TimeSpan Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("Cannot stop: not running");
            }
            IsRunning = false;
            duration = DateTime.Now - _start;
            return duration;
        }
    }
}
