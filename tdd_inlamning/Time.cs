using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_inlamning
{
    public struct Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            IsValid(hours, minutes, seconds);
        }

        public bool IsValid(int hours, int minutes, int seconds)
        {
            var isValid = false;

            if (hours >= 0 && hours <= 23
                && minutes >= 0 && minutes <= 59
                && seconds >= 0 && seconds <= 59)
                isValid = true;

            return isValid;
        }

        public string TimeToString(int hours, int minutes, int seconds, bool is24HourFormat)
        {
            throw new NotImplementedException();
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
    }
}
