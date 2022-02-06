using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.init();
        }

        public void init() {
            Console.WriteLine("Please enter temprature value*");
            Console.WriteLine("Note: Value must be greater than zero and should be an integer number");
            newLine();

            //Validation
            int num;
            do
            {
                Console.WriteLine("enter here:");
            } while (!int.TryParse(Console.ReadLine(), out num) || !(num > 0));

            //Creating object
            Conversion objConversion = new Conversion(num);

            //Printing output
            newLine();
            Console.WriteLine("output:");
            Console.WriteLine("-------");
            newLine();
            Console.WriteLine($"°C to °F :{round(objConversion.ConvertCelciusToFahrenheit())}");
            Console.WriteLine($"°C to K  :{round(objConversion.ConvertCelciusToKelvin())}");
            Console.WriteLine($"°F to °C :{round(objConversion.ConvertFahrenheitToCelsius())}");
            Console.WriteLine($"°F to K  :{round(objConversion.ConvertFahrenheitToKelvin())}");
            Console.WriteLine($"K to °C  :{round(objConversion.ConvertKelvinToCelsius())}");
            Console.WriteLine($"K to °F  :{round(objConversion.ConvertKelvinToFahrenheit())}");
            newLine();
        }
        public void newLine() => Console.WriteLine("");

        public double round(double value) => Math.Round(value,2);
        
    }
}
