using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tdd_inlamning
{
    public class Time
    {
        private const int MAX_SECONDS = 59;
        private const int MIN_SECONDS = 0;
        private const int MAX_MINUTES = 59;
        private const int MIN_MINUTES = 0;
        private const int MAX_HOURS = 23;
        private const int MIN_HOURS = 0;
        private const int AM_CUT_OFF = 12;

        private int hours;
        private int minutes;
        private int seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            IsValid();
        }

        public static Time operator+ (Time time, int secondsToAdd)
        {
            time.seconds += secondsToAdd;
            if (time.seconds > MAX_SECONDS)
            {
                time.minutes += 1;
                time.seconds -= 60;
            }
            if (time.minutes > MAX_MINUTES)
            {
                time.hours += 1;
                time.minutes -= 60;
            }
            if (time.hours > MAX_HOURS)
            {
                time.hours -= 24;
            }

            return time;
        }

        public static Time operator ++(Time time)
        {
            time.seconds += 1;
            if (time.seconds > MAX_SECONDS)
            {
                time.minutes += 1;
                time.seconds -= 60;
            }
            if (time.minutes > MAX_MINUTES)
            {
                time.hours += 1;
                time.minutes -= 60;
            }
            if (time.hours > MAX_HOURS)
            {
                time.hours -= 24;
            }

            return time;
        }

        public static Time operator- (Time time, int secondsToSubtract)
        {
            time.seconds -= secondsToSubtract;
            if (time.seconds < MIN_SECONDS)
            {
                time.minutes -= 1;
                time.seconds += 60;
            }
            if (time.minutes < MIN_MINUTES)
            {
                time.hours -= 1;
                time.minutes += 60;
            }
            if (time.hours < MIN_HOURS)
            {
                time.hours += 24;
            }

            return time;
        }

        public static Time operator --(Time time)
        {
            time.seconds -= 1;
            if (time.seconds < MIN_SECONDS)
            {
                time.minutes -= 1;
                time.seconds += 60;
            }
            if (time.minutes < MIN_MINUTES)
            {
                time.hours -= 1;
                time.minutes += 60;
            }
            if (time.hours < MIN_HOURS)
            {
                time.hours += 24;
            }

            return time;
        }

        public static bool operator <(Time time1, Time time2)
        {
            if (time1.hours < time2.hours)
                return true;
            
            if (time1.hours == time2.hours && 
                time1.minutes < time2.minutes)
                return true;
            
            if (time1.hours == time2.hours && 
                time1.minutes == time2.minutes && 
                time1.seconds < time2.seconds)
                return true;
            
            else return false;
        }

        public static bool operator >(Time time1, Time time2)
        {
            if (time1.hours > time2.hours)
                return true;
            
            if (time1.hours == time2.hours &&
                time1.minutes > time2.minutes)
                return true;
            
            if (time1.hours == time2.hours &&
                time1.minutes == time2.minutes &&
                time1.seconds > time2.seconds)
                return true;
            
            else return false;
        }

        public static bool operator ==(Time time1, Time time2)
        {
            if (time1.hours == time2.hours &&
                time1.minutes == time2.minutes &&
                time1.seconds == time2.seconds)
                return true;
            
            else return false;
        }

        public static bool operator !=(Time time1, Time time2)
        {
            if (time1.hours != time2.hours ||
                time1.minutes != time2.minutes ||
                time1.seconds != time2.seconds)
                return true;

            else return false;
        }

        public static bool operator <=(Time time1, Time time2)
        {
            if (time1.hours == time2.hours &&
                time1.minutes == time2.minutes &&
                time1.seconds == time2.seconds)
                return true;

            if (time1.hours < time2.hours)
                return true;
            
            if (time1.hours == time2.hours &&
                time1.minutes < time2.minutes)
                return true;
            
            if (time1.hours == time2.hours &&
                time1.minutes == time2.minutes &&
                time1.seconds < time2.seconds)
                return true;

            else return false;
        }

        public static bool operator >=(Time time1, Time time2)
        {
            if (time1.hours == time2.hours &&
                time1.minutes == time2.minutes &&
                time1.seconds == time2.seconds)
                return true;

            if (time1.hours > time2.hours)
                return true;

            if (time1.hours == time2.hours &&
                time1.minutes > time2.minutes)
                return true;

            if (time1.hours == time2.hours &&
                time1.minutes == time2.minutes &&
                time1.seconds > time2.seconds)
                return true;

            else return false;
        }

        public bool IsValid()
        {
            var isValid = false;

            if (hours >= MIN_HOURS && hours <= MAX_HOURS
                && minutes >= MIN_MINUTES && minutes <= MAX_MINUTES
                && seconds >= MIN_SECONDS && seconds <= MAX_SECONDS)
                isValid = true;

            return isValid;
        }

        public string TimeToString(bool is24HourFormat)
        {
            if (is24HourFormat == true)
               return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            else
            {
                if (hours == 12)
                    return $"{hours:D2}:{minutes:D2}:{seconds:D2} pm";
                else if (hours >= 13)
                    return $"{(hours - 12):D2}:{minutes:D2}:{seconds:D2} pm";
                else if (hours == 0)
                    return $"{(hours + 12):D2}:{minutes:D2}:{seconds:D2} am";
                else
                    return $"{hours:D2}:{minutes:D2}:{seconds:D2} am";
            }
        }

        public bool IsAm()
        {
            if (hours < AM_CUT_OFF)
                return true;
            else
                return false;
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

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
