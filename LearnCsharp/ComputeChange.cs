using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCsharp
{
    class ComputeChange
    {
        public static void CalcChange()
        {
            Console.Write("Enter an amount (e.g. 11.56): ");
            double amount = Convert.ToDouble(Console.ReadLine());

            int remainingAmount = (int)(amount * 100);

            // Find the number of one dollars
            int numberOfOneDollars = remainingAmount / 100;
            remainingAmount = remainingAmount % 100;

            // Find the number of quarters in the remaining amount
            int numberOfQuarters = remainingAmount / 25;
            remainingAmount = remainingAmount % 25;

            // Find the number of dimes in the remaining amount
            int numberOfDimes = remainingAmount / 10;
            remainingAmount = remainingAmount % 10;

            // Find the number of nickels in the remaining amount
            int numberOfNickes = remainingAmount / 5;
            remainingAmount = remainingAmount % 5;

            // Find the number of pennis in the remaining amount
            int numberOfPennis = remainingAmount;

            // Display results
            Console.Write("Your amount {0} consist of \n" +
                "\t {1} dollars\n" +
                "\t {2} quarters\n" +
                "\t {3} dimes\n" +
                "\t {4} nickels\n" +
                "\t {5} pennies", amount, numberOfOneDollars, numberOfQuarters, numberOfDimes, numberOfNickes, numberOfPennis);
        }
    }
}
