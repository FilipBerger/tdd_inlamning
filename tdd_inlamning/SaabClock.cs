
namespace tdd_inlamning
{
    public class SaabClock
    {
        public TimeOnly GetTime(int hoursInput, int minutesInput, int secondsInput)
        {
            var time = new TimeOnly(hoursInput, minutesInput, secondsInput);
            return time;
        }



        public bool IsValid(int hoursInput,  int minutesInput, int secondsInput) 
        { 
            var isValid = false;

            if (hoursInput >= 0 && hoursInput <= 23
                && minutesInput >= 0 && minutesInput <= 59
                && secondsInput >= 0 && secondsInput <= 59) 
                isValid = true;
            
            return isValid;
        }  
    }
}
