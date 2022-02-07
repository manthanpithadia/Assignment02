using Assignment02;
using NUnit.Framework;
using System;

namespace TestAssignment02
{
    public class ConversionTestOld
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
        public void ConvertCelciusToKelvin_TempInDecimal_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            decimal testData = 65.6m;
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
        public void ConvertCelciusToKelvin_TempInBool_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            bool testData = true;
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
        public void ConvertCelciusToKelvin_TempInDouble_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            double testData = 65.4;
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
        public void ConvertFahrenheitToCelcius_TempInLong_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            long testData = 65132321328l;
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
        public void ConvertFahrenheitToCelcius_TempInNumAndString_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 1234 + "dummy data";
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
        public void ConvertFahrenheitToCelcius_TempInNegativeInt_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = -89;
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
        public void ConvertFahrenheitToKelvin_TempInNegativeFloat_ReturnsKelvin()
        {
            /*
            * Wrong Input by user
            * so Class will take default temp value as 1
            */

            //Arrange
            var testData = -96.4;
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
        public void ConvertFahrenheitToKelvin_TempNull_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            Nullable<int> testData = null;
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
        public void ConvertFahrenheitToKelvin_TempZero_ReturnsKelvin()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = 0;
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
        public void ConvertKelvinToCelcius_TempInSpecialChar_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            var testData = "*/.,#@!%^";
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
        public void ConvertKelvinToCelcius_TempInChar_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            char testData = 'm';
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
        public void ConvertKelvinToCelcius_TempInNegativeDecimal_ReturnsCelcius()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            decimal testData = 65.23m;
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
        public void ConvertKelvinToFahrenheit_TempOne_ReturnsFahrenheit()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */


            //Arrange
            var testData = "1";
            double expectedResult = -457.87;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData))
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
        public void ConvertKelvinToFahrenheit_TempInNumAndSpecialChar_ReturnsFahrenheit()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

          
            //Arrange
            var testData = "1321+$^#$%@#%";
            double expectedResult = -457.87;
            var program = new Program();
            double result;
            Conversion conversion;

            //Act            
            if (!program.validateInput(testData))
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
        public void ConvertKelvinToFahrenheit_TempEmptyString_ReturnsFahrenheit()
        {
            /*
             * Wrong Input by user
             * so Class will take default temp value as 1
             */

            //Arrange
            string testData = string.Empty;
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