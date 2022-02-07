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
            int option;

            do
            {
                Console.WriteLine("Please Select options from below");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin ");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                newLine();

                do {
                    Console.WriteLine("select option:");
                } while (!int.TryParse(Console.ReadLine(), out option) || !(option>0 && option<8));
                newLine();
                
                if (option == 7) break;

                Console.WriteLine("Please enter temprature value*");
                Console.WriteLine("Note: Value must be greater than zero and should be an integer number");
                Console.WriteLine("Enter temp:");

            } while (validateInput(Console.ReadLine()));

            //Creating object
            Conversion objConversion = new Conversion();

            //Printing output
            newLine();
            Console.WriteLine("output:");
            Console.WriteLine("-------");
            newLine();
            switch (option) {
                case 1:
                    Console.WriteLine($" {num} °C to °F :{round(objConversion.ConvertCelciusToFahrenheit())}");
                    break;
                case 2:
                    Console.WriteLine($" {num} °C to K  :{round(objConversion.ConvertCelciusToKelvin())}");
                    break;
                case 3:
                    Console.WriteLine($" {num} °F to °C :{round(objConversion.ConvertFahrenheitToCelsius())}");
                    break;
                case 4:
                    Console.WriteLine($" {num} °F to K  :{round(objConversion.ConvertFahrenheitToKelvin())}");
                    break;
                case 5:
                    Console.WriteLine($" {num} K to °C  :{round(objConversion.ConvertKelvinToCelsius())}");
                    break;
                case 6:
                    Console.WriteLine($" {num} K to °F  :{round(objConversion.ConvertKelvinToFahrenheit())}");
                    break;
                case 7:
                    Console.WriteLine("Exit");
                    break;

            }                       

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
