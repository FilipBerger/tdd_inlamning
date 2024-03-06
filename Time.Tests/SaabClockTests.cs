using tdd_inlamning;

namespace tdd.inlamning.Tests
{
    public class SaabClockTests
    {
        [Fact]
        public void IsValidTime_Test()
        {
            // Arrange
            var time = new Time();

            var secondsInput = 53;
            var minutesInput = 30;
            var hoursInput = 15;

            var expectedResponse = true;

            // Act

            var response = time.IsValid(hoursInput, minutesInput, secondsInput);

            // Assert

            Assert.Equal(response, expectedResponse);
        }
    }
}