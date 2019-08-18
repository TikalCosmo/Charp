using System;

namespace LearnCsharp{
    public class CompundInterest{
        public static void ComputeLoan(){
            double loanAmount;
            double annualInterestRate;
            double monthlyInterestRate;
            int numberOfYears;
            double monthlyPayment;
            double totalPayment;

            Console.Write("Enter loan amount: ");
            loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter annual interest rate: ");
            annualInterestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number of years as an integer: ");
            numberOfYears = int.Parse(Console.ReadLine());

            monthlyInterestRate = annualInterestRate/100/12;

            monthlyPayment = loanAmount * monthlyInterestRate / (1 -1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));
            totalPayment = monthlyPayment * numberOfYears * 12;

            Console.WriteLine("The monthly payment is $" + (int)(monthlyPayment * 100) /100.0);
            Console.WriteLine("The total payment is $" + (int) (totalPayment * 100) / 100.0);

            Console.ReadKey();

        }
    }
}