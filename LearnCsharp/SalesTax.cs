using System;

namespace LearnCsharp{
    public class SalesTax{
        public static void DisplayTax(){
            double purchaseAmount;
            double taxPercent;
            double salesTax;

            Console.Write("Enter purchase amount: ");
            purchaseAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter tax percent (0.05): ");
            taxPercent = Convert.ToDouble(Console.ReadLine());

            salesTax = purchaseAmount * taxPercent;
           
            Console.Write("Sale tax is $" + (int) (salesTax * 100) / 100.0);
            Console.ReadKey();
                
        }
    }
}