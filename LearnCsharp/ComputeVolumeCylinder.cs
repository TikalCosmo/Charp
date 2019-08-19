using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCsharp
{
    class ComputeVolumeCylinder
    {
        public static void CylinderVolume()
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            double area = radius * radius * 3.14159;
            double volume = area * length;

            Console.WriteLine("The area is {0}", area);
            Console.WriteLine("The volume of the cylinder is {0}", volume);
        }
    }
}
