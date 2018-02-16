// programmed by MD. Mehedi Hasan

using System;

namespace LoopApplication {
    
    class For_Loop {

        static void Main() {
            
            int n;  // declaring a variable without value

            for (n = 1; n <= 20 ; n++) {
                
                // assigned 1 as the value of n and printing 1-20 using for loop     
                Console.WriteLine("Value of N is: {0}", n);
            }
            Console.ReadLine();
        }
    }
}