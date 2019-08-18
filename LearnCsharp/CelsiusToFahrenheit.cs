using System;

namespace LearnCsharp
{
    public class CelsiusToFahrenheit{
        public static void CeToFa(){

            Console.Write("Enter a temperature in Celsius: ");
            double celsius = Convert.ToInt32(Console.ReadLine());
            double fahrenheit = (9 / 5) * celsius + 32;

            Console.WriteLine("{0} Celsius is {1} Fahrenheit",celsius,fahrenheit);
            Console.ReadKey();


            
        }
    }
}