using System;

namespace LearnCsharp
{
    public class addThreeNumbers
    {
        public static void add3()
        {
            int integer1;
            int integer2;
            int integer3;
            int sum;

            Console.Write("Enter first Integer: ");
            integer1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Integer: ");
            integer2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Integer: ");
            integer3 = Convert.ToInt32(Console.ReadLine());

            sum = integer1 + integer2 + integer3;

            Console.WriteLine("Sum is {0}",sum);
            Console.ReadKey();
        }
    }
}