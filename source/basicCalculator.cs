// Programmed by MD. Mehedi Hasan

using System;

namespace Calculator_APP {

    class Calculator {

        static void Main() {
            
            Console.Write("Enter start to continue, or enter exit to quit: ");
            
            // member variables
            string command = Console.ReadLine(); 
            int x;
            int y;
            int sum;

            if (command == "exit") 
                {
                    Console.WriteLine("program exited !");  
                    
                }

            else if (command == "start")
                {

                    Console.Write("enter a number: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("enter another number: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    sum = x + y;

                    Console.WriteLine("result: {0}", sum);
                }
            Console.ReadLine();
        }
    }
}