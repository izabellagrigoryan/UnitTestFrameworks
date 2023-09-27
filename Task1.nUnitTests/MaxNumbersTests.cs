using MaxNumbers;
using NUnit.Framework;

namespace Task1.nUnitTests
{
    public class MaxNumberTests
    {
        private MaxNumbersOf _maxNumbersOf { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _maxNumbersOf = new MaxNumbersOf();
        }

        //determining the maximum number of unequal consecutive characters in a string
        //positive cases

        [TestCase("I am studying well")]
        [TestCase("U're studying well")]
        public void MaxNumberOfUnEqualsTest(string input)
        {
            //Arrange
            var _maxCount = 17;

            //Act
            var maxCount = _maxNumbersOf.MaxNumberOfUnEquals(input);
            
            //Assert
            Assert.That(maxCount, Is.EqualTo(_maxCount));
        }

        //determining the maximum number of unequal consecutive characters in a string
        //negative cases

        [TestCase("You are studying well")]
        [TestCase("I will study well")]
        public void MaxNumberOfUnEqualsNonTest(string input)
        {
            //Arrange
            var _maxCount = 17;

            //Act
            var maxCount = _maxNumbersOf.MaxNumberOfUnEquals(input);

            //Assert
            Assert.That(maxCount, Is.Not.EqualTo(_maxCount));
        }

        //determining the maximum number of consecutive identical letters of the Latin alphabet 
        //positive cases

        [TestCase("I am studying well")]
        [TestCase("U're studying well")]
        [TestCase("I will study well in ####")]
        public void MaxNumberOfEqualsLettersTest(string input)
        {
            //Arrange
            var _maxCount = 2;

            //Act
            var maxCount = _maxNumbersOf.MaxNumberOfEqualsLetters(input);

            //Assert
            Assert.That(maxCount, Is.EqualTo(_maxCount));
        }

        //determining the maximum number of consecutive identical letters of the Latin alphabet 
        //negative cases

        [TestCase("You are studying well")]
        [TestCase("I will study well")]
        public void MaxNumberOfEqualsLettersNonTest(string input)
        {
            //Arrange
            var _maxCount = 3;

            //Act
            var maxCount = _maxNumbersOf.MaxNumberOfEqualsLetters(input);

            //Assert
            Assert.That(maxCount, Is.Not.EqualTo(_maxCount));
        }

        //determining the maximum number of consecutive identical digits 
        //positive cases

        [TestCase("I will study well in 2222")]
        public void MaxNumberOfEqualsDigitsTest(string input)
        {
            //Arrange
            var _maxCount = 4;

            //Act
            var maxCount = _maxNumbersOf.MaxNumberOfEqualsDigits(input);

            //Assert
            Assert.That(maxCount, Is.EqualTo(_maxCount));
        }

        //determining the maximum number of consecutive identical digits 
        //negative cases

        [TestCase("You are studying well")]
        [TestCase("I will study well in 2222")]
        public void MaxNumberOfEqualsDigitsNonTest(string input)
        {
            //Arrange
            var _maxCount = 3;

            //Act
            var maxCount = _maxNumbersOf.MaxNumberOfEqualsDigits(input);

            //Assert
            Assert.That(maxCount, Is.Not.EqualTo(_maxCount));
        }
    }
}