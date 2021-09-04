using System;

namespace projectvscode
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double diameter;
            double circumference;
            double area;

            Console.WriteLine("Enter a value for radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            diameter = 2 * radius;
            circumference = 2 * radius * Math.PI ;
            area = radius * radius * Math.PI ;

            Console.WriteLine("Diameter of the circle is: {0}", diameter);
            Console.WriteLine("Circumference of the circle is: {0}", circumference);
            Console.WriteLine("Area of the circle is: {0}", area);
            Console.ReadLine();
        }
    }
}
