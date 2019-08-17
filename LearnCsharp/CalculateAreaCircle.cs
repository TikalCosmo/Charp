using System;

namespace LearnCsharp{
    public class CalculateAreaCircle{
        public static void AreaCircle(){
            double radius;  // Declare a variable to store the radius.
            double area;    // Declare a variable to store the area.

            Console.Write("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
                
            if (radius >=0 )
            {
                // calculate the area of the circle
                area = radius * radius * 3.14159;

                Console.Write("The area for the circle of radius {0} is {1}", radius, area);
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine($"{ radius } is not a valid radius.");
            }

            System.Console.ReadKey();
        }
    }
}