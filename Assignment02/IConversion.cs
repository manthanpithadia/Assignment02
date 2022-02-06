using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public interface IConversion
    {
        double ConvertCelciusToFahrenheit();
        double ConvertCelciusToKelvin();
        double ConvertKelvinToFahrenheit();
        double ConvertKelvinToCelsius();
        double ConvertFahrenheitToKelvin();
        double ConvertFahrenheitToCelsius();
    }
}
