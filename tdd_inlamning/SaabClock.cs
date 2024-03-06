
namespace tdd_inlamning
{
    public class SaabClock
    {
        public TimeOnly GetTime(int hoursInput, int minutesInput, int secondsInput)
        {
            var time = new TimeOnly(hoursInput, minutesInput, secondsInput);
            return time;
        }
    }
}
