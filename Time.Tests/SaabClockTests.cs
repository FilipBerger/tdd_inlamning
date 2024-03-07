using tdd_inlamning;

namespace tdd.inlamning.Tests
{
    public class SaabClockTests
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

        //[Fact]
        //public void IsValidTime_Test()
        //{
        //    // Arrange
        //    var time = new Time();

        //    var secondsInput = 53;
        //    var minutesInput = 30;
        //    var hoursInput = 15;

        //    var expectedResponse = true;

        //    // Act

        //    var response = time.IsValid(hoursInput, minutesInput, secondsInput);

        //    // Assert

        //    Assert.Equal(response, expectedResponse);
        //}

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

        // How is this test supposed to be implemented???
        [Theory]
        [InlineData(0, 0, 0, 5, 0, 0, 5)] //Addition 
        [InlineData(0, 0, 55, 5, 0, 1, 0)]

        public void AddOperator_Test(int hours, int minutes, int seconds, int secondsAdded, int hoursExpected, int minutesExpected, int secondsExpected)
        {
            // Arrange
            var time1 = new Time(hours, minutes, seconds);
            var time2 = new Time(hoursExpected, minutesExpected, secondsExpected);

            // Act

            
            // Assert

        }

        //[Theory]
        //[InlineData(0, 0, 10, -5, 0, 0, 5)] //Subtraktion
        //[InlineData(0, 0, 0, -5, 23, 59, 55)]
        //public void SubOperator_Test(int hours, int minutes, int seconds, int secondsSubtracted, int hoursExpected, int minutesExpected, int secondsExpected) 
        //{ 
        //}
    }
}