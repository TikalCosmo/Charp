using System;

namespace LearnCsharp{
    public class addTwoIntegers{
        public static void add2()
        {
            // Displaying the sum of two numbers input from the keyboard.
            // declare variable for first number to add
            // declare variable for second number to add
            // declare variable for sum of two numbers
            // promp user
            // read first number from user
            // prompt user
            // read second number from user
            // add numbers
            // display sum

            int firstInteger;
            int secondInteger;
            int sum;

            Console.Write("Enter first integer: ");
            firstInteger = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            secondInteger = Convert.ToInt32(Console.ReadLine());

            sum = firstInteger + secondInteger;

            Console.Write("Sum is {0}", sum );
            Console.ReadKey();

            


            

        }
    }
}