using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running ;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch is already running.");

            _running = true;
            _startTime = DateTime.Now;
            
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("StopWatch is not running.");
            _running = false;
            _endTime = DateTime.Now;
        }

        public TimeSpan GetInterval()
        {
            return _endTime -_startTime;
        }
    }
}
