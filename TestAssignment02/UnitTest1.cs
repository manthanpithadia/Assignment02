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



        //TestCaseForFunction01: Test Cases for ConvertCelciusToFahrenheit
        [Test]
        public void ConvertCelciusToFahrenheit_TempInInt_ReturnsFahrenheit()
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
        public void ConvertCelciusToFahrenheit_TempInString_ReturnsFahrenheit()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = "dummy data";
            double expectedResult = 33; 
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData))
            {
                conversion = new Conversion(program.num);                
            }
            else {
                conversion = new Conversion();
            }
            result = conversion.ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }

        [Test]
        public void ConvertCelciusToFahrenheit_TempInFloat_ReturnsFahrenheit()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 65.46;
            double expectedResult = 33;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertCelciusToFahrenheit();

            //Assert
            Assert.AreEqual(Math.Round(result,2), expectedResult);
        }


        //TestCaseForFunction02: Test Cases for ConvertCelciusToKelvin
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
        public void ConvertCelciusToKelvin_TempInString_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = "dummy data";
            double expectedResult = 274.15;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }

        [Test]
        public void ConvertCelciusToKelvin_TempInFloat_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 13.5;
            double expectedResult = 274.15;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertCelciusToKelvin();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }



        //TestCaseForFunction03: Test Cases for ConvertFahrenheitToCelcius
        [Test]
        public void ConvertFahrenheitToCelcius_TempInInt_ReturnsCelcius()
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
        public void ConvertFahrenheitToCelcius_TempInString_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = "dummy data";
            double expectedResult = -17;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }

        [Test]
        public void ConvertFahrenheitToCelcius_TempInFloat_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 96.4;
            double expectedResult = -17;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertFahrenheitToCelsius();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }



        //TestCaseForFunction04: Test Cases for ConvertFahrenheitToKelvin
        [Test]
        public void ConvertFahrenheitToKelvin_TempInInt_ReturnsKelvin()
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
        public void ConvertFahrenheitToKelvin_TempInFloat_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 96.4;
            double expectedResult = 256.28;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }

        [Test]
        public void ConvertFahrenheitToKelvin_TempInString_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = "dummy data";
            double expectedResult = 256.28;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertFahrenheitToKelvin();

            //Assert
            Assert.AreEqual(Math.Round(result,2),expectedResult);
        }




        //TestCaseForFunction05: Test Cases for ConvertKelvinToCelcius
        [Test]
        public void ConvertKelvinToCelcius_TempInInt_ReturnsCelcius()
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
        public void ConvertKelvinToCelcius_TempInFloat_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 96.4;
            double expectedResult = -272.15;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }

        [Test]
        public void ConvertKelvinToCelcius_TempInString_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = "dummy data";
            double expectedResult = -272.15;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertKelvinToCelsius();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }




        //TestCaseForFunction06: Test Cases for ConvertKelvinToFahrenheit
        [Test]
        public void ConvertKelvinToFahrenheit_TempInInt_ReturnsFahrenheit()
        {
            //Arrange
            var testData = 5;
            var expectedResult = -450.67;
            var conversion = new Conversion(testData);

            //Act
            var result = conversion.ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }


        [Test]
        public void ConvertKelvinToFahrenheit_TempInString_ReturnsFahrenheit()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

          
            //Arrange
            var testData = "dummy data";
            double expectedResult = -457.87;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput("abcd"))
            {
                conversion = new Conversion(program.num);               
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(Math.Round(result, 2), expectedResult);
        }

        [Test]
        public void ConvertKelvinToFahrenheit_TempInFloat_ReturnsFahrenheit()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 65.45;
            double expectedResult = -457.87;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData.ToString()))
            {
                conversion = new Conversion(program.num);
            }
            else
            {
                conversion = new Conversion();
            }
            result = conversion.ConvertKelvinToFahrenheit();

            //Assert
            Assert.AreEqual(Math.Round(result,2), expectedResult);
        }

    }
}