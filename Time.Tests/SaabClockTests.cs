using tdd_inlamning;

namespace tdd.inlamning.Tests
{
    public class SaabClockTests
    {
        [Fact]
        public void ValidTimeFormat_Test()
        {
            // Arrange
            var saabClock = new SaabClock();

            var secondsInput = 53;
            var minutesInput = 30;
            var hoursInput = 12;

            var expectedResponse = new TimeOnly(12,30,53);

            // Act

            var response = saabClock.GetTime(hoursInput, minutesInput, secondsInput);

            // Assert

            Assert.Equal(expectedResponse, response);
        }
    }
}