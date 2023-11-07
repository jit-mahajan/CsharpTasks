using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchProgram
{
    public class Functionality
    {
        private DateTime _startTime {  get; set; }
        private DateTime _endTime {  get; set; }

        private bool _isRunning;


        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("StopWatch Is Already running.....");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("StopWatch Is Already Stopped...");

            _endTime = DateTime.Now;
            _isRunning = false;
        }


        public TimeSpan GetTimeSpan()
        {
            return _endTime - _startTime;
        }





    }
}
