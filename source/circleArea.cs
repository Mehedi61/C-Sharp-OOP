// Programmed by MD. Mehedi Hasan

using System;

namespace CalculateCircleArea {
    
    class CircleArea {
        static void Main() {
            
            const double pi = 3.1416;   // declaring a constant .

            double r;     // r means radius.
            Console.Write("Enter the value of radius: ");
            r = Convert.ToDouble(Console.ReadLine());   // getting input & converting to double data type.

            double circle_area = pi * r * r;    // calculating circle area .
            Console.WriteLine("Circle area is: {0}", circle_area);

            Console.ReadLine();

        }
    }
}