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
            var result = time.IsValid(hours, minutes, seconds);
            
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

        [Fact]
        public void ReturnsTimeString24HourFormat_Test()
        {
            // Arrange
            var time = new Time();

            var secondsInput = 53;
            var minutesInput = 30;
            var hoursInput = 15;

            var expectedResponse = "15:30:53";

            // Act

            var response = time.To24HourString(hoursInput, minutesInput, secondsInput);

            // Assert

            Assert.Equal(response, expectedResponse);
        }
    }
}