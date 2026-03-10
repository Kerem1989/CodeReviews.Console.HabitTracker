namespace Kerem.HabitTracker.UnitTests ;

    public class ValidationHelperTests
    {

        [TestCase("Test", true)]
        [TestCase("", false)]
        [Test]
        public void ValidateTextInput_ReturnsTrue_WhenInputIsNotEmpty(string inputParam, bool expected)
        {
            var input = ValidationHelper.ValidateTextInput(inputParam);
            Assert.That(input, Is.EqualTo(expected));
        }
        
        [TestCase(5, true)]
        [TestCase(-5, false)]
        [Test]
        public void ValidateNumericalInput_ReturnsTrue_WhenInputIsPositive(int inputParam, bool expected)
        {
            var input = ValidationHelper.ValidateNumericalInput(5);
            Assert.That(input, Is.True);
        }
        
        [TestCase(-5, false)]
        [TestCase(0, false)]
        [Test]
        public void ValidateNumericalInput_ReturnsFalse_WhenInputIsNegative(int inputParam, bool expected)
        {
            var input = ValidationHelper.ValidateNumericalInput(-5);
            Assert.That(input, Is.False);
        }
    }