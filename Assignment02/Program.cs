using System;

namespace Assignment02
{
    public class Program
    {
        public int num;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.init();
        }

        public void init() {
            
            //Initializing num value
            num = 0;

            Console.WriteLine("Please enter temprature value*");
            Console.WriteLine("Note: Value must be greater than zero and should be an integer number");
            newLine();

            //Validation            
            do
            {
                Console.WriteLine("enter here:");
            } while (validateInput(Console.ReadLine()));

            //Creating object
            Conversion objConversion = new Conversion();

            //Printing output
            newLine();
            Console.WriteLine("output:");
            Console.WriteLine("-------");
            newLine();
            Console.WriteLine($" {num} °C to °F :{round(objConversion.ConvertCelciusToFahrenheit())}");
            Console.WriteLine($" {num} °C to K  :{round(objConversion.ConvertCelciusToKelvin())}");
            Console.WriteLine($" {num} °F to °C :{round(objConversion.ConvertFahrenheitToCelsius())}");
            Console.WriteLine($" {num} °F to K  :{round(objConversion.ConvertFahrenheitToKelvin())}");
            Console.WriteLine($" {num} K to °C  :{round(objConversion.ConvertKelvinToCelsius())}");
            Console.WriteLine($" {num} K to °F  :{round(objConversion.ConvertKelvinToFahrenheit())}");
            newLine();
        }
        public void newLine() => Console.WriteLine("");

        public double round(double value) => Math.Round(value,2);

        public bool validateInput(string input) {

            if (!int.TryParse(input, out num) || !(num > 0)) {
                return true;
            }
            return false;
        }
        
    }
}
