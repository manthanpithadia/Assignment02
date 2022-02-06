using Assignment02;
using NUnit.Framework;
using System;

namespace TestAssignment02
{
    public class ConversionTest
    {

        [Test]
        public void ValidateInput_InputIsLessThanZero_ReturnsFalse()
        {
            //Arrange           
            var program = new Program();

            //Act
            var result = program.validateInput("-1");

            //Assert
            Assert.IsTrue(result);            
        }



        [Test]
        public void ConvertCelciusToFahrenheit_TempInCelcius_ReturnsFahrenheit()
        {
            //Arrange
            var testData = 5;
            var expectedResult = 41;
            var conversion = new Conversion(testData);
            
            //Act
            var result = conversion.ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void ConvertCelciusToKelvin_TempInCelcius_ReturnsKelvin()
        {
            //Arrange
            var testData = 5;
            var expectedResult = 278.15;
            var conversion = new Conversion(testData);

            //Act
            var result = conversion.ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void ConvertFahrenheitToCelcius_TempInFahrenheit_ReturnsCelcius()
        {
            //Arrange
            var testData = 5;
            var expectedResult = -15;
            var conversion = new Conversion(testData);

            //Act
            var result = conversion.ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_TempInFahrenheit_ReturnsKelvin()
        {
            //Arrange
            var testData = 5;
            var expectedResult = 258.5;
            var conversion = new Conversion(testData);

            //Act
            var result = conversion.ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void ConvertKelvinToCelcius_TempInKelvin_ReturnsCelcius()
        {
            //Arrange
            var testData = 5;
            var expectedResult = -268.15;
            var conversion = new Conversion(testData);

            //Act
            var result = conversion.ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_TempInKelvin_ReturnsFahrenheit()
        {
            //Arrange
            var testData = 5;
            var expectedResult = -450.67;
            var conversion = new Conversion(testData);

            //Act
            var result = conversion.ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult );
        }

    }
}