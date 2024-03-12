using tdd_inlamning;

namespace tdd_inlamning.Tests
{
    public class TimeTests
    {
        [Theory]
        [InlineData(12, 15, 30, true)]
        [InlineData(25, 70, 65, false)]

        public void IsValidTime_Test(int hours, int minutes, int seconds, bool expected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act
            var result = time.IsValid();
            
            // Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(15, 20, 23, true, "15:20:23")]
        [InlineData(12, 0, 0, false, "12:00:00 pm")]
        [InlineData(15, 20, 23, false, "03:20:23 pm")]
        [InlineData(0, 0, 0, false, "12:00:00 am")]

        public void ReturnsTimeToString_Test(int hours, int minutes, int seconds, bool is24HourFormat, string expected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act

            var result = time.TimeToString(is24HourFormat);

            // Assert

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(11, 20, 23, true)]
        [InlineData(15, 20, 23, false)]

        public void ReturnsIsAm_Test(int hours, int minutes, int seconds, bool expected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act
            var result = time.IsAm();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 0, 5, 0, 0, 5)]
        [InlineData(0, 0, 55, 5, 0, 1, 0)]
        [InlineData(23, 59, 55, 5, 0, 0, 0)]

        public void AddOperator_Test(int hours, int minutes, int seconds, int secondsToAdd, int hoursExpected, int minutesExpected, int secondsExpected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act
            var timeActual = time + secondsToAdd;
            
            // Assert
            Assert.Equal(hoursExpected, timeActual.Hours);
            Assert.Equal(minutesExpected, timeActual.Minutes);
            Assert.Equal(secondsExpected, timeActual.Seconds);
        }

        [Theory]
        [InlineData(0, 0, 10, 5, 0, 0, 5)]
        [InlineData(0, 1, 0, 5, 0, 0, 55)]
        [InlineData(0, 0, 0, 5, 23, 59, 55)]

        public void SubOperator_Test(int hours, int minutes, int seconds, int secondsToSubtract, int hoursExpected, int minutesExpected, int secondsExpected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act
            var timeActual = time - secondsToSubtract;

            // Assert
            Assert.Equal(hoursExpected, timeActual.Hours);
            Assert.Equal(minutesExpected, timeActual.Minutes);
            Assert.Equal(secondsExpected, timeActual.Seconds);
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 1)]
        [InlineData(0, 0, 59, 0, 1, 0)]
        [InlineData(23, 59, 59, 0, 0, 0)]

        public void IncrementOperator_Test(int hours, int minutes, int seconds, int hoursExpected, int minutesExpected, int secondsExpected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act
            var timeActual = time++;

            // Assert
            Assert.Equal(hoursExpected, timeActual.Hours);
            Assert.Equal(minutesExpected, timeActual.Minutes);
            Assert.Equal(secondsExpected, timeActual.Seconds);
        }

        [Theory]
        [InlineData(0, 0, 1, 0, 0, 0)]
        [InlineData(0, 1, 0, 0, 0, 59)]
        [InlineData(0, 0, 0, 23, 59, 59)]

        public void DecrementOperator_Test(int hours, int minutes, int seconds, int hoursExpected, int minutesExpected, int secondsExpected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act
            var timeActual = time--;

            // Assert
            Assert.Equal(hoursExpected, timeActual.Hours);
            Assert.Equal(minutesExpected, timeActual.Minutes);
            Assert.Equal(secondsExpected, timeActual.Seconds);
        }

        [Theory]
        [InlineData(0, 0, 10, 0, 0, 0, false)]
        [InlineData(0, 10, 0, 10, 0, 0, true)]

        public void LessThanOperator_Test(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2, bool expected)
        {
            // Arrange
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            bool result;

            // Act
            if (time1 < time2)
            {
                result = true;
            }
            else 
            { 
                result = false; 
            }

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 10, 0, 0, 0, true)]
        [InlineData(0, 10, 0, 10, 0, 0, false)]

        public void MoreThanOperator_Test(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2, bool expected)
        {
            // Arrange
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            bool result;

            // Act
            if (time1 > time2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 10, 0, 0, 10, true)]
        [InlineData(0, 10, 0, 10, 0, 0, false)]

        public void EqualOperator_Test(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2, bool expected)
        {
            // Arrange
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            bool result;

            // Act
            if (time1 == time2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 10, 0, 0, 10, false)]
        [InlineData(0, 10, 0, 10, 0, 0, true)]

        public void NotEqualOperator_Test(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2, bool expected)
        {
            // Arrange
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            bool result;

            // Act
            if (time1 != time2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 10, 0, 0, 0, false)]
        [InlineData(0, 10, 0, 10, 0, 0, true)]
        [InlineData(1, 1, 1, 1, 1, 1, true)]

        public void LessThanOrEqualOperator_Test(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2, bool expected)
        {
            // Arrange
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            bool result;

            // Act
            if (time1 <= time2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0, 10, 0, 0, 0, true)]
        [InlineData(0, 10, 0, 10, 0, 0, false)]
        [InlineData(1, 1, 1, 1, 1, 1, true)]

        public void MoreThanOrEqualOperator_Test(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2, bool expected)
        {
            // Arrange
            var time1 = new Time(hours1, minutes1, seconds1);
            var time2 = new Time(hours2, minutes2, seconds2);
            bool result;

            // Act
            if (time1 >= time2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            // Assert
            Assert.Equal(expected, result);
        }
    }
}