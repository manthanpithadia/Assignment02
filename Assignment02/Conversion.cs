using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Conversion : IConversion
    {
        private int temp;
        Conversion() { 
            //Initializing temp value=1
            temp = 1; 
        }
        Conversion(int temp) { 
            //Initializing temp value with parameterized constructor
            this.temp = temp; 
        }

        //Assuming that temprature is in Celcius
        public double ConvertCelciusToFahrenheit() => (9 / 5) * temp + 32;


        //Assuming that temprature is in Celcius
        public double ConvertCelciusToKelvin() => temp + 273.15;


        //Assuming that temprature is in Fahrenheit
        public double ConvertFahrenheitToCelsius() => (5 / 9) * (temp - 32);


        //Assuming that temprature is in Fahrenheit
        public double ConvertFahrenheitToKelvin() => 273.5 + ((temp - 32.0) * (5.0 / 9.0));


        //Assuming that temprature is in Kelvin
        public double ConvertKelvinToCelsius() => temp - 273.15;


        //Assuming that temprature is in Kelvin
        public double ConvertKelvinToFahrenheit() => ((temp - 273.15) * 1.8) + 32;
    }
}
