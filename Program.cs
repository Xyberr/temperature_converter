using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter!");
            Console.WriteLine("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F1}");

            Console.WriteLine("Enter temperature in Fahrenheit: ");
            double fahrenheit2 = double.Parse(Console.ReadLine());
            double celsius2 = FahrenheitToCelsius(fahrenheit2);
            Console.WriteLine($"Temperature in Celsius: {celsius2:F1}");

            Console.ReadLine();
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }
    }
}