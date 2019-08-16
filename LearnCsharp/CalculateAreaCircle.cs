using System;

namespace LearnCsharp{
    public class CalculateAreaCircle{
        public static void AreaCircle(){
            double radius;
            double area;

            Console.Write("Enter the radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = radius * radius * 3.14159;

            Console.Write("The area for the circle of radius {0} is {1}", radius, area);
            Console.ReadKey();
        }
    }
}