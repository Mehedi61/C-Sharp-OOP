// programmed by MD. Mehedi Hasan

using System;

namespace DicisionMakingApplication {
    class Conditional_Program {
        
        static void Main() {
            
            // declaring two variables .
            int value_one;
            int value_two;
            
            Console.Write("Enter a value: ");
            value_one = Convert.ToInt32(Console.ReadLine());  // taking a value form user .
            
            Console.Write("Enter another value: ");
            value_two = Convert.ToInt32(Console.ReadLine());  // taking another value from user .

            // finding the largest value . 
            if (value_one > value_two) {
                Console.WriteLine("{0} is greater than {1} .", value_one, value_two);
                Console.ReadLine();
            }

            else {
                Console.WriteLine("{0} is greater than {1} .", value_two, value_one);
                Console.ReadLine();
            }
        }
    }
}