using tdd_inlamning;

namespace Times.Tests
{
    public class TimeTests
    {
        [Fact]
        public void ValidTimeFormat_Test()
        {
            // Arrange
            var time = new Time();

            var secondsInput = 53;
            var minutesInput = 30;
            var hoursInput = 12;

            var expectedResponse = new DateTime(12,30,53);

            // Act

            var response = time.GetTime(secondsInput, minutesInput, hoursInput);

            // Assert

            Assert.Equal(expectedResponse, response);

            //var validTime = new ValidTime();
            

        }
    }
}