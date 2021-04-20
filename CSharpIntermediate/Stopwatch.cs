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
        private TimeSpan _duration;
        private DateTime _stop;
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

        public void Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("Cannot stop: not running");
            }
            IsRunning = false;
            _stop = DateTime.Now;            
        }

        public TimeSpan TimeElasped()
        {
            if (IsRunning)
            {
                return DateTime.Now - _start;
            }
            _duration = _stop - _start;
            return _duration;
        }
    }
}
