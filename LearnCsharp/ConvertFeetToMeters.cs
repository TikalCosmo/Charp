using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCsharp
{
    class ConvertFeetToMeters
    {
        public static void FeetToMeters()
        {
            Console.Write("Enter a value for feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double meters = feet * 0.305;
            Console.Write("{0} feet is {1} meters", feet, meters);
        }
    }
}
