using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Services
{
    class TimeWatch
    {
        private DateTime _start;
        private DateTime _end;

        public void Start()
        {
            _start = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            _end = DateTime.Now;
            return GetElapsedTime();
        }

        public TimeSpan GetElapsedTime()
        {
            return _end - _start;
        }
    }
}
