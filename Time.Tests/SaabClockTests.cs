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
        [InlineData(15, 20, 23, false, "03:20:23 pm")]

        public void ReturnsTimeToString_Test(int hours, int minutes, int seconds, bool is24HourFormat, string expected)
        {
            // Arrange
            var time = new Time(hours, minutes, seconds);

            // Act

            string result = time.TimeToString(is24HourFormat);

            // Assert

            Assert.Equal(expected, result);
        }
    }
}